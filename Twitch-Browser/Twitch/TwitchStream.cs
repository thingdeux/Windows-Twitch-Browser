using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Twitch_API.Twitch
{        
    public class TwitchStream
    {     
        private string broadcaster;        
        private string id;
        private string viewers;
        private string preview_image;
        private string game;
        private string stream_title;
        private string url;

        public TwitchStream(Dictionary<string, object> stream)
        {
            this.CreateStream(stream);
        }

        // TODO : Revisit this Hackie Implementation
        // Hackie .... using this to process streams that don't exist.
        public TwitchStream(bool does_not_exist)
        {
            broadcaster = "";
            id = "";
            viewers = "";
            preview_image = "";
            game = "";
            stream_title = "";
            url = "";
        }

        private void CreateStream(Dictionary<string, object> stream) {
            var query = from s in stream
                        where s.Value != null                        
                        select new { s.Key, s.Value };

            foreach (var game in query)
            {                
                switch (game.Key) 
                {
                    case "game":
                        this.game = (string)game.Value;
                        break;
                    case "viewers":
                        this.viewers = (string)game.Value.ToString();
                        break;                    
                    case "preview":
                        this.preview_image = (string)game.Value;
                        break;
                    case "_id":
                        this.id = (string)game.Value.ToString();;
                        break;
                    case "channel":
                        this.generateChannelInfo((Dictionary<string, object>)game.Value);
                        break;                        
                }
            }
            
            
        }

        private void generateChannelInfo(Dictionary<string, object> channel_info)
        {            
                        foreach (string key in channel_info.Keys)
                        {
                            switch (key)
                            {
                                case "status":
                                    this.stream_title = (string)channel_info[key];
                                    break;
                                case "url":
                                    this.url = (string)channel_info[key];
                                    break;
                                case "display_name":
                                    this.broadcaster = (string)channel_info[key];
                                    break;

                            }
                        }
        }

        public string get_info()
        {
            StringBuilder return_string = new StringBuilder();
            return_string.Append(string.Format("\n"));
            return_string.Append(string.Format("Game: {0}\n", this.game));
            return_string.Append(string.Format("Title: {0}\n", this.stream_title));
            return_string.Append(string.Format("Broadcaster: {0}\n", this.broadcaster));            
            return_string.Append(string.Format("Viewers: {0}\n", this.viewers));
            return_string.Append(string.Format("URL: {0}\n", this.url));
            return_string.Append(string.Format("\n"));
            return return_string.ToString();
        }

        public string Title
        {
            get 
            {
                return stream_title;
            }
        }

        public string image_url
        {
            get
            {
                return preview_image;
            }
        }

        public string StreamUrl
        {
            get
            {
                return url;
            }
        }

        public string Broadcaster
        {
            get
            {
                return broadcaster;
            }
        }
    }

}
