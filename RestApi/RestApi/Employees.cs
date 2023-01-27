using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace RestApi
{
    class Employees
    {

        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [JsonPropertyName("Hiredate")]
        public string HireDate { get; set; }

        [JsonPropertyName("Managerid")]
        public string ManagerID { get; set; }
        [JsonPropertyName("salary")]
        public string Salary { get; set; }
        [JsonPropertyName("departmentid")]
        public string DepartmentID { get; set; }
    }
}
