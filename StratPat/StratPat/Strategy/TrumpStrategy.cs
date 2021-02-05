using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo.Strategy
{
    class TrumpStrategy : IPresidentStrategy
    {
        public void President(double numberOne, double numberTwo)
        {
            var result = numberOne * numberTwo;
            Console.WriteLine("Trump is president #" + result);
        }
    }
}
