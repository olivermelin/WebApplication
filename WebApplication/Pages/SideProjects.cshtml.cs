using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Pages
{
    public class SideProjectsModel : PageModel
    {
        private readonly ILogger<SideProjectsModel> _logger;

        public SideProjectsModel(ILogger<SideProjectsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}