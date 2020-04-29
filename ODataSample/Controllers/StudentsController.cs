using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using ODataSample.Models;
using System;
using System.Collections.Generic;

namespace ODataSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [IncludeCount]
        public ActionResult<ResponseModel<Student>> Get([FromQuery] Filter myFilter, ODataQueryOptions<Student> filter)
        {
            var list = new List<Student>
            {
                new Student("Cody Allen", 130, "CEU"),
                new Student("Todd Ostermeier", 160, "CEU"),
                new Student("Chris Pandya", 140, "CEU"),
                new Student("Sergio Merino", 200, "San Jaime"),
                new Student("David Merino", 190, "San Jaime"),
            };

            var response = filter.ApplyTo(list);

            return Ok(response);
        }
    }
}
