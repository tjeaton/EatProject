﻿namespace EatonProjection
{
    partial class lyricsForm
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
            this.lyricsBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lyricsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lyricsBox
            // 
            this.lyricsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lyricsBox.Image = global::EatonProjection.Properties.Resources.bg;
            this.lyricsBox.Location = new System.Drawing.Point(0, 0);
            this.lyricsBox.Name = "lyricsBox";
            this.lyricsBox.Size = new System.Drawing.Size(1280, 720);
            this.lyricsBox.TabIndex = 0;
            this.lyricsBox.TabStop = false;
            // 
            // lyricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lyricsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lyricsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lyricsForm";
            ((System.ComponentModel.ISupportInitialize)(this.lyricsBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lyricsBox;
    }
}