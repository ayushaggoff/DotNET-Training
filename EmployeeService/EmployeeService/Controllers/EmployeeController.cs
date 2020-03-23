using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{           
        public class EmployeeController : ApiController
        {
        EmployeeService.API.Db.Employee objEmployee = new EmployeeService.API.Db.Employee();
        public void InsertRecord(API.Db.Employee emp)
        {
            objEmployee.InsertRecord(emp);
        }
        public void SalaryRecord(API.Db.Employee emp)
        {
            objEmployee.UdateSalaryById(emp);
        }
        public void DeleteRecord(int id)
        {
            objEmployee.DeleteRecordById(id);
        }
        // GET: Employee

    }
}