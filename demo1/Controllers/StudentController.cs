using demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demo1.Controllers
{
    public class StudentController : ApiController
    {
        StudentInfo[] students = new StudentInfo[]
{
            new StudentInfo {Id = 1, Name = "ABC", Lop = "CDB K59",  NamSinh = "2000"},
            new StudentInfo {Id = 2, Name = "DEF", Lop = "KTDK59",  NamSinh = "2000"},
            new StudentInfo {Id = 3, Name = "GHI", Lop = "CNTT K59",  NamSinh = "2000"}
};
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            return students;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            if (id - 1 < students.Length)
            {
                return students.ElementAt(id - 1);
            }

            return new StudentInfo
            {
                Id = students.Length + 1,
                Name = "Invalid ID",
                Lop = "Error",
                NamSinh = "Error"
            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
