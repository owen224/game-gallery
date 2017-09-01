using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameGallery.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int Ranking { set; get; }
        public string DescriptionHtml { set; get; }
        public Creater[] Creaters { get; set; }
        public bool Favorite { get; set; }
    }
}