using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_project.Pages.Shared.Components.Card
{
    public class CardViewComponent : ViewComponent
    {
        public CardViewComponent() { }

        public IViewComponentResult Invoke(netcore_project.Models.Education education)
        {
            return View("Index", education);
        }
    }
}
