using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProj.Models
{
    public class Review
    {
        public string Group { get; set; }
        public string Text { get; set; }
        public byte Mark { get; set; }
        public float Rating { get; set; }
    }
}
