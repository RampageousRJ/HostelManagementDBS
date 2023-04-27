﻿namespace HostelManagement
{
    partial class MessAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessAdmin));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.profileicon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.issuelabel = new System.Windows.Forms.Label();
            this.roomchangeicon = new System.Windows.Forms.PictureBox();
            this.messchangeicon = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomchangeicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messchangeicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::HostelManagement.Properties.Resources.stats_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(77, 552);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 84);
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // profileicon
            // 
            this.profileicon.BackColor = System.Drawing.Color.Transparent;
            this.profileicon.BackgroundImage = global::HostelManagement.Properties.Resources.profile_icon;
            this.profileicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileicon.Location = new System.Drawing.Point(90, 98);
            this.profileicon.Name = "profileicon";
            this.profileicon.Size = new System.Drawing.Size(61, 58);
            this.profileicon.TabIndex = 86;
            this.profileicon.TabStop = false;
            this.profileicon.Click += new System.EventHandler(this.profileicon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(83, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 5);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // issuelabel
            // 
            this.issuelabel.AutoSize = true;
            this.issuelabel.BackColor = System.Drawing.Color.Transparent;
            this.issuelabel.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuelabel.Location = new System.Drawing.Point(73, 392);
            this.issuelabel.Name = "issuelabel";
            this.issuelabel.Size = new System.Drawing.Size(101, 19);
            this.issuelabel.TabIndex = 84;
            this.issuelabel.Text = "Mess Change";
            // 
            // roomchangeicon
            // 
            this.roomchangeicon.BackColor = System.Drawing.Color.Transparent;
            this.roomchangeicon.BackgroundImage = global::HostelManagement.Properties.Resources.roomchange_icon;
            this.roomchangeicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roomchangeicon.Location = new System.Drawing.Point(90, 262);
            this.roomchangeicon.Name = "roomchangeicon";
            this.roomchangeicon.Size = new System.Drawing.Size(61, 58);
            this.roomchangeicon.TabIndex = 83;
            this.roomchangeicon.TabStop = false;
            this.roomchangeicon.Click += new System.EventHandler(this.roomchangeicon_Click);
            // 
            // messchangeicon
            // 
            this.messchangeicon.BackColor = System.Drawing.Color.Transparent;
            this.messchangeicon.BackgroundImage = global::HostelManagement.Properties.Resources.messchange_icon;
            this.messchangeicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.messchangeicon.Location = new System.Drawing.Point(90, 414);
            this.messchangeicon.Name = "messchangeicon";
            this.messchangeicon.Size = new System.Drawing.Size(61, 58);
            this.messchangeicon.TabIndex = 82;
            this.messchangeicon.TabStop = false;
            this.messchangeicon.Click += new System.EventHandler(this.messchangeicon_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(471, 73);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(284, 167);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 88;
            this.pictureBox6.TabStop = false;
            // 
            // MessAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HostelManagement.Properties.Resources.adminmesschange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 745);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.profileicon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.issuelabel);
            this.Controls.Add(this.roomchangeicon);
            this.Controls.Add(this.messchangeicon);
            this.DoubleBuffered = true;
            this.Name = "MessAdmin";
            this.Text = "A3";
            this.Load += new System.EventHandler(this.MessAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomchangeicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messchangeicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox profileicon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label issuelabel;
        private System.Windows.Forms.PictureBox roomchangeicon;
        private System.Windows.Forms.PictureBox messchangeicon;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}