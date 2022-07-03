using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Catch_Them_All.Models
{
    public class Character
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<Type> Types { get; set; }
        public int Level { get; set; }
    }
}
