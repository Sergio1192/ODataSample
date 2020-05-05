using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ODataSample.Models;

namespace ODataSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students2Controller : ODataController
    {
        // GET api/values
        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            var list = Student.GetStudents();

            return Ok(list);
        }
    }
}