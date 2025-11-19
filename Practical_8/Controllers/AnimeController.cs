using Practical_8.Data;
using Practical_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_8.Controllers
{
    public class AnimeController : Controller
    {
        // GET: Anime
        private List<Anime> _animeList = AnimeData.GetAnimeList();
        private List<Description> _descriptionList = AnimeData.GetDescriptionList();
        public ActionResult Details(string id)
        {
            // Find the matching anime and description
            var anime = _animeList.FirstOrDefault(a => a.Id == id);
            var description = _descriptionList.FirstOrDefault(d => d.AnimeId == id);

            if (anime == null || description == null)
            {
                return HttpNotFound();
            }
            if (anime != null)
            {
                anime.Name = anime.Name.Replace("_", " ");
            }

            // Pass both anime and description to the view using ViewBag
            ViewBag.Anime = anime;
            ViewBag.Description = description;

            return View();
        }
    }
}