using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LV3.Models
{
    public class Hospital
    {
        public Hospital()
        {
            Doctors = new List<Doctor>();
        }
        [Key]
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string HospitalAddress { get; set; }
        public string HospitalImageURL { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}