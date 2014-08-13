namespace EatonProjection
{
    partial class Form1
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
            this.btnShowBG = new System.Windows.Forms.Button();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.txtVUrl = new System.Windows.Forms.TextBox();
            this.btnStopBG = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.btnShowTxt = new System.Windows.Forms.Button();
            this.nxtLyric = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowBG
            // 
            this.btnShowBG.Location = new System.Drawing.Point(104, 41);
            this.btnShowBG.Name = "btnShowBG";
            this.btnShowBG.Size = new System.Drawing.Size(75, 23);
            this.btnShowBG.TabIndex = 0;
            this.btnShowBG.Text = "Play Video";
            this.btnShowBG.UseVisualStyleBackColor = true;
            this.btnShowBG.Click += new System.EventHandler(this.btnShowBG_Click);
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.Location = new System.Drawing.Point(12, 45);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(86, 17);
            this.chkLoop.TabIndex = 2;
            this.chkLoop.Text = "Loop Video?";
            this.chkLoop.UseVisualStyleBackColor = true;
            // 
            // txtVUrl
            // 
            this.txtVUrl.Location = new System.Drawing.Point(12, 15);
            this.txtVUrl.Name = "txtVUrl";
            this.txtVUrl.Size = new System.Drawing.Size(646, 20);
            this.txtVUrl.TabIndex = 3;
            this.txtVUrl.Text = "C:\\\\Users\\\\Tom\\\\Desktop\\\\def1.mp4";
            // 
            // btnStopBG
            // 
            this.btnStopBG.Location = new System.Drawing.Point(185, 41);
            this.btnStopBG.Name = "btnStopBG";
            this.btnStopBG.Size = new System.Drawing.Size(75, 23);
            this.btnStopBG.TabIndex = 4;
            this.btnStopBG.Text = "Stop Video";
            this.btnStopBG.UseVisualStyleBackColor = true;
            this.btnStopBG.Click += new System.EventHandler(this.btnStopBG_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(266, 46);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(12, 84);
            this.txtOne.Multiline = true;
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(646, 20);
            this.txtOne.TabIndex = 6;
            this.txtOne.Text = "LineOne\\r\\nLineTwo";
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(12, 110);
            this.txtTwo.Multiline = true;
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(646, 20);
            this.txtTwo.TabIndex = 7;
            this.txtTwo.Text = "LineThree\\r\\nLineFour";
            this.txtTwo.TextChanged += new System.EventHandler(this.txtTwo_TextChanged);
            // 
            // btnShowTxt
            // 
            this.btnShowTxt.Location = new System.Drawing.Point(12, 136);
            this.btnShowTxt.Name = "btnShowTxt";
            this.btnShowTxt.Size = new System.Drawing.Size(75, 23);
            this.btnShowTxt.TabIndex = 8;
            this.btnShowTxt.Text = "Show Text";
            this.btnShowTxt.UseVisualStyleBackColor = true;
            this.btnShowTxt.Click += new System.EventHandler(this.btnShowTxt_Click);
            // 
            // nxtLyric
            // 
            this.nxtLyric.Location = new System.Drawing.Point(93, 136);
            this.nxtLyric.Name = "nxtLyric";
            this.nxtLyric.Size = new System.Drawing.Size(75, 23);
            this.nxtLyric.TabIndex = 9;
            this.nxtLyric.Text = "Next Lyric";
            this.nxtLyric.UseVisualStyleBackColor = true;
            this.nxtLyric.Click += new System.EventHandler(this.nxtLyric_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Lyric";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(93, 165);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open Lyric";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(338, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 180);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nxtLyric);
            this.Controls.Add(this.btnShowTxt);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStopBG);
            this.Controls.Add(this.txtVUrl);
            this.Controls.Add(this.chkLoop);
            this.Controls.Add(this.btnShowBG);
            this.Name = "Form1";
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBG;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.TextBox txtVUrl;
        private System.Windows.Forms.Button btnStopBG;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.Button btnShowTxt;
        private System.Windows.Forms.Button nxtLyric;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

