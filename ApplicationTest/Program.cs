using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testprog
{
    class Program
    {

        public int method1()
        {

            int x1;

            int a = 10, b = 10;

            x1 = a + b;

            return x1;
        }




        static void Main(string[] args)
        {

            Program x1 = new Program();

            Console.WriteLine("x1 = " + x1.method1());

         
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
