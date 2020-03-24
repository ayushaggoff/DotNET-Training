using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using EmployeeService.API.Db;

namespace EmployeeService.Controllers
{
    public class EmployeeController : ApiController
    {
        Employee objEmployee = new Employee();
        [CheckRecord]
        public DataSet GetRecord(int id)
        {
            DataSet ds = objEmployee.GetRecordById(id);
            return ds;
        }
        public DataSet GetAllRecord()
        {
            DataSet ds = objEmployee.GetAllRecord();
            return ds;
        }
        public void InsertRecord(Employee emp)
        {
            objEmployee.InsertRecord(emp);
        }
        [System.Web.Http.HttpPut]
        public void UpdateSalary(int id, Employee emp)
        {
            objEmployee.UdateSalaryById(id, emp);
        }
        public void DeleteRecord(int id)
        {
            objEmployee.DeleteRecordById(id);
        }
    }
}