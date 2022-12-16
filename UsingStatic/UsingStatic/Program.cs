using System;
namespace UsingStatic
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;
        public static int salary =40000;
        public Employee(int i, string n, int age)
        {
            id = i;
            name = n;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("id :" + id + " name : " + name + " \n age : " + age + " salary: " + salary);

        }
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Shivani", 22);
            e1.display();
        }
    }
}