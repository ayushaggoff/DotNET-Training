using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DetailsTask
{
    class Program:Directory
    {   
               
        static void Main(string[] args)
        {
            List<Directory> phone = new List<Directory>()
            {
            };
            string choice = "";
            while (choice != "exit")
            { 
                Console.WriteLine("");
                Console.WriteLine("Directory");
                Console.WriteLine("Insert data");
                Console.WriteLine("View Directory");
                Console.WriteLine("Exit");
                Console.Write("Enter your choice Insert or view");
                choice=Console.ReadLine();
                choice = choice.ToLower();
                Directory objDirectory = new Directory();
                switch (choice)
                {
                    case "insert":
                        //
                        int i = 0;
                        int j = 0
                        phonenumber:
                        Console.Write("Please enter the phonenumber:");
                        Int64 number;
                        bool check = Int64.TryParse(Console.ReadLine(), out number);
                        if (!check)
                        {
                            Console.WriteLine("please Enter number in numeric form");
                            goto phonenumber;
                        }
                        Console.WriteLine();
                        Console.Write("Enter Name:");
                        string naam = Console.ReadLine();
                        //string s;
                        var z = (from x in phone where x.Name.Contains(naam) select x.Name).ToList();
                        int y = z.Count();
                        if (y > 0)
                        {
                            naam = naam + "_" + Convert.ToString(y);

                        }
                        phone.Add(new Directory() { Mobile = number, Name = naam });
                        Console.WriteLine("Your record is Added");
                        break;
                    case "view":
                        phone.OrderBy(x => x.Mobile);

                        foreach (var na in phone)
                        {
                            Console.WriteLine(na.Name);
                        }
                        break;
                }
            }
            Console.ReadKey();
                // Linkq objLinkq = new Linkq();
            //objLinkq.PracLinq();

            //int flag = 0;
            //Create Table tblPersonTask
            //SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=TestDb;User ID=sa;Password=Successive");
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("CREATE TABLE tblPersonTask(Name varchar(150),Gender varchar(150),DateOfBirth datetime,MaritalStatus varchar(150),Address varchar(150),State varchar(150),Email varchar(150) unique,Mobile varchar(20) primary key);", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //    Console.ReadKey();
            //}
            //finally
            //{
            //    con.Close();
            //}



            //Insert data
            //Person objPerson = new Person();
            //Console.WriteLine("Registration");
            //Console.WriteLine("Enter the following the details");
            //Console.Write("Name: ");
            //objPerson.Name = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Gender: ");
            //objPerson.Gender = Console.ReadLine();
            //Console.WriteLine();
            //Date:
            //Console.Write("Date Of Birth: ");
            //string line = Console.ReadLine();
            //Console.WriteLine();
            //DateTime dt;
            //while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            //{
            //    Console.WriteLine("Invalid date, please retry");

            //    goto Date;
            //}
            //objPerson.Dob = dt;
            //Console.Write("Marital Status: ");
            //objPerson.MaritalStatus = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Address: ");
            //objPerson.Address = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("State: ");
            //objPerson.State = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Email ID: ");
            //objPerson.Email = Console.ReadLine();
            //Console.WriteLine();
            //Mobile:
            //Console.Write("Mobile No.: ");
            //objPerson.Mobile = Console.ReadLine();
            //Console.WriteLine();
            //string temp = objPerson.Mobile;
            //if (temp.Length != 10)
            //{
            //    Console.WriteLine("Provide the correct input");
            //    goto Mobile;
            //}
            //flag = objPerson.Insert();
            //if (flag == 1)
            //{
            //    Console.WriteLine("Data Inserted");
            //}
            //else
            //{
            //    Console.WriteLine("Data is NOT Inserted");
            //}


            //Update Details
            //Person objPerson = new Person();
            //Console.WriteLine("Update Details");
            //string choice = null;
            //EnterChoice:
            //Console.Write("Do you want to enter email or mobile:");
            //string choiceUpdate = Console.ReadLine();
            //Console.WriteLine();
            //choiceUpdate = choiceUpdate.ToLower();

            //if (choiceUpdate == "mobile" || choiceUpdate == "email")
            //{

            //    if (choiceUpdate == "mobile")
            //    {
            //        //CheckMobile:
            //        Console.WriteLine("Enter the mobile number:");
            //        objPerson.Mobile = Console.ReadLine();
            //        bool checktbl = objPerson.CheckTable(choiceUpdate);
            //        if (checktbl == false)
            //        {
            //            Console.WriteLine("!! Data do NOT exists");
            //            // goto CheckMobile;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Enter the following the details");
            //            Console.Write("Name: ");
            //            objPerson.Name = Console.ReadLine();
            //            Console.WriteLine();
            //            Console.Write("Gender: ");
            //            objPerson.Gender = Console.ReadLine();
            //            Console.WriteLine();
            //            Date:
            //            Console.Write("Date Of Birth: ");
            //            string line = Console.ReadLine();
            //            Console.WriteLine();
            //            DateTime dt;
            //            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            //            {
            //                Console.WriteLine("Invalid date, please retry");
            //                goto Date;
            //            }
            //            objPerson.Dob = dt;
            //            Console.Write("Marital Status: ");
            //            objPerson.MaritalStatus = Console.ReadLine();
            //            Console.WriteLine();
            //            Console.Write("Address: ");
            //            objPerson.Address = Console.ReadLine();
            //            Console.WriteLine();
            //            Console.Write("State: ");
            //            objPerson.State = Console.ReadLine();
            //            Console.WriteLine();
            //            flag = objPerson.Update(choiceUpdate);
            //            if (flag == 1)
            //            {
            //                Console.WriteLine("Data Is Updated");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Data is NOT Updated");
            //            }

            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter the Email ID:");
            //        objPerson.Email = Console.ReadLine();
            //        bool checktbl = objPerson.CheckTable(choiceUpdate);
            //        if (checktbl == false)
            //        {
            //            Console.WriteLine("!! Data do NOT exists");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Enter the following the details");
            //            Console.Write("Name: ");
            //            objPerson.Name = Console.ReadLine();
            //            Console.WriteLine();
            //            Console.Write("Gender: ");
            //            objPerson.Gender = Console.ReadLine();
            //            Console.WriteLine();
            //            Date:
            //            Console.Write("Date Of Birth: ");
            //            string line = Console.ReadLine();
            //            Console.WriteLine();
            //            DateTime dt;
            //            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            //            {
            //                Console.WriteLine("Invalid date, please retry");
            //                goto Date;
            //            }
            //            objPerson.Dob = dt;
            //            Console.Write("Marital Status: ");
            //            objPerson.MaritalStatus = Console.ReadLine();
            //            Console.WriteLine();
            //            Console.Write("Address: ");
            //            objPerson.Address = Console.ReadLine();
            //            Console.WriteLine();
            //            Console.Write("State: ");
            //            objPerson.State = Console.ReadLine();
            //            Console.WriteLine();
            //            flag = objPerson.Update(choiceUpdate);
            //            if (flag == 1)
            //            {
            //                Console.WriteLine("Data Is Updated");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Data is NOT Updated");
            //            }

            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("!! Provide the correct input");
            //    goto EnterChoice;
            //}



            //View data
            //person objperson = new person();
            //console.writeline("view data");
            //enterchoice:
            //console.write("do you want to enter email or mobile:");
            //string choiceupdate = console.readline();
            //console.writeline();
            //choiceupdate = choiceupdate.tolower();

            //if (choiceupdate == "mobile" || choiceupdate == "email")
            //{

            //    if (choiceupdate == "mobile")
            //    {
            //        console.writeline("enter mobile number:");
            //        objperson.mobile = console.readline();
            //        bool checktbl = objperson.checktable(choiceupdate);
            //        if (checktbl == false)
            //        {
            //            console.writeline("!! data do not exists");
            //        }
            //        else
            //        {
            //            objperson.view(choiceupdate);
            //        }
            //    }
            //    else
            //    {
            //        console.writeline("enter email id:");
            //        objperson.email = console.readline();
            //        bool checktbl = objperson.checktable(choiceupdate);
            //        if (checktbl == false)
            //        {
            //            console.writeline("!! data do not exists");
            //        }
            //        else
            //        {
            //            objperson.view(choiceupdate);
            //        }
            //    }
            //}
            //else
            //{
            //    console.writeline("!! provide the correct input");
            //    goto enterchoice;
            //}
            Console.ReadKey();
        }
    }
}
