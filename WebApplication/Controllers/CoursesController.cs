using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoursesController: ControllerBase
    {
        public CoursesController(JsonFileCourseService courseservice)
        {
            this.CourseService = courseservice;
        }
        public JsonFileCourseService CourseService { get; }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return CourseService.GetCourses();
        }
    }
}
