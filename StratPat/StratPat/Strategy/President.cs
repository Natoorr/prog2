using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    class President
    {
        private IPresidentStrategy _strategy;

        // Constructor

        public President(IPresidentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PresidentInterface(double num1, double num2)
        {
            _strategy.President(num1, num2);
        }
    }
}
