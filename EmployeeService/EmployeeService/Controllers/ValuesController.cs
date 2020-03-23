using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeService.Controllers
{
    public class ValuesController : ApiController
    {
        EmployeeService.API.Db.Employee objEmployee = new EmployeeService.API.Db.Employee();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

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
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
