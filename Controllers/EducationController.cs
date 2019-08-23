using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore_project.Models;
using netcore_project.ViewModels;

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
            EducationIndex educationIndexViewModel = new EducationIndex()
            {
                Stars = await _api.GetStars(),
            };
            return View("Pages/Education/Index.cshtml", educationIndexViewModel);
        }
    }
}