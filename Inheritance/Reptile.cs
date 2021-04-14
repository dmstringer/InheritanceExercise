using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {
        }
        public string laysEggs { get; set; }
        public string coldBlooded { get; set; }
        public int scaleColors { get; set; }
    }
}
