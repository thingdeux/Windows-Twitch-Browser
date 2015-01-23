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
            this.RespDisplay = new System.Windows.Forms.RichTextBox();
            this.CallAPIButton = new System.Windows.Forms.Button();
            this.Main_Stream_Picture = new System.Windows.Forms.PictureBox();
            this.Main_Stream_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Stream_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // RespDisplay
            // 
            this.RespDisplay.Location = new System.Drawing.Point(45, 54);
            this.RespDisplay.Name = "RespDisplay";
            this.RespDisplay.Size = new System.Drawing.Size(308, 405);
            this.RespDisplay.TabIndex = 0;
            this.RespDisplay.Text = "";
            // 
            // CallAPIButton
            // 
            this.CallAPIButton.Location = new System.Drawing.Point(45, 489);
            this.CallAPIButton.Name = "CallAPIButton";
            this.CallAPIButton.Size = new System.Drawing.Size(78, 31);
            this.CallAPIButton.TabIndex = 1;
            this.CallAPIButton.Text = "Call API";
            this.CallAPIButton.UseVisualStyleBackColor = true;
            this.CallAPIButton.Click += new System.EventHandler(this.callAPI_Click);
            // 
            // Main_Stream_Picture
            // 
            this.Main_Stream_Picture.ErrorImage = null;
            this.Main_Stream_Picture.InitialImage = null;
            this.Main_Stream_Picture.Location = new System.Drawing.Point(406, 54);
            this.Main_Stream_Picture.Name = "Main_Stream_Picture";
            this.Main_Stream_Picture.Size = new System.Drawing.Size(320, 200);
            this.Main_Stream_Picture.TabIndex = 2;
            this.Main_Stream_Picture.TabStop = false;
            // 
            // Main_Stream_Title
            // 
            this.Main_Stream_Title.AutoSize = true;
            this.Main_Stream_Title.Location = new System.Drawing.Point(522, 267);
            this.Main_Stream_Title.Name = "Main_Stream_Title";
            this.Main_Stream_Title.Size = new System.Drawing.Size(95, 13);
            this.Main_Stream_Title.TabIndex = 3;
            this.Main_Stream_Title.Text = "Main_Stream_Title";
            this.Main_Stream_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TwitchBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Main_Stream_Title);
            this.Controls.Add(this.Main_Stream_Picture);
            this.Controls.Add(this.CallAPIButton);
            this.Controls.Add(this.RespDisplay);
            this.Name = "TwitchBrowse";
            this.Text = "TwitchBrowse";
            ((System.ComponentModel.ISupportInitialize)(this.Main_Stream_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RespDisplay;
        private System.Windows.Forms.Button CallAPIButton;
        private System.Windows.Forms.PictureBox Main_Stream_Picture;
        private System.Windows.Forms.Label Main_Stream_Title;


    }
}

