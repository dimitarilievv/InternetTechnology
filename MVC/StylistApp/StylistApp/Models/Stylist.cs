using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Services.Description;

namespace StylistApp.Models
{
  
    public class Stylist
    {
        [Key]
        public int StylistId { get; set; }
        [Required(ErrorMessage = "This field is reqired!")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExperienceLevel { get; set; }
        public ICollection<Service> Services { get; set; }
        public Stylist()
        {
            Services= new List<Service>();
        }
    }


}