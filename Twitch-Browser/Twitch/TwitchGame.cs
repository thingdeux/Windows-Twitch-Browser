using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Twitch_API.Twitch
{
    class TwitchGame
    {
        private string game_name = "";

        public TwitchGame(Dictionary<string, object> game_dict)
        {
            this.createGames(game_dict);            
        }
        
        public void createGames(Dictionary<string, object> game_dict)
        {
            var query = from s in game_dict
                        where s.Value != null
                        select new {s.Key, s.Value};

            foreach (var game in query)
            {
                switch (game.Key)
                {
                    case "name":
                        this.game_name = (string)game.Value;
                        break;
                }
            }
        }

        public string Game
        {
            get 
            {
                return game_name;
            }
        }
    }
}
