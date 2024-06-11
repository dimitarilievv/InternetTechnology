using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreMVC.Models;

namespace StoreMVC.ViewModels
{
    public class ArtistAlbumsViewModel
    {
        public Artist Artist { get; set; }
        public List<Album> Albums { get; set; }
    }
}