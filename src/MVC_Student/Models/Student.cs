using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Student.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        
        [Display(Name = "name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Standard standard { get; set; }
    }
    public class Standard
    {
        public int SrandardID { get; set; }
        public string StandardName { get; set; }
    }
}