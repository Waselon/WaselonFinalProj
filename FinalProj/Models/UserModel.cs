using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProj.Models;

namespace FinalProj.Models
{
    public class User
    {
        public string Username { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
