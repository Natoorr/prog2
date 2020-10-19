using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftOOP
{
    class Customer
    {
        private string _name;
        public List<Product> _cart = new List<Product>();
        
        
        public string Name
        {
            get { return _name; }
            set { string _name = value; }
        }

        public Customer(string name)
        {
            _name = name;

        }

        
        
    }
}
