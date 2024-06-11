using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Posledna.Models
{
    public class Athlete
    {
        [Key]
        public int AthleteId { get; set; }
        [Required(ErrorMessage = "Reqired field")]
        public string Name { get; set; }
        public string Level { get; set; }
        [Display(Name = "Athlete code")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "Code must be 6 digit")]
        public int AthleteNumber { get; set; }
        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; }
        public Athlete()
        {
            TrainingPrograms = new List<TrainingProgram>();
        }
    }
}