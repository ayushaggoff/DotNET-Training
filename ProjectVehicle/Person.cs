using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Person
    {
        static void Main(string[] args)
        {
            string textPath = @"C:\Users\try\Documents\test1";
            FileStream fs = File.Open(textPath,FileMode.Create);
            string randString = "This is a ramdom string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);
            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;
            byte[] fileByteArray = new byte[rsByteArray.Length];
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();
            string textPath1 = @"C:\Users\try\Documents\test2";
            StreamWriter sw = File.CreateText(textPath1);
            sw.Write("THis a random text 2 ");
            sw.WriteLine("Sentence 1");
            sw.WriteLine("Sentence 2");
            sw.Close();
            StreamReader sr = File.OpenText(textPath1);
            Console.WriteLine("Peek:{0}", Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st String:{0}", sr.ReadLine());
            Console.WriteLine("Everything:{0}", sr.ReadToEnd());
            sr.Close();
            Console.ReadKey();
        }
    }
}

