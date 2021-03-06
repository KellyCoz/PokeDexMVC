using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokeDexMVC.Data;
using PokeDexMVC.Models;


namespace PokeDexMVC.Controllers
{
    public class PokemonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PokemonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pokemons
        public async Task<IActionResult> Index()
        {
              return _context.Pokemons != null ? 
                          View(await _context.Pokemons.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Pokemons'  is null.");
        }

        // GET: Pokemons/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokemon == null)
            {
                return NotFound();
            }
            //Call the client
            var client = PokeApi.Client();
            var pokemonResult = await client.GetPokemonAsync(pokemon.Name.ToLower());
            pokemon.GetTypes(pokemonResult);

            var primaryType = await client.GetTypesAsync(pokemon.PrimaryType.ToLower());


            if (pokemon.SecondaryType != "none")
            {
                var secondaryType = await client.GetTypesAsync(pokemon.SecondaryType.ToLower());
                //invoke 'MapType' from the Pokemon class on the pokemon displayed, using the pokemon's type
                pokemon.StronglyAttacks = pokemon.GetStrongAttackType(primaryType) + ", " + pokemon.GetStrongAttackType(secondaryType);
                pokemon.StronglyDefends = pokemon.GetStrongDefendType(primaryType) + ", " + pokemon.GetStrongDefendType(secondaryType);
                pokemon.WeaklyAttacks = pokemon.GetWeakAttackType(primaryType) + ", " + pokemon.GetWeakAttackType(secondaryType);
                pokemon.WeaklyDefends = pokemon.GetWeakDefendType(primaryType) + ", " + pokemon.GetWeakDefendType(secondaryType);
            }
            else
            {
                pokemon.StronglyAttacks = pokemon.GetStrongAttackType(primaryType);
                pokemon.StronglyDefends = pokemon.GetStrongDefendType(primaryType);
                pokemon.WeaklyAttacks = pokemon.GetWeakAttackType(primaryType);
                pokemon.WeaklyDefends = pokemon.GetWeakDefendType(primaryType);

            }
            return View(pokemon);
        }

        // GET: Pokemons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pokemons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type")] Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                pokemon.Id = Guid.NewGuid();
                _context.Add(pokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokemon);
        }

        // GET: Pokemons/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            return View(pokemon);
        }

        // POST: Pokemons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,elementType")] Pokemon pokemon)
        {
            if (id != pokemon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokemon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonExists(pokemon.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pokemon);
        }

        // GET: Pokemons/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // POST: Pokemons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Pokemons == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Pokemons'  is null.");
            }
            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon != null)
            {
                _context.Pokemons.Remove(pokemon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonExists(Guid id)
        {
          return (_context.Pokemons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
