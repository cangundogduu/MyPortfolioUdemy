﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponent
{
    public class _LayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
