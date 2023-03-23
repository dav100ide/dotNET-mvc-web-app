using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.ViewModels;
using MyCourse.Models.Services.Application.CourseService;

namespace MyCourse.Controllers
{
   public class CoursesController : Controller
   {
      public IActionResult index()
      {
         /*se non specifico il nome,
         View() ritorna index pk è il nome del metodo*/
         var courseService = new CourseService();

         List<CourseViewModel> courses = courseService.GetCourses();
         return View(courses);
      }

      public IActionResult Detail(string id)
      {
         return View();
      }

      public IActionResult Search(string title)
      {
         return Content($"hai cercato {title}");
      }
   }
}