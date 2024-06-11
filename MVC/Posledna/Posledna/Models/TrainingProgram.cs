using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Posledna.Models
{
    public class TrainingProgram
    {
        [Key]
        public int TrainingProgramId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CoachId { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual ICollection<Athlete> Athletes { get; set; }
        public TrainingProgram()
        {
            Athletes = new List<Athlete>();
        }
    }
}