using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WebApplication.Models;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication.Services
{
    public class JsonFileCourseService
    {
        public JsonFileCourseService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
        private string DataFiles
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "courses.json"); }
        }

        public IEnumerable<Course> GetCourses()
        {
            using (var jsonFileReader = File.OpenText(DataFiles))
            {
                return JsonSerializer.Deserialize<Course[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }


}
