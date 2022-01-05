using System;

namespace C_sharp_Tutorial___Full_Course_for_Beginners___Working_With_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
           
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
