using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(args.Transliterator()); //input from command line
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            };
        }
    }
}
