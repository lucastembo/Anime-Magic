using Practical_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_8.Data;

namespace Practical_8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "My Time to Shine";
            List<Anime> animes = AnimeData.GetAnimeList();

            return View(animes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Title = "Contact AnimeMagic ";
            ViewBag.Message = "We'd love to hear from you!";
            return View();
        }
    }
}