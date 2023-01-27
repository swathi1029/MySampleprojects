using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customerapi.Models
{
    public class CustomerViewModel
    {
        public int custId { get; set; }
        public string custName { get; set; }
        public int custAge { get; set; }
        public string custMobile { get; set; }
        public string custGender { get; set; }
        public string custCity { get; set; }
        public string custCountry { get; set; }
        public string custAddress { get; set; }
    }
}