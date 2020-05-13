using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisterBL;
using RegisterCL;

namespace EmployeeManagement.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private InterfaceRegisterBL data;
               public EmployeeController(InterfaceRegisterBL data)
                {
                    this.data = data;
                }


               // POST api/<controller>
               [HttpPost]
                public IActionResult Return_data(register info)
                {
                    string orignal = data.Return_data(info);
                    return Ok(new { orignal });
                }
    }
}