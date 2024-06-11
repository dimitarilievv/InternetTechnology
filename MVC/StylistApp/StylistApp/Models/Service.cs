using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace StylistApp.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "This field is reqired!")]
        public string ServiceName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int StylistId { get; set; }
        public Stylist Stylist { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public Service() { 
            Customers=new List<Customer>();
        }
    }

}