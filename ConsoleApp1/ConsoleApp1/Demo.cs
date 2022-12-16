using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo
    {
        public static void StaticMethod()
        {
            int a = 12;
            int b = 13;
            int c = a + b;
            Console.WriteLine(c);
        }
        public static int ReturnMethod()
        {
            int a = 12;
            int b= 13;
            int c= a + b;
            return c;
        }
    }
}
