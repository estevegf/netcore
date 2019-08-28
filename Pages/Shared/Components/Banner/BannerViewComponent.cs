using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_project.Pages.shared.Components.Banner
{
    public class BannerViewComponent : ViewComponent
    {
        public BannerViewComponent() { }
        public IViewComponentResult Invoke (string imageUrl)
        {
            return View("Index", imageUrl);
        }
    }
}
