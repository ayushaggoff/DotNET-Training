using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DetailsTask
{
    class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public int Insert()
        {
            int flag = 0;
            SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=TestDb;User ID=sa;Password=Successive");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tblPersonTask (Name,Gender,DateOfBirth,MaritalStatus,Address,State,Email,Mobile) values(@Name,@Gender,@Dob,@MaritalStatus,@Address,@State,@Email,@Mobile)", con);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Dob", Dob);
                cmd.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@State", State);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.ExecuteNonQuery();
                flag = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            finally
            {
                con.Close();
            }
            return flag;
        }

        public bool CheckTable(string choiceUpdate)
        {
            bool exists = false;
            SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=TestDb;User ID=sa;Password=Successive");
            try
            {
                con.Open();
                if (choiceUpdate == "mobile")
                {
                    SqlCommand cmd = new SqlCommand("select Email from tblPersonTask where Mobile=@mobile", con);
                    cmd.Parameters.AddWithValue("@mobile", Mobile);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        exists = true;
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select Mobile from tblPersonTask where Email=@Email", con);
                    cmd.Parameters.AddWithValue("@Email", Email);
                     SqlDataReader read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        exists = true;
                    }
                }
            }
            catch (Exception)
            {
                exists = false;
            }
            finally
            {
                con.Close();
            }
            return exists;
        }
        public int Update(string choice)
        {
            int flag = 0;
            SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=TestDb;User ID=sa;Password=Successive");
            try
            {
                con.Open();
                if (choice == "mobile")
                {
                    SqlCommand cmd = new SqlCommand("update tblPersonTask set Name=@Name,Gender=@Gender,DateOfBirth=@Dob,MaritalStatus=@MaritalStatus,Address=@Address,State=@State where Mobile=@Mobile", con);
                    cmd.Parameters.AddWithValue("@Mobile", Mobile);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Dob", Dob);
                    cmd.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@State", State);
                    cmd.ExecuteNonQuery();
                    flag = 1;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update tblPersonTask set Name=@Name,Gender=@Gender,DateOfBirth=@Dob,MaritalStatus=@MaritalStatus,Address=@Address,State=@State where Email=@Email", con);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Dob", Dob);
                    cmd.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@State", State);
                    cmd.ExecuteNonQuery();
                    flag = 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            finally
            {
                con.Close();
            }
            return flag;
        }
        public void View(string choiceUpdate)
        {
            SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=TestDb;User ID=sa;Password=Successive");
            try
            {
                con.Open();
                if (choiceUpdate == "mobile")
                {
                    SqlCommand cmd = new SqlCommand("select * from vwtblPersonTask_GetDetail where Mobile=@Mobile", con);
                    cmd.Parameters.AddWithValue("@Mobile", Mobile);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine("Name:" + row["Name"]);
                        Console.WriteLine("Date of birth:" + row["DateOfBirth"]);
                        Console.WriteLine("Gender:" + row["Gender"]);
                        Console.WriteLine("Email:" + row["Email"]);
                    }
                    dataReader.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from vwtblPersonTask_GetDetail where Email=@Email", con);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dataReader);
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine("Name:"+row["Name"]);
                        Console.WriteLine("Date of birth:" + row["DateOfBirth"]);
                        Console.WriteLine("Gender:" + row["Gender"]);
                        Console.WriteLine("Mobile:" + row["Molbile"]);
                    }
                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            finally
            {
                con.Close();
            }
           
        }

    }
}
