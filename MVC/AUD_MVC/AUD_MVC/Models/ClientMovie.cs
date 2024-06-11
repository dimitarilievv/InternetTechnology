using AUD_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AUD_MVC.Models
{
    public class ClientMovie
    {
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }
        public int selectedClientId { get; set; }
        public int movieId { get; set; }
    }
}