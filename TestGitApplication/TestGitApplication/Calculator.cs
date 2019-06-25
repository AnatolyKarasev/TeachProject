using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApplication
{
    interface ICalculator
    {        
        int Sum(int a, int b);
	int Multiply(int a, int b);
    }

    class Calculator : ICalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a*b;
        }
    }
}
