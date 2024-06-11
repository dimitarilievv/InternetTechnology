using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoursesKolokviumska.Models
{


    public class Student
    {
        public Student() {
            Courses=new List<Course>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required field!")]
        public string Name { get; set; }
        [Display(Name = "Student Index")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "Student Number must contains 6 characters")]
        public int StudentNumber { get; set; }

        public string Year { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

}