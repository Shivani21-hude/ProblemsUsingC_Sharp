using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    public class Demo
    {
     /*   public void Show() // No Parameter  
        {
            Console.WriteLine("This is non parameterized function");
            // No return statement  
        }
        public void Printmessage(string msg)
        {
            Console.WriteLine("hello " + msg);
        }*/
        public int ReturnMethod()
        {
            int a = 12;
            int b = 13;
            int c = a + b;
            return c;
        }
     /*public void StaticMethod()
        {
            int a = 12;
            int b = 13;
            int c = a + b;
            Console.WriteLine(c);
        }*/
    }
}
