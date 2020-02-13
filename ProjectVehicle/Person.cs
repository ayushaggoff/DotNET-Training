using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    enum Months
    {
        january,
        february,
        march,
        april,
        may,
        june,
        july,
        august,
        september,
        october,
        november,
        december
    }
    class Person
    {
        /*public static int DisplayDays(Dictionary<Months, int> dict, string monthName)
        {
            int noOfDays = 0;
            foreach (KeyValuePair<Months, int> ele1 in dict)
            {
                if (ele1.Key.ToString() == monthName)
                {
                    return ele1.Value;
                }
            }
            return noOfDays;
        }*/
        static int Division(int x, int y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling:try catch implementation");
            Console.Write("Enter an operator (+, -, *,/): ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter two operands: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case "+":
                    int result = Add(first, second);
                    Console.WriteLine(first + "+" + second + ": " + result);
                    break;
                case "-":
                    result = Sub(first, second);
                    Console.WriteLine(first + "-" + second + ": " + result);
                    break;
                case "*":
                    result = Multiply(first, second);
                    Console.WriteLine(first + "*" + second + ": " + result);
                    break;
                case "/":
                    try
                    {
                        result = Division(first, second);
                        Console.WriteLine(first + "/" + second + ": " + result);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Attempted divide by zero.");
                    }
                    break;
                // operator doesn't match any case constant
                default:
                    Console.WriteLine("Error! operator is not correct");
                    break;
            }
            /*
            int noOfDays = 0;
            Dictionary<Months, int> months = new Dictionary<Months, int>();
            months.Add(Months.january, 31);
            months.Add(Months.february, 28);
            months.Add(Months.march, 31);
            months.Add(Months.april, 30);
            months.Add(Months.may, 31);
            months.Add(Months.june, 30);
            months.Add(Months.july, 31);
            months.Add(Months.august, 31);
            months.Add(Months.september, 30);
            months.Add(Months.october, 31);
            months.Add(Months.november, 30);
            months.Add(Months.december, 31);
            Console.WriteLine("To Find Number of Days:");
            Console.Write("Enter Any Month :  ");
            string readMonth = Console.ReadLine();
            readMonth = readMonth.ToLower();
            noOfDays = DisplayDays(months, readMonth);
            Console.WriteLine();
            if (noOfDays == 0)
            {
                Console.WriteLine("!Enter the correct Month");
            }
            else
            {
                Console.WriteLine("Number of Days:" + noOfDays);
            }*/
            Console.ReadKey();

        }
    }
}

