using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameGallery.Models;

namespace GameGallery.Data
{
    public class GameRepository
    {

        private static Game[] _game = new Game[]
        {
            new Game()
            {
                Id = 1,
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
            },

            new Game()
    {
        Id = 2,
        SeriesTitle = "Battlefield ",
        Ranking = 2,
        DescriptionHtml = "<p><strong>Battlefield 1 Revolution* brings you into the dawn of all-out warfare, where no battle is ever the same. Join the ranks and revolutionize your play with access to new maps, new modes, and new conflicts.</strong></p>",
        Creaters = new Creater[]
        {
            new Creater() { Name = "EA DICE", Role = "Developer" },
            new Creater() { Name = "Electric Arts", Role = "Publisher" },
            new Creater() { Name = "Battlefield", Role = "Series" },
            new Creater() { Name = "Xbox One, Playstation 4, PC", Role = "Platform" },
        },
        Favorite = false
    },
    new Game()
    {
        Id = 3,
        SeriesTitle = "Call of Duty",
        Ranking = 3,
        DescriptionHtml = "<p><strong>Call of Duty® returns to its roots with Call of Duty®: WWII—a breathtaking experience that redefines World War II for a new gaming generation. Land in Normandy on D-Day and battle across Europe through iconic locations in history’s most monumental war. Experience classic Call of Duty combat, the bonds of camaraderie, and the unforgiving nature of war.</strong></p>",
        Creaters = new Creater[]
        {
            new Creater() { Name = "Sledgehammer Games", Role = "Developer" },
            new Creater() { Name = "JActivision", Role = "Publisher" },
            new Creater() { Name = "Call of Duty", Role = "Series" },
            new Creater() { Name = "Xbox One, Playstation 4, PC", Role = "Platform" }
        },
        Favorite = false
    }

   };

        public Game[] GetGame()
        {
            return _game;
        }

        public Game GetGame(int id)
        {
            Game gameToReturn = null;

            foreach (var game in _game)
            {
                if (game.Id == id)
                {
                    gameToReturn = game;

                    break;
                }
            }


            return gameToReturn;
        }
    }
}