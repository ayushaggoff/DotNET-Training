using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

  
namespace EmployeeService.API.Db
{
    public class Employee
    {
        /*
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        */

        public string Name { get; set; }
        public string Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string JoiningDate { get; set; }

        SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=EmployeeDB;User ID=sa;Password=Successive");

        public void InsertRecord(Employee emp)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee (name,dob,phone,email,department,address,state,city,joiningdate) values(@name,@dob,@phone,@email,@department,@address,@state,@city,@joiningdate)", con);
                cmd.Parameters.AddWithValue("@name", emp.Name); 
                cmd.Parameters.AddWithValue("@dob", emp.Dob); 
                cmd.Parameters.AddWithValue("@phone", emp.Phone); 
                cmd.Parameters.AddWithValue("@email", emp.Email); 
                cmd.Parameters.AddWithValue("@department", emp.Department); 
                cmd.Parameters.AddWithValue("@address", emp.Address); 
                cmd.Parameters.AddWithValue("@state", emp.State); 
                cmd.Parameters.AddWithValue("@city", emp.City); 
                cmd.Parameters.AddWithValue("@joiningdate", emp.JoiningDate);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        /*
        public DataSet GetRecordById(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employees where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet GetAllRecord()
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employees", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public void DeleteRecordById(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Employees where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertRecord(Employee emp)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees (FirstName,LastName,Gender,Salary) values(@FirstName,@LastName,@Gender,@Salary)", con);
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void UdateSalaryById(int id, Employee emp)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Employees set Salary=@Salary where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        */
    }
}