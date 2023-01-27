using APIWITHCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Net.Http;

namespace APIWITHCRUD.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: Employee
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public IHttpActionResult GetAllStudents()
        {
            IList<EmployeeViewModel> employees = null;

            using (var ctx = new EmployeeEntities())
            {
                employees = ctx.emps.Include("City")
                            .Select(s => new EmployeeViewModel()
                            {
                                EmpID = s.EmpID,
                                FirstName = s.FirstName,
                                LastName = s.LastName,
                                
                                
                               
                            }).ToList<EmployeeViewModel>();
            }

            if (employees.Count == 0)
            {
                return NotFound();
            }

            return Ok(employees);
        }
        public IHttpActionResult GetEmployeeById(int id)
        {
            EmployeeViewModel employee = null;

            using (var ctx = new EmployeeEntities())
            {
                employee = ctx.emps.Include("City")
                    .Where(s => s.EmpID == id)
                    .Select(s => new EmployeeViewModel()
                    {
                        EmpID = s.EmpID,
                        FirstName = s.FirstName,
                        LastName = s.LastName
                        
                    }).FirstOrDefault<EmployeeViewModel>();
            }

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
        public IHttpActionResult PostNewEmployee(EmployeeViewModel employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new EmployeeEntities())
            {
                ctx.emps.Add(new emp()
                {
                    EmpID = employee.EmpID,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    EMail = employee.Email,
                    Phone = employee.Phone,
                    DepartmentID = employee.DeptId,
                    ManagerID = employee.ManagerId,
                    HireDate = employee.Hiredate
            });

                ctx.SaveChanges();
            }

            return Ok();
        }
        public IHttpActionResult Put(EmployeeViewModel employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new EmployeeEntities())
            {
                var existingEmp = ctx.emps.Where(s => s.EmpID == employee.EmpID)
                                                        .FirstOrDefault<emp>();

                if (existingEmp != null)
                {
                    existingEmp.FirstName = employee.FirstName;
                    existingEmp.LastName = employee.LastName;
                    existingEmp.EMail = employee.Email;
                    existingEmp.Phone = employee.Phone;
                    existingEmp.DepartmentID = employee.DeptId;
                    existingEmp.ManagerID = employee.ManagerId;
                    existingEmp.LastName = employee.LastName;
                    existingEmp.HireDate = employee.Hiredate;


                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");

            using (var ctx = new EmployeeEntities())
            {
                var emp = ctx.emps
                    .Where(s => s.EmpID == id)
                    .FirstOrDefault();

                ctx.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}