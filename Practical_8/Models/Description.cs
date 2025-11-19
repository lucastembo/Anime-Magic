using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_8.Models
{
    public class Description
    {
        public string Id { get; set; }           // Primary key
        public string AnimeId { get; set; }      // Foreign key referencing the Anime
        public string LongText { get; set; }  // Long text description of the anime
    }

}