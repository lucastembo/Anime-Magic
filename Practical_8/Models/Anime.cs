using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_8.Models
{
    public class Anime
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public AnimeImage Image { get; set; }
        public string Kind { get; set; }
        public int Episodes { get; set; }
        public int EpisodesAired { get; set; }
        public string Score { get; set; }
    }

    public class AnimeImage
    {
        public string Original { get; set; }
    }

}