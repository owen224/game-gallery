using GameGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameGallery.Controllers
{
        public class GameController : Controller 
        { 
        public ActionResult Detail()
        {
            var game = new Game()
            {
                SeriesTitle = "Grand Theft Auto 5",
                Ranking = 1,
                DescriptionHtml = "<p>The biggest, most dynamic and most diverse open world ever created, Grand Theft Auto V blends storytelling and gameplay in new ways as players repeatedly jump in and out of the lives of the game’s three lead characters, playing all sides of the game’s interwoven story.<strong></p>",
                Creaters = new Creater[]
                {
                    new Creater() { Name = "Rockstar North", Role = "Developer" },
                    new Creater() { Name = "Rockstar Games", Role = "Publisher" },
                    new Creater() { Name = "Grand Theft Auto", Role = "Series" },
                    new Creater() { Name = "Xbox One, Playstation 4, PC", Role = "Platform" },
                }
            };

            return View(game);
        }
    }
}