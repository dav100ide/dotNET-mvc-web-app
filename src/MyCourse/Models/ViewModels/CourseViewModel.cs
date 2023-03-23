using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Models.ViewModels
{
   public class CourseViewModel
   {
      public int id { get; set; }
      public string title { get; set; }
      public string author { get; set; }
      public decimal price { get; set; }
      public string description { get; set; }
      public int rating { get; set; }
   }
}