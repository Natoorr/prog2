using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi
{
    class Nocco : Product
    {
        private string _flavor;

        public string Flavor
        {
            get { return _flavor; }
            set { _flavor = value; }
        }

    }
}
