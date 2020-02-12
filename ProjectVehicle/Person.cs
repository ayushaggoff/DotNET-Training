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
        public static int DisplayDays(Dictionary<Months, int> dict, string monthName)
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
        }
        static void Main(string[] args)
        {
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
            }
            Console.ReadKey();
        }
    }



}
