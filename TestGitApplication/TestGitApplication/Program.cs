using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            
            Console.WriteLine(calculator.Sum(1, 2));
        }
    }
}
