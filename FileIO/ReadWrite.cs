using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class ReadWrite
    {
        public void Writefile(string fname)
        {
            StreamWriter write = new StreamWriter(fname,true);
            try
            {
                Console.WriteLine("enter data to be written on file");
                string data = Console.ReadLine();
                write.WriteLine(data);
                Console.WriteLine("Data written.....");
            } catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                write.Close();
            }
        }
        //write
        public void Readfile(string fname)
        {
            StreamReader read = new StreamReader(fname,true);
            try
            {

                string data = read.ReadToEnd();
                Console.WriteLine("Data read from file");
                Console.WriteLine(data);
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                read.Close();
            }

        }
    }
}
