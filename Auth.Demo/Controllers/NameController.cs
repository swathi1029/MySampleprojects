using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Auth.Demo.Controllers
{
    
    [Route("[controller]/[action]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly ICustomAuthenticationManager customAuthenticationManager;

        public NameController(ICustomAuthenticationManager customAuthenticationManager)
        {
            this.customAuthenticationManager = customAuthenticationManager;
        }
        //private readonly IJWTAuthenticationManager jWTAuthenticationManager;

        //public NameController(IJWTAuthenticationManager jWTAuthenticationManager)
        //{
        //    this.jWTAuthenticationManager = jWTAuthenticationManager;
        //}
        // GET: api/<NameController>
        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NameController>/5
        [HttpGet("{id}")]
        
        public string Get(int id)
        {
            return "value";
        }

        
        public class UserCred
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        [HttpPost]
        [AllowAnonymous]        
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            var token = customAuthenticationManager.Authenticate(userCred.Username, userCred.Password);

            if (token == null)
                return Unauthorized();

            return Ok(token);
        }
    }
}
