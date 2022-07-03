using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PokeDex.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
