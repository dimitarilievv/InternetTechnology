using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Posledna.Models
{
    public class TrainingProgramAthletes
    {
        public int TrainingProgramId { get; set; }
        public int AthleteId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public virtual ICollection<Athlete> Athletes{ get; set; }
    }
}