namespace Stream_Browser
{
    partial class TwitchBrowse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitchBrowse));
            this.PreviewImage0 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewImage1 = new System.Windows.Forms.PictureBox();
            this.PreviewImage2 = new System.Windows.Forms.PictureBox();
            this.PreviewImage3 = new System.Windows.Forms.PictureBox();
            this.Preview4Text = new System.Windows.Forms.RichTextBox();
            this.Preview3Text = new System.Windows.Forms.RichTextBox();
            this.Preview1Text = new System.Windows.Forms.RichTextBox();
            this.Preview2Text = new System.Windows.Forms.RichTextBox();
            this.TwitchLogo = new System.Windows.Forms.PictureBox();
            this.gameSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IntroTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage0)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwitchLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewImage0
            // 
            this.PreviewImage0.Enabled = false;
            this.PreviewImage0.ErrorImage = null;
            this.PreviewImage0.InitialImage = null;
            this.PreviewImage0.Location = new System.Drawing.Point(45, 27);
            this.PreviewImage0.Name = "PreviewImage0";
            this.PreviewImage0.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage0.TabIndex = 2;
            this.PreviewImage0.TabStop = false;
            this.PreviewImage0.Tag = "game";
            this.PreviewImage0.Click += new System.EventHandler(this.PreviewImage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // PreviewImage1
            // 
            this.PreviewImage1.Enabled = false;
            this.PreviewImage1.ErrorImage = null;
            this.PreviewImage1.InitialImage = null;
            this.PreviewImage1.Location = new System.Drawing.Point(429, 27);
            this.PreviewImage1.Name = "PreviewImage1";
            this.PreviewImage1.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage1.TabIndex = 5;
            this.PreviewImage1.TabStop = false;
            this.PreviewImage1.Tag = "game";
            this.PreviewImage1.Click += new System.EventHandler(this.PreviewImage_Click);
            // 
            // PreviewImage2
            // 
            this.PreviewImage2.Enabled = false;
            this.PreviewImage2.ErrorImage = null;
            this.PreviewImage2.InitialImage = null;
            this.PreviewImage2.Location = new System.Drawing.Point(45, 257);
            this.PreviewImage2.Name = "PreviewImage2";
            this.PreviewImage2.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage2.TabIndex = 6;
            this.PreviewImage2.TabStop = false;
            this.PreviewImage2.Tag = "game";
            this.PreviewImage2.Click += new System.EventHandler(this.PreviewImage_Click);
            // 
            // PreviewImage3
            // 
            this.PreviewImage3.Enabled = false;
            this.PreviewImage3.ErrorImage = null;
            this.PreviewImage3.InitialImage = null;
            this.PreviewImage3.Location = new System.Drawing.Point(429, 257);
            this.PreviewImage3.Name = "PreviewImage3";
            this.PreviewImage3.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage3.TabIndex = 7;
            this.PreviewImage3.TabStop = false;
            this.PreviewImage3.Tag = "game";
            this.PreviewImage3.Click += new System.EventHandler(this.PreviewImage_Click);
            // 
            // Preview4Text
            // 
            this.Preview4Text.BackColor = System.Drawing.SystemColors.Window;
            this.Preview4Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Preview4Text.Location = new System.Drawing.Point(429, 454);
            this.Preview4Text.Name = "Preview4Text";
            this.Preview4Text.ReadOnly = true;
            this.Preview4Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Preview4Text.Size = new System.Drawing.Size(320, 27);
            this.Preview4Text.TabIndex = 8;
            this.Preview4Text.Text = "";
            this.Preview4Text.WordWrap = false;
            // 
            // Preview3Text
            // 
            this.Preview3Text.BackColor = System.Drawing.SystemColors.Window;
            this.Preview3Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Preview3Text.Location = new System.Drawing.Point(45, 454);
            this.Preview3Text.Name = "Preview3Text";
            this.Preview3Text.ReadOnly = true;
            this.Preview3Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Preview3Text.Size = new System.Drawing.Size(320, 27);
            this.Preview3Text.TabIndex = 9;
            this.Preview3Text.Text = "";
            this.Preview3Text.WordWrap = false;
            // 
            // Preview1Text
            // 
            this.Preview1Text.BackColor = System.Drawing.SystemColors.Window;
            this.Preview1Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Preview1Text.Location = new System.Drawing.Point(45, 224);
            this.Preview1Text.Name = "Preview1Text";
            this.Preview1Text.ReadOnly = true;
            this.Preview1Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Preview1Text.Size = new System.Drawing.Size(320, 27);
            this.Preview1Text.TabIndex = 10;
            this.Preview1Text.Text = "";
            this.Preview1Text.WordWrap = false;
            // 
            // Preview2Text
            // 
            this.Preview2Text.BackColor = System.Drawing.SystemColors.Window;
            this.Preview2Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Preview2Text.Location = new System.Drawing.Point(429, 224);
            this.Preview2Text.Name = "Preview2Text";
            this.Preview2Text.ReadOnly = true;
            this.Preview2Text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Preview2Text.Size = new System.Drawing.Size(320, 27);
            this.Preview2Text.TabIndex = 11;
            this.Preview2Text.Text = "";
            this.Preview2Text.WordWrap = false;
            // 
            // TwitchLogo
            // 
            this.TwitchLogo.ErrorImage = null;
            this.TwitchLogo.Image = ((System.Drawing.Image)(resources.GetObject("TwitchLogo.Image")));
            this.TwitchLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TwitchLogo.InitialImage")));
            this.TwitchLogo.Location = new System.Drawing.Point(586, 477);
            this.TwitchLogo.Name = "TwitchLogo";
            this.TwitchLogo.Size = new System.Drawing.Size(198, 82);
            this.TwitchLogo.TabIndex = 12;
            this.TwitchLogo.TabStop = false;
            // 
            // gameSelector
            // 
            this.gameSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameSelector.FormattingEnabled = true;
            this.gameSelector.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gameSelector.Location = new System.Drawing.Point(346, 517);
            this.gameSelector.Name = "gameSelector";
            this.gameSelector.Size = new System.Drawing.Size(121, 21);
            this.gameSelector.TabIndex = 13;
            this.gameSelector.SelectionChangeCommitted += new System.EventHandler(this.gameSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select a Game ---->";
            // 
            // IntroTextBox
            // 
            this.IntroTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IntroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntroTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IntroTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroTextBox.Location = new System.Drawing.Point(154, 77);
            this.IntroTextBox.Name = "IntroTextBox";
            this.IntroTextBox.ReadOnly = true;
            this.IntroTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.IntroTextBox.ShortcutsEnabled = false;
            this.IntroTextBox.Size = new System.Drawing.Size(494, 324);
            this.IntroTextBox.TabIndex = 15;
            this.IntroTextBox.Text = resources.GetString("IntroTextBox.Text");
            // 
            // TwitchBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.IntroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameSelector);
            this.Controls.Add(this.TwitchLogo);
            this.Controls.Add(this.Preview2Text);
            this.Controls.Add(this.Preview1Text);
            this.Controls.Add(this.Preview3Text);
            this.Controls.Add(this.Preview4Text);
            this.Controls.Add(this.PreviewImage3);
            this.Controls.Add(this.PreviewImage2);
            this.Controls.Add(this.PreviewImage1);
            this.Controls.Add(this.PreviewImage0);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TwitchBrowse";
            this.Text = "TwitchBrowse";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage0)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwitchLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviewImage0;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox PreviewImage1;
        private System.Windows.Forms.PictureBox PreviewImage2;
        private System.Windows.Forms.PictureBox PreviewImage3;
        private System.Windows.Forms.RichTextBox Preview4Text;
        private System.Windows.Forms.RichTextBox Preview3Text;
        private System.Windows.Forms.RichTextBox Preview1Text;
        private System.Windows.Forms.RichTextBox Preview2Text;
        private System.Windows.Forms.PictureBox TwitchLogo;
        private System.Windows.Forms.ComboBox gameSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.RichTextBox IntroTextBox;


    }
}

