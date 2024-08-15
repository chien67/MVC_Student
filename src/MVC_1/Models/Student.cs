using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Standard standard  { get; set; }
    }
public class Standard
{
    public int StandardID { get; set; }
    public string StandardName { get; set; }
}
}