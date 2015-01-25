namespace Stream_Browser
{
    partial class Configuration
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GeneralConfig = new System.Windows.Forms.GroupBox();
            this.StreamConfig = new System.Windows.Forms.TabPage();
            this.TwitchConfig = new System.Windows.Forms.GroupBox();
            this.UserConfig = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.StreamConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.StreamConfig);
            this.tabControl1.Controls.Add(this.UserConfig);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 430);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GeneralConfig);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 404);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "GeneralConfig";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GeneralConfig
            // 
            this.GeneralConfig.Location = new System.Drawing.Point(6, 6);
            this.GeneralConfig.Name = "GeneralConfig";
            this.GeneralConfig.Size = new System.Drawing.Size(268, 302);
            this.GeneralConfig.TabIndex = 4;
            this.GeneralConfig.TabStop = false;
            this.GeneralConfig.Text = "General";
            // 
            // StreamConfig
            // 
            this.StreamConfig.Controls.Add(this.TwitchConfig);
            this.StreamConfig.Location = new System.Drawing.Point(4, 22);
            this.StreamConfig.Name = "StreamConfig";
            this.StreamConfig.Padding = new System.Windows.Forms.Padding(3);
            this.StreamConfig.Size = new System.Drawing.Size(592, 404);
            this.StreamConfig.TabIndex = 0;
            this.StreamConfig.Text = "Stream Configuration";
            this.StreamConfig.UseVisualStyleBackColor = true;
            // 
            // TwitchConfig
            // 
            this.TwitchConfig.Location = new System.Drawing.Point(6, 6);
            this.TwitchConfig.Name = "TwitchConfig";
            this.TwitchConfig.Size = new System.Drawing.Size(285, 360);
            this.TwitchConfig.TabIndex = 2;
            this.TwitchConfig.TabStop = false;
            this.TwitchConfig.Text = "Twitch.TV";
            // 
            // UserConfig
            // 
            this.UserConfig.Location = new System.Drawing.Point(4, 22);
            this.UserConfig.Name = "UserConfig";
            this.UserConfig.Padding = new System.Windows.Forms.Padding(3);
            this.UserConfig.Size = new System.Drawing.Size(592, 372);
            this.UserConfig.TabIndex = 1;
            this.UserConfig.Text = "User Configuration";
            this.UserConfig.UseVisualStyleBackColor = true;
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.StreamConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StreamConfig;
        private System.Windows.Forms.TabPage UserConfig;
        private System.Windows.Forms.GroupBox TwitchConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox GeneralConfig;
    }
}