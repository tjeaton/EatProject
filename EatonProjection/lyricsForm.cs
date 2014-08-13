using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatonProjection
{
    public partial class lyricsForm : Form
    {
        Graphics g;
        bool vis = false;

        public lyricsForm()
        {
            InitializeComponent();

            BackColor = Color.DimGray;
            TransparencyKey = Color.DimGray;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.TopMost = true;

        }

        public void drawText(string rData)
        {
            g = Graphics.FromImage(lyricsBox.Image);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;

            g.DrawString(rData, new Font("Tahoma", 28), Brushes.Black, new RectangleF(0, 106, 1282, 0), strFormat);
            g.DrawString(rData, new Font("Tahoma", 28), Brushes.Black, new RectangleF(0, 103, 1279, 0), strFormat);
            g.DrawString(rData, new Font("Tahoma", 28), Brushes.White, new RectangleF(0, 104, 1280, 0), strFormat);

            vis = true;
            this.Refresh();
        }

        public void clrText(bool clearIt)
        {
            if (vis)
            {
                g.Clear(Color.DimGray);
                g.Dispose();
                this.Refresh();
            }
            else
            {
                this.Refresh();
            }

        }

    }
}
