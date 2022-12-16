using System;
namespace UsingStaticClass
{
    public static class MyMath
    {
        public static float Pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
        public static int square(int l,int b)
        {
            return l * b;
        }
       
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cube of 5 is : " + MyMath.cube(5));
            Console.WriteLine("Square of l*b is :" +MyMath.square(3,5));
        }
    }

}
