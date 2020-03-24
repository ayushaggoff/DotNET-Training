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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }

        SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=EmployeeDB;User ID=sa;Password=Successive");
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
    }
}