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
            ViewBag.SeriesTitle = "Grand Theft Auto 5";
            ViewBag.Ranking = 1;
            ViewBag.Description = "<p>The biggest, most dynamic and most diverse open world ever created, Grand Theft Auto V blends storytelling and gameplay in new ways as players repeatedly jump in and out of the lives of the game’s three lead characters, playing all sides of the game’s interwoven story.<strong></p>";
            ViewBag.Creaters = new string[]
            {
                "Developer: Rockstar North",
                "Publisher: Rockstar Games",
                "Series: Grand Theft Auto",
                "Platform: Xbox One, Playstation 4, PC"
            };
     
            return View();
        }
    }
}