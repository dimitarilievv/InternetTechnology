using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Services.Description;

namespace StylistApp.Models
{
  
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="This field is reqired!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is reqired!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is reqired!")]
        [Display(Name ="Customer Number")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "Code must contains 6 characters")]
        public int CustomerNumber { get; set; }

        public ICollection<Service> Services { get; set; }
        public Customer()
        {
            Services = new List<Service>();
        }
    }



}