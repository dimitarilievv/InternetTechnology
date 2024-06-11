using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreMVC.Models;
using StoreMVC.ViewModels;

namespace StoreMVC.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        /* public string Index()
         {
             return "Hello from Store.Index()";
         }
        */
        public ActionResult Index()
        {
            // return View();
            //return Content("Store index method");
            //return HttpNotFound();
            // return new EmptyResult();
            return RedirectToAction("Index", "Home", new { param1 = 2021, param2 = "corona" });
        }
        public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        [Route("store/details/{artistid:range(1,5)}/{artistalbum:regex(\\w*\\d{4})}")]
        public string Details(int? artistid, string artistalbum)
        {
            return "Hello from Store.Details(), ID=" + artistid + " and album=" + artistalbum;
        }
        public ActionResult List()
        {
            Artist artist = new Artist { Name = "Some famous" };
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "AlbumTitle" + i });
            }
            // ViewBag.Albums = albums;
            //return View();
            // ViewBag.Artist=artist;
            var viewModel = new ArtistAlbumsViewModel
            {
                Artist = artist,
                Albums = albums
            };
            return View(viewModel);
        }
        public ActionResult ShowSearch()
        {
            return View();
        }
        public ActionResult Search(string q)
        {
            var albums = new List<Album>();
            albums.Add(new Album { Title = "New Beginning" });
            albums.Add(new Album { Title = "Echoes of Eternity" });
            albums.Add(new Album { Title = "Lost in Time" });
            albums.Add(new Album { Title = "Rhythms of the Soul" });
            albums.Add(new Album { Title = "Whispers in the Wind" });
            albums.Add(new Album { Title = "Beyond the Horizon" });

            var resultAlbums = new List<Album>();
            foreach (Album a in albums)
            {
                if (a.Title.Contains(q))
                {
                    resultAlbums.Add(a);
                }
            }
            return View(resultAlbums);
        }
        public ActionResult Helpers()
        {
            return View();
        }
        public ActionResult HelpersV()
        {
            return Content("");
        }
    }
}