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


namespace Stream_Browser
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
            Preview1Text.Text = twitch.get_stream(1).get_title;
            PreviewImage1.ImageLocation = twitch.get_stream(1).image_url;            
            Preview2Text.Text = twitch.get_stream(2).get_title;
            PreviewImage2.ImageLocation = twitch.get_stream(2).image_url;
            Preview3Text.Text = twitch.get_stream(3).get_title;
            PreviewImage3.ImageLocation = twitch.get_stream(3).image_url;
            Preview4Text.Text = twitch.get_stream(4).get_title;
            PreviewImage4.ImageLocation = twitch.get_stream(4).image_url;

            
        }      
        
    }
       
}
