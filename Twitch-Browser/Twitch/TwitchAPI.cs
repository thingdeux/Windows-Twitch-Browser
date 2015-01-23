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
        private JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        private TwitchStreams found_streams = new TwitchStreams();

        // Twitch API Constructor
        public TwitchAPI() : base()
        {            
            this.SetURI = string.Format("https://api.twitch.tv/kraken/streams?limit={0}&embeddable=true&game=Ultra Street Fighter IV", channel_limit);
            this.addHeader("Accept", string.Format("application/vnd.twitchtv.v{0}+json", twitch_api_version));
        }

        public string get_top_streams()
        {
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
            // return (response_string);     
            return (found_streams.ToString());

        }

        public TwitchStream get_stream(int index) {
            return found_streams[index];
        }
    }
}
