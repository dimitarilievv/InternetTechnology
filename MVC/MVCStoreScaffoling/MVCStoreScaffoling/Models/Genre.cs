using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MVCStoreScaffoling.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Display(Name ="GenreName")]

        public string Name { get; set; }
        public string  Description { get; set; }

    }
}