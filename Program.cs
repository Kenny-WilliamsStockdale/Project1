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

            //int a, b, c;
            //Console.WriteLine("Enter two numbers"); // Adds two numbers together 
            //a = int.Parse(Console.ReadLine());      //converting numbers to string
            //b = Convert.ToInt32(Console.ReadLine());
            //c = a + b;                                // plusing the a and b values together 
            //Console.WriteLine("The sum is = " + c);  // printing out the total sum 
            //Console.ReadKey();

            int EID, SALARY;
            string ENAME, ADDRESS, JOB;     // declaring variables 

            Console.WriteLine("Enter Emplyee Information"); // making a basic form. Taking input from the user and displaying as a list. 

            Console.WriteLine("Enter the Employee ID");
            EID = int.Parse(Console.ReadLine());        // Parsing number to string

            Console.WriteLine("Enter the Employee Name");
            ENAME = Console.ReadLine();                 // ReadLine requires data input or feedback on the console.

            Console.WriteLine("Enter the Employee Salary");
            SALARY = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee Address");
            ADDRESS = Console.ReadLine();

            Console.WriteLine("Enter the Employee Job Title");
            JOB = Console.ReadLine();

            Console.WriteLine("\n\n\nThe Employee Details: ");  // Not sure what the \n thing does. Is meant to be new line but don't see it working

            Console.WriteLine("Employee ID: " + EID);       // Printing out the list here by inserting users input 
            Console.WriteLine("Employee Name: " + ENAME);
            Console.WriteLine("Employee Salary: " + SALARY);
            Console.WriteLine("Employee Address: " + ADDRESS);
            Console.WriteLine("Employee Job: " + JOB);
            Console.ReadKey();

        }
    }
}

