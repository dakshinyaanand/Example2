using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculatorlibrary;

namespace ExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(12, 13);
            c.sub(12, 12);
        }
    }
}
