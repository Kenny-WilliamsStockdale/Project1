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

            //int EID, SALARY;
            //string ENAME, ADDRESS, JOB;     // declaring variables 

            //Console.WriteLine("Enter Emplyee Information"); // making a basic form. Taking input from the user and displaying as a list. 

            //Console.WriteLine("Enter the Employee ID");
            //EID = int.Parse(Console.ReadLine());        // Parsing number to string

            //Console.WriteLine("Enter the Employee Name");
            //ENAME = Console.ReadLine();                 // ReadLine requires data input or feedback on the console.

            //Console.WriteLine("Enter the Employee Salary");
            //SALARY = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Employee Address");
            //ADDRESS = Console.ReadLine();

            //Console.WriteLine("Enter the Employee Job Title");
            //JOB = Console.ReadLine();

            //Console.WriteLine("\n\n\nThe Employee Details: ");  // Not sure what the \n thing does. Is meant to be new line but don't see it working

            //Console.WriteLine("Employee ID: " + EID);       // Printing out the list here by inserting users input 
            //Console.WriteLine("Employee Name: " + ENAME);
            //Console.WriteLine("Employee Salary: " + SALARY);
            //Console.WriteLine("Employee Address: " + ADDRESS);
            //Console.WriteLine("Employee Job: " + JOB);
            //Console.ReadKey();

            //int SNO, SDV503, COM502, CSA501, DES501;
            //string SNAME;                                   // Created another input form 

            //Console.WriteLine("Enter the student name");
            //SNAME = Console.ReadLine();

            //Console.WriteLine("Enter student number");
            //SNO = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter student's Mark for SDV503");
            //SDV503 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter student's Mark for COM502");
            //COM502 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter student's Mark for CSA501");
            //CSA501 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter student's Mark for DES501");
            //DES501 = int.Parse(Console.ReadLine());

            //int Average = (SDV503 + COM502 + CSA501 + DES501) / 4;      // made a number variable calculating the average of all student marks

            //Console.WriteLine("\n\n\nThe Employee Details: ");  

            //Console.WriteLine("Student Number: " + SNO);        
            //Console.WriteLine("Student Name: " + SNAME);
            //Console.WriteLine("SDV503 Mark: " + SDV503);
            //Console.WriteLine("COM502 Mark: " + COM502);
            //Console.WriteLine("CSA501 Mark: " + CSA501);
            //Console.WriteLine("DES501 Mark: " + DES501);
            //Console.WriteLine("SDV503 Mark: " + SDV503);
            //Console.WriteLine("Student's Average Mark: " + Average);
            //Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Blue;    // changing the background and foreground colours in the console.
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Welcome to C Sharp";           // Changes title on the console 

            Console.WriteLine("Background color is blue");
            Console.WriteLine("Foreground color is white");
            Console.WriteLine("Welcome to C Sharp");
            Console.ReadKey();
        }
    }
}

