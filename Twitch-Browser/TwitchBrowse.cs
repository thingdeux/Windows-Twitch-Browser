using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base_API.API;
using Twitch_API.Twitch;


namespace WindowsFormsApplication1
{
    public partial class TwitchBrowse : Form
    {
        public TwitchBrowse()
        {
            InitializeComponent();
        }        

        private void callAPI_Click(object sender, EventArgs e)
        {
            
            TwitchAPI twitch = new TwitchAPI();
            // string resp = twitch.GetRawHTMLFromURI();
            string resp = twitch.get_top_streams();
            RespDisplay.Text = resp;
            Main_Stream_Title.Text = twitch.get_stream(1).get_title;
            Main_Stream_Picture.ImageLocation = twitch.get_stream(1).image_url;            
            
        }        
        
    }
       
}
