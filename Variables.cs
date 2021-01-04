using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string Myname = "Bakare Halimat";
            int Myage = 16;
            string Myfood ="Beans and plantain";
            Console.WriteLine("My name is " + Myname + " I am "+ Myage + " years old and my favourite food is " + Myfood + ".");
            string name = "";
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            int age = 0;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            string food ="";
            Console.Write("Enter your Favourite food: ");
            food = Console.ReadLine();
            Console.WriteLine("My name is " + name + " I am "+ age + " years old and my favourite food is " + food + "."); 
            int firstnumber = 0;
            int secondnumber = 0;
            int result = 0;
            Console.Write("Enter a number: ");
            firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            secondnumber = int.Parse(Console.ReadLine());
            result = firstnumber + secondnumber;
            Console.WriteLine("The result is " + result);
        }
    }
    
}