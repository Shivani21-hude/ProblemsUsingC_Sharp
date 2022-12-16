using System;
namespace InheritanceExample
{
    public class Books
    {
        public void book1()
        {
            Console.WriteLine("DataStucture book");
        }
    }
    public class Book1 : Books
    {
        public void book2()
        {
            Console.WriteLine("OOps Conscepts book");
        }
    }
    class TestBooks
    {
        public static void Main(string[] args)
        {
            Book1 b1 = new Book1();
            b1.book1();
            b1.book2();
        }
    }
}