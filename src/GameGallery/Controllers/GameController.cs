using GameGallery.Data;
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
        private GameRepository _gameRepository = null;

        public GameController()
        {
            _gameRepository = new GameRepository();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var game = _gameRepository.GetGame((int)id);
        
            return View(game);
        }
    }
}