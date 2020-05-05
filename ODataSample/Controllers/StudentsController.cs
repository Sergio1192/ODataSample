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
            var list = Student.GetStudents();

            var response = filter.ApplyTo(list);

            return Ok(response);
        }
    }
}
