using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCStoreScaffoling.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Display(Name="ArtistName")]
        public string Name { get; set; }
    }
}