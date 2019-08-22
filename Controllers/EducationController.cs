using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace netcore_project.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            return View("Pages/Education/Index.cshtml");
        }
    }
}