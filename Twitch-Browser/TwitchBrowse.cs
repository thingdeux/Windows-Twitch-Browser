﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Base_API.API;
using Twitch_API.Twitch;


namespace Stream_Browser
{
    public partial class TwitchBrowse : Form
    {
        private static bool isDebug = true;
        private TwitchAPI twitch = new TwitchAPI();        
        private Configuration config_window;

        public TwitchBrowse()
        {
            InitializeComponent();
            // Call Twitch and get a list of popular games, feed them to the game selector
            this.gameSelector_list_load();
        }

        public void clearPreviews()
        {
            throw new NotImplementedException();
        }

        public void drawPreviews()
        {
            string resp = twitch.get_top_streams();

            try
            {
                this.Preview1Text.Text = twitch.get_stream(1).get_title;
                this.PreviewImage1.ImageLocation = twitch.get_stream(1).image_url;
                this.Preview2Text.Text = twitch.get_stream(2).get_title;
                this.PreviewImage2.ImageLocation = twitch.get_stream(2).image_url;
                this.Preview3Text.Text = twitch.get_stream(3).get_title;
                this.PreviewImage3.ImageLocation = twitch.get_stream(3).image_url;
                this.Preview4Text.Text = twitch.get_stream(4).get_title;
                this.PreviewImage4.ImageLocation = twitch.get_stream(4).image_url;
            }
            catch
            {
                // TODO: Error Catch
            }
            
        }

        private void callAPI_Click(object sender, EventArgs e)
        {            
            drawPreviews();
        }        

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PreviewImage_Click(object sender, EventArgs e)
        {            
            PictureBox image_clicked = (PictureBox)sender;
            int previewImageNum = int.Parse(image_clicked.Name.Substring(image_clicked.Name.Length - 1));
            string stream_url = twitch.get_stream(previewImageNum).StreamUrl;

            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = stream_url;
            proc.Start();

        }

        private void gameSelector_list_load()
        {            
            // Cast Sender to Combobox, add items
            ComboBox selection_box = this.gameSelector;
            selection_box.Items.Clear();       
            List<string> popular_games = twitch.get_popular_games();
            selection_box.Items.Add("Ultra Street Fighter IV");

            foreach (string game in popular_games)
            {                
                if (!selection_box.Items.Contains(game))
                {
                    selection_box.Items.Add(game);
                }                    
            }
        }        

        private void gameSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selection_box = (ComboBox)sender;            
            twitch.Game = selection_box.SelectedItem.ToString();
            drawPreviews();
        }

        private void setFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(config_window.ToString());
            if (config_window == null)
            {
                if (this.config_window == null)
                {
                    this.config_window = new Configuration();
                    config_window.Show();
                }                                
            }            
        }
    }
       
}
