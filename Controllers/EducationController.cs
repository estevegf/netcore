using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore_project.Models;

namespace netcore_project.Controllers
{
    public class EducationController : Controller
    {
        private readonly IApi _api;
    
        public EducationController(IApi api)
        {
            _api = api;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["stars"] = await _api.GetStars();
            return View("Pages/Education/Index.cshtml");
        }
    }
}