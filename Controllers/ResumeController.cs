using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ryan.Web.UI.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Resume()
        {
            return View();
        }
    }
}
