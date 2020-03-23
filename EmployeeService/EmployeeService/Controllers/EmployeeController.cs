using System.Data;
using System.Web.Http;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeService.API.Db.Employee objEmployee = new EmployeeService.API.Db.Employee();

        public DataSet GetRecord(int id)
        {
            DataSet ds = objEmployee.GetRecordById(id);
            return ds;
        }
        public void InsertRecord(API.Db.Employee emp)
        {
            objEmployee.InsertRecord(emp);
        }
        public void PutSalaryRecord(API.Db.Employee emp)
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