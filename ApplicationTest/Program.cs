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

            int x1 = 0;

            int a = 10, b = 10;

            x1 = a + b;

            return x1;
        }


        public int method2()
        {

            int x2 = 0;

            int a = 10, b = 10, c = 10;

            x2 = a + b + c;

            return x2;
        }

        static void Main(string[] args)
        {

            Program x1 = new Program();

            Console.WriteLine("x1 = " + x1.method1());

            Program x2 = new Program();

            Console.WriteLine("x2 = " + x2.method2());


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
