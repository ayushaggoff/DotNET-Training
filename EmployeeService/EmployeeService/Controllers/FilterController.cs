using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using EmployeeService.API.Db;

namespace EmployeeService.Controllers
{
    public class CheckRecord : ActionFilterAttribute
    {
        Employee objEmployee = new Employee();

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            bool exists = false;
            SqlConnection con = new SqlConnection("data source=LAPR258\\SQLEXPRESS;integrated security=false;Initial Catalog=TestDb;User ID=sa;Password=Successive");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select ID from Employees  where ID=@id", con);
                cmd.Parameters.AddWithValue("@id", objEmployee.Id);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    exists = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            if (exists)
                HttpContext.Current.Response.Write("Record is Present");
            else
                HttpContext.Current.Response.Write("Record is NOT Present");
        }
        public class FilterController : ApiController
        {
            EmployeeService.API.Db.Employee objEmployee = new EmployeeService.API.Db.Employee();
            [Route("api/Employees")]
            [CheckRecord]
            public DataSet GetRecord(int id)
            {
                DataSet ds = objEmployee.GetRecordById(id);
                return ds;
            }
        }
    }
}
