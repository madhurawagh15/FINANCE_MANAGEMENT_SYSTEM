using FINANCE_MANAGEMENT_SYSTEM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINANCE_MANAGEMENT_SYSTEM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        public FINANCE_MANAGEMENT_SYSTEMContext db;
        public FinanceController(FINANCE_MANAGEMENT_SYSTEMContext db1)
        {
            db = db1;
        }
        public IActionResult Get()
        {
            return Ok(db.RegistrationU);
        }
        

        [HttpPost]
        public IActionResult Register(RegistrationU user)
        {
            var u = db.RegistrationU.Where(t => t.Email == user.Email).FirstOrDefault();
            if (u == null)
            {
                db.RegistrationU.Add(user);
                db.SaveChanges();
                return Ok(user);
            }
            else
                return BadRequest("Email already exists");

        }
        [HttpPost("UserLogin")]
        public IActionResult Login(LoginA user)
        {
            var u = db.LoginA.Where(t => t.Username == user.Username && t.Password == user.Password).FirstOrDefault();
            if (u != null)
            {
                return Ok();
            }
            else
                return Unauthorized();

        }


    
}
}
