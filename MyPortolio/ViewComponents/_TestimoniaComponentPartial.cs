﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _TestimoniaComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
