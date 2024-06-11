using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoursesKolokviumska.Models
{
    public class CourseStudents
    {
        public int CourseId { get; set; } 
        public int StudentId { get; set; } 
        public Course course { get; set; } 
        public virtual ICollection<Student> students { get; set; }
    }
}