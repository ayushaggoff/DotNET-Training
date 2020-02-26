using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    enum Weeks
    {
        Monday=12,
        Tuesday=15,
        Wedneday=33,
        Thrusday=100

    }
    class Person1
    {
        static void Main(string[] args)
        {
            foreach (string str in Enum.GetValues(typeof(Weeks)))
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
            /*string textPath = @"C:\Users\ayusha\Documents\test1";
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
            string textPath1 = @"C:\Users\ayusha\Documents\test2";
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
            string textPath2 = @"C:\Users\ayusha\Documents\test3.dat";
            FileInfo datFile = new FileInfo(textPath2);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string randText = "Random Text";
            int myAge = 00;
            double height = 172;
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();
            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();
            Console.ReadKey();
            */
        }
    }
}

