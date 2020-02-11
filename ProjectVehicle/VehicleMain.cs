using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProblem
{
    class Problem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1 Remove the N number of Space");
            Console.Write("Enter the sentance:");
            string inputString = Console.ReadLine();
            inputString= inputString.Trim();
            int lengthOfInputString = inputString.Length;
            string words = "";
            string answer ="\"";
            int i = 0;
            int j;
            while (i < inputString.Length)
            {
                if (inputString[i] != 32)
                {
                    j = i;
                    while (inputString[j] != 32 && j < inputString.Length - 1)
                    {
                        words = words + inputString[j];
                        j = j + 1;
                    }
                    answer = answer + words + " ";
                    words = "";
                    i = j;
                }            
                i = i + 1;
            }
            answer = answer.Trim();
            answer = answer + "\"";
            int temp;
            Console.WriteLine();
            Console.Write("After removing extra spaces:"+answer);
            Console.ReadKey();
            Console.WriteLine("#2 show the sum of number in a String  ");
            Console.Write("Enter the sentance:");
            string inputString2 = Console.ReadLine();
            int sizeOfString = inputString2.Length;
            int sum = 0;
            for (int k = 0; k < sizeOfString ; k++)
            {
              if (inputString2[k] >= 48 && inputString2[k] < 58)
                {
                     temp = inputString2[k]-48;
                    sum = sum + temp;
                }
            }
            Console.WriteLine();
            Console.Write("Sum:" + sum);

            Console.ReadKey();
            Console.WriteLine("#3 show the string with sum of String length & length (of length of String) ");
            Console.Write("Enter the sentance:");
            string inputString1 = Console.ReadLine();
             sizeOfString = inputString1.Length;
            string tempSizeOfString = sizeOfString.ToString();
            int sumOfLength = sizeOfString + tempSizeOfString.Length;
            Console.WriteLine();
            Console.Write("Output:"+ inputString1+sumOfLength);
            Console.ReadKey();
        }
    }
}
