using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Twitch_API.Twitch
{
    class TwitchStreams : List<TwitchStream>
    {
        public override string ToString()
        {
            StringBuilder return_string = new StringBuilder();
            foreach (TwitchStream twitch_stream in this) {
                   return_string.Append(twitch_stream.get_info());
            }
            return return_string.ToString();

        }
    }
    
}
