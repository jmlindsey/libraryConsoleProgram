using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    class Helper
    {
        private Helper() { }

        public static String Prompt(String info)
        {
            Console.WriteLine("\nEnter {0}", info);
            return Console.ReadLine();
        }
    }
}
