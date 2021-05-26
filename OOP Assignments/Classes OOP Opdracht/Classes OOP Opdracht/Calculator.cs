using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_OOP_Opdracht
{
    class Calculator
    {
        public double result { get; set; }

        public void Add(double addAmount) 
        {
            result += addAmount;
        }

        public void Subtract(double subtractAmount) 
        {
            result -= subtractAmount;
        }

        public void Multiply(double multiplyAmount) 
        {
            result *= multiplyAmount;
        }

        public void Divide(double divideAmount) 
        {
            result /= divideAmount;
        }

        public void Clear() 
        {
            result = 0;
        }
    }
}
