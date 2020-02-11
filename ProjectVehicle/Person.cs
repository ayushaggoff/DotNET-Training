using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
    class Person
    {
        static public int NoOfDays()
        {
            int ans1=0;
            Console.WriteLine("Enter the month first free alphabets(eg. for march give input:Mar):");
            string month = Console.ReadLine();
            Dictionary<Months,int> days =new Dictionary<Months,int>();
            foreach (KeyValuePair<Months,int> item in days)
            {
                if (month == item.Key.ToString())
                {
                    return ans1 = item.Value;
                }
            }
            return ans1;
        }
        static void Main(string[] args)
        {
            Dictionary<Months,int> days = new Dictionary<Months, int>();
            days.Add(Months.Jan,31);
            days.Add(Months.Feb,29);
            days.Add(Months.Mar,31);
            days.Add(Months.Apr, 30);
            days.Add(Months.May, 31);
            days.Add(Months.Jun, 30);
            days.Add(Months.Jul, 31);
            days.Add(Months.Aug, 31);
            days.Add(Months.Sep, 30);
            days.Add(Months.Oct, 31);
            days.Add(Months.Nov, 30);
            days.Add(Months.Dec, 31);

            int ans = NoOfDays();
                Console.WriteLine("No Of Days:"+ans);
            Console.ReadKey();
        }
}



}
