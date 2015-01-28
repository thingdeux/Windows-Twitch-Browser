using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base_API.API;
using System.Diagnostics;
using System.Web.Script.Serialization;
using Stream_Browser.DB;



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

        public void get_top_streams()
        {            
            if (available_in_cache(this.game))
            {
                found_streams.Clear();
                load_streams_from_db(this.game);
            }
            else
            {            
                this.SetURI = string.Format(
                   "https://api.twitch.tv/kraken/streams?limit={0}&embeddable=true&game={1}",
                   this.channel_limit, this.game);

                found_streams.Clear();

                // TODO: Catch no HTTP response
                string response_string = this.GetRawHTMLFromURI();
                // Deserialize the response into a generic dictionary
                Dictionary<string, object> Json_Response = (Dictionary<string, object>)jsonSerializer.DeserializeObject(response_string);

                #region Deserialize stream objects to twitchStreams
                foreach (string key in Json_Response.Keys)
                {
                
                    if (key == "streams") {
                    
                        // Because all of the response are generic, force cast into object Array                    
                        object[] stream_objects = (object[])Json_Response[key];

                        for (int i = 0; i < stream_objects.Length; i++)
                        {                        
                            // Create Twitch Stream objects for each stream key/value pair and add them to the found_stream list
                            found_streams.Add(new TwitchStream((Dictionary<string, object>)stream_objects[i]));
                        }
                    }                

                    if (key == "_links") {
                        continue;
                    }
                }
                #endregion                
                this.update_cache_streams(this.game);
            }
        }

        public bool available_in_cache(string game)
        {            
            // If the games streams are at least 20 mins old rebuild them.
            // Performs the cheaper lookup first, count on games, then checks to see if they're out of date.
            if (Commands.has_enough_streams(game) && !Commands.streams_require_rebuilding(game))
            {
                return true;
            }
            else
            {
                return false;
            }
                                 
        }

        public void load_streams_from_db(string game)
        {            
            foreach (Stream s in Commands.QueryStreams(game))
            {
                TwitchStream retrieved_stream = new TwitchStream(
                    s.Broadcaster, s.Title, s.Url, s.Game, s.Viewers.ToString(), s.PreviewImage
                );                
                found_streams.Add(retrieved_stream);
            }
        }

        public void update_cache_streams(string game)
        {
            Commands.delete_outdated_streams(game);            
            foreach (TwitchStream stream in found_streams)
            {
                Stream_Browser.DB.Commands.insert_twitch_stream(stream);
            }
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
            if (found_streams.ElementAtOrDefault(index) != null) 
            { 
                return found_streams[index]; 
            }
            else 
            {             
                return new TwitchStream(false);
            }
            
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
