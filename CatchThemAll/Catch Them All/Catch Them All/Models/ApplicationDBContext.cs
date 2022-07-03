using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Catch_Them_All.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
