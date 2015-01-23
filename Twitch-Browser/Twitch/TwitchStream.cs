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

        private void CreateStream(Dictionary<string, object> stream) {            
            foreach (string key in stream.Keys) {
                //Debug.WriteLine(string.Format("Key: {0} Value: {1}", key, stream[key]));
                switch (key) {
                    case "game":
                        this.game = (string)stream[key];
                        break;
                    case "viewers":                        
                        this.viewers = string.Format("{0}", stream[key]);
                        break;                    
                    case "preview":
                        this.preview_image = (string)stream[key];
                        break;
                    case "_id":
                        this.id = string.Format("{0}", stream[key]);
                        break;
                    case "channel":                        
                        this.generateChannelInfo((Dictionary<string, object>)stream[key]);
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

        public string get_title
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
    }

}
