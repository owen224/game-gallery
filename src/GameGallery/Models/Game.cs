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
        public int Ranking { get; set; }
        public string DescriptionHtml { get; set; }
        public Creater[] Creaters { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + Ranking;
            }

        }

        // series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + Ranking + ".jpg";
            }
        }
    }
}