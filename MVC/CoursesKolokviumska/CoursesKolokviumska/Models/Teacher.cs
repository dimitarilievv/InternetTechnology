using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoursesKolokviumska.Models
{
 

    public class Teacher
    {
        public Teacher() { 
            Courses=new List<Course>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Required field!")]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

}