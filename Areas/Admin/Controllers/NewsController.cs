﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ryan.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
