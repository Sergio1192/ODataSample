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
            var list = new List<Student>
            {
                CreateNewStudent("Cody Allen", 130),
                CreateNewStudent("Todd Ostermeier", 160),
                CreateNewStudent("Chris Pandya", 140)
            };

            return Ok(list);
        }

        private static Student CreateNewStudent(string name, int score)
        {
            return new Student(name, score, "CEU");
        }
    }
}