using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpActionResult.Controllers
{
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() {Id=1, Name="Tony"},
            new Student() {Id=2, Name="Sam"},
            new Student() {Id=3, Name="John"}
        };


        public IHttpActionResult Get()
        {
            
          return  Ok(students);
        }
        public IHttpActionResult Get(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            if(student == null)
            {
                return Content(HttpStatusCode.NotFound,"Student Not Found");
            }
            return Ok(student);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
