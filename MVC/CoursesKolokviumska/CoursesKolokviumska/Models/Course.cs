using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoursesKolokviumska.Models
{
    public class Course
    {
        public Course()
        {
            Students=new List<Student>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required field!")]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Genre { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}