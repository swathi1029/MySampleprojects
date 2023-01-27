using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{

   public class StudentController : ApiController
    {

        IList<Student> Student = new List<Student>()
        {
            new Student()
                {
                    StudentId = 1, StudentName = "Mukesh Kumar", Address = "New Delhi", Course = "IT"
                },
                new Student()
                {
                    StudentId = 2, StudentName = "Banky Chamber", Address = "London", Course = "HR"
                },
                new Student()
                {
                    StudentId = 3, StudentName = "Rahul Rathor", Address = "Laxmi Nagar", Course = "IT"
                },
                new Student()
                {
                    StudentId = 4, StudentName = "YaduVeer Singh", Address = "Goa", Course = "Sales"
                },
                new Student()
                {
                    StudentId = 5, StudentName = "Manish Sharma", Address = "New Delhi", Course = "HR"
                },
        };

        public IList<Student> GetAllStudents()
        {
            //Return list of all employees    
            return Student;
        }
        public Student GetStudentDetails(int id)
        {
            //Return a single employee detail    
            var Students = Student.FirstOrDefault(e => e.StudentId == id);
            if (Students == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return Students;
        }
    }
}
