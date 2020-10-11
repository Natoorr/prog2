using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace UppgiftOOP
{
    class Product
    {
        private string _name; 
        private int _cost; 

        public string Name
        {
            get { return _name; }
            set { string _name = value; }
        }

        public int Cost
        {
            get { return _cost; }
            set { int _cost = value; }
        }

        public Product(string name, int cost)
        {
            _name = name;
            _cost = cost;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetCost(int cost)
        {
            _cost = cost;
        }

    }
}
