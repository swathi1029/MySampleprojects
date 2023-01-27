using SampleMVCApplication.Models;
using SampleMVCApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVCApplication.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [HttpGet, ActionName("Search")]
        public ActionResult Search(string name)
        {
            CustomerrRepository CustRepo = new CustomerrRepository();
            ModelState.Clear();
            return View(CustRepo.GetAllCustomers().Find(cust => cust.CustName == name));
        }
        public ActionResult Search(string name, CustomerModel obj)
        {
            CustomerrRepository CustRepo = new CustomerrRepository();
            CustRepo.UpdateCustomer(obj);
            return RedirectToAction("GetAllCustDetails");
        }

        [HttpGet]
        public ActionResult GetAllCustDetails(string sortOrder)
        {
            CustomerrRepository CustRepo = new CustomerrRepository();
            ModelState.Clear();

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AgeSortParm = String.IsNullOrEmpty(sortOrder) ? "Age_desc" : "";
            ViewBag.CitySortParm = String.IsNullOrEmpty(sortOrder) ? "city_desc" : "";
            var students = from s in CustRepo.GetAllCustomers()
                           select s;
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.CustName);
                    break;
                case "Age_desc":
                    students = students.OrderByDescending(s => s.Age);
                    break;
                case "city_desc":
                    students = students.OrderByDescending(s => s.City);
                    break;
                default:
                    students = students.OrderBy(s => s.CustName);
                    break;
            }
            return View(students);
        }

       
      
        public ActionResult AddCustomer()
        {
            return View();
        }

        // POST: Customer/AddCustomer    
        [HttpPost]
        public ActionResult AddCustomer(CustomerModel cust)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CustomerrRepository CustRepo = new CustomerrRepository();

                    if (CustRepo.AddCustomer(cust))
                    {
                        ViewBag.Message = "Customer details added successfully";
                    }
                }

                return View();
            }
            catch (Exception ex)
            {
                return View();
                ViewBag.Message = ex;
            }
        }

        // GET: Customer/EditCustDetails/5    
        public ActionResult EditCustDetails(int id)
        {
            CustomerrRepository CustRepo = new CustomerrRepository();



            return View(CustRepo.GetAllCustomers().Find(cust => cust.CustId == id));

        }

        // POST: Customer/EditCustDetails/5    
        [HttpPost]

        public ActionResult EditCustDetails(int id, CustomerModel obj)
        {
            try
            {
                CustomerrRepository CustRepo = new CustomerrRepository();

                CustRepo.UpdateCustomer(obj);
                return RedirectToAction("GetAllCustDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/DeleteCust/5    
        public ActionResult DeleteCust(int id)
        {
            try
            {
                CustomerrRepository CustRepo = new CustomerrRepository();
                if (CustRepo.DeleteCustomer(id))
                {
                    ViewBag.AlertMsg = "Customer details deleted successfully";

                }
                return RedirectToAction("GetAllCustDetails");

            }
            catch
            {
                return View();
            }
        }
    }
}