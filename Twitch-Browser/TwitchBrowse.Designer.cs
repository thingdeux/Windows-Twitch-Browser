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
            this.CallAPIButton = new System.Windows.Forms.Button();
            this.PreviewImage1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewImage2 = new System.Windows.Forms.PictureBox();
            this.PreviewImage3 = new System.Windows.Forms.PictureBox();
            this.PreviewImage4 = new System.Windows.Forms.PictureBox();
            this.Preview4Text = new System.Windows.Forms.RichTextBox();
            this.Preview3Text = new System.Windows.Forms.RichTextBox();
            this.Preview1Text = new System.Windows.Forms.RichTextBox();
            this.Preview2Text = new System.Windows.Forms.RichTextBox();
            this.TwitchLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwitchLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // CallAPIButton
            // 
            this.CallAPIButton.Location = new System.Drawing.Point(45, 507);
            this.CallAPIButton.Name = "CallAPIButton";
            this.CallAPIButton.Size = new System.Drawing.Size(78, 31);
            this.CallAPIButton.TabIndex = 1;
            this.CallAPIButton.Text = "Call API";
            this.CallAPIButton.UseVisualStyleBackColor = true;
            this.CallAPIButton.Click += new System.EventHandler(this.callAPI_Click);
            // 
            // PreviewImage1
            // 
            this.PreviewImage1.ErrorImage = null;
            this.PreviewImage1.InitialImage = null;
            this.PreviewImage1.Location = new System.Drawing.Point(45, 27);
            this.PreviewImage1.Name = "PreviewImage1";
            this.PreviewImage1.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage1.TabIndex = 2;
            this.PreviewImage1.TabStop = false;
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
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // PreviewImage2
            // 
            this.PreviewImage2.ErrorImage = null;
            this.PreviewImage2.InitialImage = null;
            this.PreviewImage2.Location = new System.Drawing.Point(429, 27);
            this.PreviewImage2.Name = "PreviewImage2";
            this.PreviewImage2.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage2.TabIndex = 5;
            this.PreviewImage2.TabStop = false;
            // 
            // PreviewImage3
            // 
            this.PreviewImage3.ErrorImage = null;
            this.PreviewImage3.InitialImage = null;
            this.PreviewImage3.Location = new System.Drawing.Point(45, 257);
            this.PreviewImage3.Name = "PreviewImage3";
            this.PreviewImage3.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage3.TabIndex = 6;
            this.PreviewImage3.TabStop = false;
            // 
            // PreviewImage4
            // 
            this.PreviewImage4.ErrorImage = null;
            this.PreviewImage4.InitialImage = null;
            this.PreviewImage4.Location = new System.Drawing.Point(429, 257);
            this.PreviewImage4.Name = "PreviewImage4";
            this.PreviewImage4.Size = new System.Drawing.Size(320, 200);
            this.PreviewImage4.TabIndex = 7;
            this.PreviewImage4.TabStop = false;
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
            // TwitchBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.TwitchLogo);
            this.Controls.Add(this.Preview2Text);
            this.Controls.Add(this.Preview1Text);
            this.Controls.Add(this.Preview3Text);
            this.Controls.Add(this.Preview4Text);
            this.Controls.Add(this.PreviewImage4);
            this.Controls.Add(this.PreviewImage3);
            this.Controls.Add(this.PreviewImage2);
            this.Controls.Add(this.PreviewImage1);
            this.Controls.Add(this.CallAPIButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TwitchBrowse";
            this.Text = "TwitchBrowse";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwitchLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CallAPIButton;
        private System.Windows.Forms.PictureBox PreviewImage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox PreviewImage2;
        private System.Windows.Forms.PictureBox PreviewImage3;
        private System.Windows.Forms.PictureBox PreviewImage4;
        private System.Windows.Forms.RichTextBox Preview4Text;
        private System.Windows.Forms.RichTextBox Preview3Text;
        private System.Windows.Forms.RichTextBox Preview1Text;
        private System.Windows.Forms.RichTextBox Preview2Text;
        private System.Windows.Forms.PictureBox TwitchLogo;


    }
}

