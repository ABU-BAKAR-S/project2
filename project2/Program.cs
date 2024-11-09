//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("What is your name?");
//var name = Console.ReadLine();
//var currentDate = DateTime.Now;
//Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
//Console.Write($"{Environment.NewLine}Press any key to exit...");
//Console.ReadKey(true);


/*
using System;

class Program
{
    static void Summation(int x, int y)
    {
        Console.WriteLine(x + y);
    }

    static void Substraction(int x, int y)
    {
        Console.WriteLine(x - y);
    }

    static void Multiplication(int x, int y)
    {
        Console.WriteLine(x * y);
    }

    static void Division(float x, float y)
    {
        Console.WriteLine(x / y);
    }

    static void Modulus(int x, int y)
    {
        Console.WriteLine(x % y);
    }
    static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Enter Two Numbers  ; ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine("Step To Action : ");
        Console.WriteLine("1.Summation");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("5.Modulus");

        Console.Write("Select Action: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input == 1) {
            Console.WriteLine("Summation of two numbers ");
            Summation(x, y);
        }
       else if (input == 2)
        {
            Console.WriteLine("Subtraction of two numbers ");
            Substraction(x, y);
        }
        else if (input == 3)
        {
            Console.WriteLine("Subtraction of two numbers ");
            Multiplication(x, y);
        }
        else if (input == 4)
        {
            Console.WriteLine("Subtraction of two numbers ");
            Division(x, y);
        }
        else if (input == 5)
        {
            Console.WriteLine("Subtraction of two numbers ");
            Modulus(x, y);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
*/

using System;

class Program
{
    static void Summation(int x, int y)
    {
        Console.WriteLine(x + y);
    }

    static void Subtraction(int x, int y)
    {
        Console.WriteLine(x - y);
    }

    static void Multiplication(int x, int y)
    {
        Console.WriteLine(x * y);
    }

    static void Division(float x, float y)
    {
        Console.WriteLine(x / y);
    }

    static void Modulus(int x, int y)
    {
        Console.WriteLine(x % y);
    }

    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            int x, y;
            Console.WriteLine("Enter Two Numbers  : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Step To Action : ");
            Console.WriteLine("1.Summation");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Modulus");

            Console.Write("Select Action: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Summation of two numbers ");
                Summation(x, y);
            }
            else if (input == 2)
            {
                Console.WriteLine("Subtraction of two numbers ");
                Subtraction(x, y);
            }
            else if (input == 3)
            {
                Console.WriteLine("Subtraction of two numbers ");
                Multiplication(x, y);
            }
            else if (input == 4)
            {
                Console.WriteLine("Subtraction of two numbers ");
                Division(x, y);
            }
            else if (input == 5)
            {
                Console.WriteLine("Subtraction of two numbers ");
                Modulus(x, y);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }


            Console.Write("Do you want to take another action? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                repeat = false;
            }
        }
    }
}
