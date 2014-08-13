using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace EatonProjection
{
    public partial class backgroundForm : Form
    {
        Video video;
        bool loopVid = false;
        bool playingVid = false;

        public backgroundForm()
        {
            InitializeComponent();

            this.TopMost = false;
        }

        public void initVideo(bool rData, string vtDraw)
        {
            if (playingVid)
            {
                video.Stop();
                loopVid = rData;

                videoArea.Dock = DockStyle.None;

                video = new Video(vtDraw, false);
                video.Owner = videoArea;

                videoArea.Dock = DockStyle.Fill;
                video.Play();
                playingVid = true;
                video.Ending += new EventHandler(videoLoop);

                this.Refresh();
            }
            else
            {
                loopVid = rData;

                videoArea.Dock = DockStyle.None;

                video = new Video(vtDraw, false);
                video.Owner = videoArea;

                videoArea.Dock = DockStyle.Fill;
                video.Play();
                playingVid = true;
                video.Ending += new EventHandler(videoLoop);

                this.Refresh();
            }
            

        }
        private void videoLoop(object sender, EventArgs e)
        {
            if (loopVid)
            {
                video.CurrentPosition = 0;
            }
            else
            {
                video.Stop();
                
            }
        }

        public void stopVideo(bool stopV)
        {
            if (stopV)
            {
                video.Stop();
            }
        }
    }
}
