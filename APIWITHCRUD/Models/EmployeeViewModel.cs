using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIWITHCRUD.Models
{
    public class EmployeeViewModel
    {
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Hiredate { get; set; }
        public int ManagerId { get; set; }
        public int Salary { get; set; }
        public int DeptId { get; set; }
        
        public CityViewModel City { get; set; }
        public CountryViewModel Country { get; set; }
    }
    public class CityViewModel
    {
        public int CityId { get; set; }
        public int CityName { get; set; }
        public int StateId { get; set; }
        public int CoutryId { get; set; }
    }

    public class CountryViewModel
    {
        public int CountryId { get; set; }
        public int CountryName { get; set; }
    }
}