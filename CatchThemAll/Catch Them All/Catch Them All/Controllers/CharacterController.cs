using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using PokeDex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeDex.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ApplicationDBContext _context;

        public CharacterController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Create(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //ReadAll action
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Pokemon";
            //convert our db set into a list to return to our view
            var model = _context.Characters.ToList();
            return View(model);
        }
    
        public IActionResult GetActive()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return View(model);
        }
        [Route("Character/{name}/Details")]
        public IActionResult Details(string name)
        {
            ViewData["Title"] = name;
            //Make sure we get the correct character back, we return only a character with a matching Name
            var model = _context.Characters.FirstOrDefault(e=>e.Name == name);
            return View(model);
        }

        public IActionResult Update(Character character)
        {
            _context.Entry(character).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string name)
        {
            var original = _context.Characters.FirstOrDefault(e => e.Name == name);
           //make sure we find a record before we attempt to delete it
            if(original != null)
            {
                _context.Characters.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
