﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
