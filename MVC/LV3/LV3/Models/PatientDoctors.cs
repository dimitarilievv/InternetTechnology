using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LV3.Models
{
    public class PatientDoctors
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patient> Patients { get; set; }
        public PatientDoctors() { 
            Patients=new List<Patient>();
        }
    }
}