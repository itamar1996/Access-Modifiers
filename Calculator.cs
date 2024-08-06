using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Calculator
    {
        internal int Add(int x, int y)
        { 
        return x+ y;
        }
    }
    internal class MathOperations
    {
        Calculator calc;
        public MathOperations() 
        { 
            calc = new Calculator();
        }
        public int add2(int x ,int y)
        {
            return calc.Add(x,y);
        }
    }

}
