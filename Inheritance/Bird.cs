using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird()
        {
        }
        public string doesItFly { get; set; }
        public string canItMimic { get; set; }
        public int featherColors { get; set; }
    }
}
