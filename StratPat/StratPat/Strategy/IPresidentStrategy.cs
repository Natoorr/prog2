using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo
{
    interface IPresidentStrategy
    {
        void President(double numberOne, double numberTwo);
    }
}
