using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double d = 729.24;
           int i = (int)d;
            Console.WriteLine("Value of i is" + i);
            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(d.ToString());
            String author = "John";
            String book = "C#";
            String bookauthor = $"{author} is the author of book {book}";
            Console.WriteLine(bookauthor);
            Console.WriteLine("a=");
            Console.WriteLine(d);
        }
    }
}