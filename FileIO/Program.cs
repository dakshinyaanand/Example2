using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite rd = new ReadWrite();
            rd.Writefile(@"c:\files\Test.txt");
            rd.Readfile(@"c:\files\Test.txt");

        }
    }
}
