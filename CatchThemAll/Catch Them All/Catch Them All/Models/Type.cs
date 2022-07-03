using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeDex.Models
{
    public class Type
    {
        public List<string> Attacks { get; set; }
        public List<string> Strengths { get; set; }
        public List<string> Weaknesses { get; set; }
    }
}
