using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Base_API.API;
using Twitch_API.Twitch;
using Stream_Browser.DB;


namespace Stream_Browser
{
    public partial class TwitchBrowse : Form
    {        
        private TwitchAPI twitch = new TwitchAPI();
        private Configuration config_window;
        private const string BESTGAMEEVER = "Ultra Street Fighter IV";        
        // A dictionary that contains other dictionaries, 
        // each sub-dictionary will contains an indexed stream object 
        private Dictionary<int, Dictionary<string, Object>> preview_containers = 
            new Dictionary<int, Dictionary<string, Object>>();

        public TwitchBrowse()
        {
            InitializeComponent();
            if (this.VerifyInternetConnectivity() && DB.Commands.is_db_created())
            {
                // Call Twitch and get a list of popular games, feed them to the game selector            
                this.gameSelector_list_load();
                this.create_containers();                
            }
            else
            {
                this.IntroTextBox.Text = "This Application Requires an internet connection\n\n --Sorry";
            }
        }        

        protected bool VerifyInternetConnectivity()
        {
            // Ping Googles DNS Server to test internet connectivity
            Ping pinger = new Ping();
            PingReply replied = pinger.Send("8.8.8.8");            
            if (replied.Status == IPStatus.Success)
            {                
                return (true);
            }
            else
            {                
                return (false);
            }
            
        }                
        
        public void drawPreviews()
        {
            // TODO : Remove call to twitch on drawPreviews
            twitch.get_top_streams();
            
            if (IntroTextBox.IsDisposed == false) 
            {
                IntroTextBox.Hide();
                IntroTextBox.Enabled = false;
                IntroTextBox.Dispose();  
            }

            for (int i = 0; i < preview_containers.Count; i++)            
            {
                Dictionary<string, Object> preview = preview_containers[i];
                PictureBox image_box = (PictureBox)preview["image"];
                RichTextBox title_box = (RichTextBox)preview["title"];
                RichTextBox broadcaster_box = (RichTextBox)preview["broadcaster"];
                try
                {
                    image_box.ImageLocation = twitch.get_stream(i).image_url;
                    title_box.Text = twitch.get_stream(i).Title;
                    broadcaster_box.Text = twitch.get_stream(i).Broadcaster;
                    
                    if (!image_box.Enabled)
                    {
                        image_box.Enabled = true;
                    }                    
                }                
                catch (ArgumentOutOfRangeException)
                {                 
                    image_box.Image = null;
                    title_box.Text = "";
                    broadcaster_box.Text = "";
                    image_box.Enabled = false;
                    
                }                
            }            
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

        private void create_containers()
        {
            // Add the PictureBox objects to the preview_containers dictionary.
            this.add_pictureboxes_to_container();
            // Add the TextBox objects to the preview_containers dictionary.
            this.add_textboxes_to_container();
        }

        private void add_pictureboxes_to_container()
        {
            var query = from object preview in this.Controls
                        where preview is PictureBox
                        select preview;            
            
            foreach (PictureBox f in query) 
            {
                /// VERY IMPORTANT - Make sure when adding a new previewbox that there's an int at the end of the name
                /// That is not shared with another PictureBox.  As these will be created dynamically, this message should 
                /// Not be as necessasy post feature add.
                if (f.Tag != null && (string)f.Tag == "game".ToLower())
                {
                    string name = f.Name.ToString();
                    int parsed_index = int.Parse(name.Substring(name.Length - 1));
                    // If a dictionary has not been created at the given index create one
                    if (!preview_containers.ContainsKey(parsed_index)) {
                        preview_containers[parsed_index] = new Dictionary<string, Object>();
                    }                    
                    preview_containers[parsed_index].Add("image", f);
                }
            }
        }

        private void add_textboxes_to_container()
        {
            var query = from object preview in this.Controls
                        where preview is RichTextBox
                        select preview;

            foreach (RichTextBox f in query)
            {
                if (f.Tag != null)
                {
                    string name = f.Name.ToString();
                    int parsed_index = int.Parse(name.Substring(name.Length - 1));
                    if (!preview_containers.ContainsKey(parsed_index))
                    {
                        preview_containers[parsed_index] = new Dictionary<string, Object>();
                    }

                    if ((string)f.Tag == "title".ToLower())
                    {
                        preview_containers[parsed_index].Add("title", f);
                    }
                    else if ((string)f.Tag == "broadcaster".ToLower())
                    {
                        preview_containers[parsed_index].Add("broadcaster", f);
                    }
                }                
            }
        }

    }       
}
