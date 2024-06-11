using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV3.Models
{
    public class Patient
    {
        public Patient()
        {
            Doctors = new List<Doctor>();
        }
        [Key]
        public int PatientId { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Range(10000, 99999, ErrorMessage = "Code must be 5-digit")]
        public int PatientCode { get; set; }
        public string PatientGender { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}