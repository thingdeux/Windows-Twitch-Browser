using System;
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
        private const string BESTGAMEEVER = "Ultra Street Fighter IV";
        private List<PictureBox> preview_boxes = new List<PictureBox>();

        public TwitchBrowse()
        {
            InitializeComponent();
            // Call Twitch and get a list of popular games, feed them to the game selector
            try
            {
                this.gameSelector_list_load();
                this.create_preview_boxes();
            }
            catch (ArgumentNullException) {
                // TODO: Create No internet connection error and handler
            }
        }

        public void clearPreviews()
        {
            throw new NotImplementedException();
        }

        public void drawPreviews()
        {
            // TODO : Remove call to twitch on drawPreviews
            string resp = twitch.get_top_streams();
            int preview_location = 0;
            
            if (IntroTextBox.IsDisposed == false) 
            {
                IntroTextBox.Hide();
                IntroTextBox.Enabled = false;
                IntroTextBox.Dispose();  
            }

            
            foreach (PictureBox box in preview_boxes)
            {
                try
                {
                    preview_boxes[preview_location].ImageLocation = twitch.get_stream(preview_location).image_url;
                    if (!box.Enabled)
                    {
                        // TODO : Fix out of order indexing problem ('doh)
                        box.Enabled = true;
                    }
                    preview_location += 1;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    // TODO: Error Catch streams being out of index - This would happen if less
                    /// than X predefined preview boxes are returned for a game.  (ie: 4 Preview boxes, 2 streams returned.
                    Debug.WriteLine(string.Format("Found Missing Stream {0}", preview_location));
                    box.Enabled = false;
                }
            }
            /*
            this.Preview1Text.Text = twitch.get_stream(1).get_title;
            // this.PreviewImage1.ImageLocation = twitch.get_stream(1).image_url;
            this.Preview2Text.Text = twitch.get_stream(2).get_title;
            // this.PreviewImage2.ImageLocation = twitch.get_stream(2).image_url;
            this.Preview3Text.Text = twitch.get_stream(3).get_title;
            // this.PreviewImage3.ImageLocation = twitch.get_stream(3).image_url;
            this.Preview4Text.Text = twitch.get_stream(4).get_title;
            // this.PreviewImage4.ImageLocation = twitch.get_stream(4).image_url;            */
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
            // Street Fighter will now and FOREVER remain at the top of the popular games list,
            // Deal with it.
            selection_box.Items.Add(BESTGAMEEVER);
            selection_box.Items.Add("Spyro the Dragon");

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

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (config_window == null || this.config_window.IsDisposed)
            {
                this.config_window = new Configuration();
                config_window.Show();
            }            
        }

        private void create_preview_boxes()
        {
            var query = from object preview in this.Controls
                        where preview is PictureBox
                        select preview;
            
            foreach (PictureBox f in query) 
            {
                if (f.Tag != null && (string)f.Tag == "game".ToLower())
                {
                    this.preview_boxes.Add(f);
                }                                
            }

        }
    }
       
}
