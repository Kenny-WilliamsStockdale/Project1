using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string name = "Kenny";    Making a variable to print out in the console. 
            *//*Console.WriteLine(name);*//*
            //Console.WriteLine("Hello World!");
            Console.Write("HELLO");
            Console.Write(" WELCOME " + name);  Calling string name here
            Console.ReadKey();*/

            //Console.WriteLine("Enter your name");  
            //string name = Console.ReadLine();   /*making a string variable to have input in the console*/
            //Console.Write(" WELCOME " + name);
            //Console.ReadKey();

            int a, b, c;
            Console.WriteLine("Enter two numbers"); // Adds two numbers together 
            a = int.Parse(Console.ReadLine());      //converting numbers to string
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;                                // plusing the a and b values together 
            Console.WriteLine("The sum is = " + c);  // printing out the total sum 
            Console.ReadKey();
        }
    }
}

