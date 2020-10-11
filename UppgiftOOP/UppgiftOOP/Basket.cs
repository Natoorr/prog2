using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftOOP
{
    class Basket
    {
        private int _apples;
        private int _oranges;
        private int _bananas;
        
        public void BuyApples(int apples)
        {
            _apples = apples;
        }
        public void BuyOranges(int oranges)
        {
            _oranges = oranges;
        }
        public void BuyBananas(int bananas)
        {
            _bananas = bananas;
        }

        public int Apples()
        {
            int apples = _apples;
            return apples;
        }
        public int Oranges()
        {
            int oranges = _oranges;
            return oranges;
        }
        public int Bananas()
        {
            int bananas = _bananas;
            return bananas;
        }



    }
}
