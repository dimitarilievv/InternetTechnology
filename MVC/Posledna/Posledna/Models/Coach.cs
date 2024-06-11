using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Posledna.Models
{
    public class Coach
    {
        [Key]
        public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<TrainingProgram> TrainingPrograms { get; set; }

        public Coach()
        {
            TrainingPrograms = new List<TrainingProgram>();
        }
    }
}