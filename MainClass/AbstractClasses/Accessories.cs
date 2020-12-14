using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class Accessories
    {
        public int Cost { get; set; }

        public string Size { get; set; }

        public abstract void Break();

        public abstract void Clean();


    }
}
