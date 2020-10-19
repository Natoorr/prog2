using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace UppgiftOOP
{
    class Product
    {
        public string _name;
        private int _cost;
        private int _quantity;
        public int _totalCost;




        public Product(string name, int cost, int quantity)
        {
            _name = name;
            _cost = cost;
            _quantity = quantity;
            
            _totalCost = cost * quantity;
        }
    }
}
