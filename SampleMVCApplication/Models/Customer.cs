using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVCApplication.Models
{
    public class CustomerModel
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public int Age { get; set; }
        public int Mobile { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        
    }
}