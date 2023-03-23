using System;
using System.Collections.Generic;
using System.Net.Mime;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application.CourseService
{
   public class CourseService
   {
      public List<CourseViewModel> GetCourses()
      {
         var courseList = new List<CourseViewModel>();
         var rand = new Random();

         for (int i = 1; i <= 20; i++)
         {
            var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
            var course = new CourseViewModel
            {
               id = i,
               title = $"corso {i}",
               author = "Autore Twin",
               price = Math.Round(Convert.ToDecimal(rand.NextDouble() * 10 + 5), 2),
               description = "descrizione generata nel ciclo di CourseService.cs",
               rating = rand.Next(1, 6),
            };
            courseList.Add(course);
         }
         return courseList;
      }
   }
}