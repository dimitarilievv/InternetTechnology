using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StylistApp.Models
{
    public class ServiceCustomers
    {
        public int ServiceId { get; set; }
        public int CustomerId { get; set; }
        public Service Service { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public ServiceCustomers() { 
            Customers= new List<Customer>();
        }
    }
}