using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class JsonFileProjectService
    {
        public JsonFileProjectService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string DataFiles
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "sideprojects.json"); }
        }

        public IEnumerable<SideProject> GetSideProjects()
        {
            using (var jsonFileReader = File.OpenText(DataFiles))
            {
                return JsonSerializer.Deserialize<SideProject[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
