using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult index()
        {
            return Content("sono index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"sono detail il mio id è {id}");
        }

        public IActionResult Search(string title)
        {
            return Content($"hai cercato {title}");
        }
    }
}