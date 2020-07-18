using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        public JsonFileCourseService CourseService;
        public IEnumerable<Product> Products { get; private set; }
        public IEnumerable<Course> Courses { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileCourseService courseService)
        {
            _logger = logger;
            CourseService = courseService;
        }

        public void OnGet()
        {
            Courses = CourseService.GetCourses();
            
        }
    }
}
