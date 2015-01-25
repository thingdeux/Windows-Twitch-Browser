using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base_API.API;
using System.Diagnostics;
using System.Web.Script.Serialization;



namespace Twitch_API.Twitch
{
    class TwitchAPI : API
    {
        private int twitch_api_version = 2;
        private int channel_limit = 10;
        private string game = "Ultra Street Fighter IV";
        private JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        private TwitchStreams found_streams = new TwitchStreams();
        private TwitchGames popular_games = new TwitchGames();

        // Twitch API Constructor
        public TwitchAPI() : base()
        {                        
            this.addHeader("Accept", string.Format("application/vnd.twitchtv.v{0}+json", twitch_api_version));
        }

        public string get_top_streams()
        {
            this.SetURI = string.Format(
               "https://api.twitch.tv/kraken/streams?limit={0}&embeddable=true&game={1}",
               this.channel_limit, this.game);
            found_streams.Clear();
            // TODO: Catch no HTTP response
            string response_string = this.GetRawHTMLFromURI();
            // Deserialize the response into a generic dictionary
            Dictionary<string, object> Json_Response = (Dictionary<string, object>)jsonSerializer.DeserializeObject(response_string);
            
            foreach (string key in Json_Response.Keys)
            {
                #region Deserialize stream objects to twitchStreams
                if (key == "streams") {
                    
                    // Because all of the response are generic, force cast into object Array                    
                    object[] stream_objects = (object[])Json_Response[key];

                    for (int i = 0; i < stream_objects.Length; i++)
                    {                        
                        // Create Twitch Stream objects for each stream key/value pair and add them to the found_stream list
                        found_streams.Add(new TwitchStream((Dictionary<string, object>)stream_objects[i]));
                    }
                }
                #endregion

                if (key == "_links") {
                    continue;
                }
            }            
            return (found_streams.ToString());

        }

        public List<string> get_popular_games()
        {
            // TODO : Abstract all of this away, generic api crawls
            this.SetURI = string.Format("https://api.twitch.tv/kraken/games/top?limit=19");
            string response_string = this.GetRawHTMLFromURI();
            popular_games.Clear();
            // Deserialize the response into a generic dictionary
            Dictionary<string, object> Json_Response = (Dictionary<string, object>)jsonSerializer.DeserializeObject(response_string);            
            #region Deserialize stream objects to twitchStreams
            var query = from s in Json_Response
                        where s.Key == "top"
                        select s.Value;

            // The JSON Response for the game query returns a "Top" object with an array of objects.
            // I am forcing the execution of the linq query (which will only ever contain one element)
            // Then casting to an object array.
            object[] stream_objects = (object[])query.ToArray().First<object>();

            foreach(object game in stream_objects)
            {
                    // Create Twitch Stream objects for each stream key/value pair and add them to the found_stream list
                    Dictionary<string, object> game_list_dict = (Dictionary<string, object>)game;

                    foreach (string game_list_key in game_list_dict.Keys)
                    {
                        if (game_list_key == "game")
                        {
                            popular_games.Add(new TwitchGame(
                                (Dictionary<string, object>)game_list_dict[game_list_key]
                            ));
                        }
                    }                    
            }
            #endregion

            List<string> list_to_return = new List<string>();
            foreach (TwitchGame game in this.popular_games)
            {
                list_to_return.Add(game.Game);
            }

            return list_to_return;
        }

        public TwitchStream get_stream(int index) {            
            return found_streams[index];
        }

        public string Game
        {
            get
            {
                return game;
            }
            set
            {
                game = value;
            }
        }
        
    }
}
