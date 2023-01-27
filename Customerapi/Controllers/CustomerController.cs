using Customerapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Customerapi.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet, ActionName("GetCustomers")]
        
        public IHttpActionResult GetCustomers(EmployeeEntities3 emp)
        {
            IList<CustomerViewModel> customer = null;
            using (var ctx = new EmployeeEntities3())
            {
                customer = ctx.emps.Select(s => new CustomerViewModel()
                {
                    custId = s.CustId,
                    custName = s.CustName,
                    custAge = s.Age,
                    custCity = s.City,
                    custCountry = s.Country,
                    custGender = s.custGender,
                    custMobile = s.Mobile

                }).ToList<CustomerViewModel>();
            }
            if(emp.emps.Count() != 0)
            {
                return Ok(emp);
            }
            return NotFound();

        }
    }
}
