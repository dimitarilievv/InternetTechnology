using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV3.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Patients = new List<Patient>();
            Hospital = null;
        }
        [Key]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        [Required]
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}