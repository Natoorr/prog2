using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftOOP
{
    class Customer
    {
        private string _name;
        private int _age;
        private Basket _basket;

        public string Name
        {
            get { return _name; }
            set { string _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { int _age = value; }
        }



        public Customer(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void CustomerBasket(int apples, int oranges, int bananas)
        {
            _basket.BuyApples(apples);
            _basket.BuyOranges(oranges);
            _basket.BuyBananas(bananas);

        }

        public string CallBasket()
        {
            string callBasket = _basket.Apples() + " apples, " + _basket.Oranges() + " oranges and " + _basket.Bananas() + " bananas";
            return callBasket;
        }
        
    }
}
