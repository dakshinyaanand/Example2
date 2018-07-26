using Calculatorlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample
{
    static class ExtensionMutiply
    {
       public static int mul(this Calculator c,int x,int y)
        {
            return x * y;
        }
    }
}
