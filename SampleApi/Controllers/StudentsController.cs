using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApi.Model;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleApi.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IList<Students> Student = new List<Students>()
        {
            new Students()
                {
                    StudentId = 1, StudentName = "Mukesh Kumar", Address = "New Delhi", Course = "IT"
                },
                new Students()
                {
                    StudentId = 2, StudentName = "Banky Chamber", Address = "London", Course = "HR"
                },
                new Students()
                {
                    StudentId = 3, StudentName = "Rahul Rathor", Address = "Laxmi Nagar", Course = "IT"
                },
                new Students()
                {
                    StudentId = 4, StudentName = "YaduVeer Singh", Address = "Goa", Course = "Sales"
                },
                new Students()
                {
                    StudentId = 5, StudentName = "Manish Sharma", Address = "New Delhi", Course = "HR"
                },
        };

        public IList<Students> GetAllStudents()
        {
            //Return list of all employees    
            return Student;
        }
        public Students GetStudentDetails(int id)
        {
            //Return a single employee detail    
            var Students = Student.FirstOrDefault(e => e.StudentId == id);
            if (Students == null)
            {
                return Students; 
            }
            return Students;
        }
    }
}
