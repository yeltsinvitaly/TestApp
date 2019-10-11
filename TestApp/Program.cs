using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine(string.Format("2 + 3 = {0}", TestLib.MathOP.Add(2, 3)));
            Console.WriteLine("Stop");
            Console.ReadKey();
        }
    }
}
