using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PacmanFormative
{
    public partial class PacmanFormative : Form
    {
        public PacmanFormative()
        {
            InitializeComponent();
        }

        private void PacmanFormative_Click(object sender, EventArgs e)
        {
            // Graphics set up
            Graphics onScreenGraphics = this.CreateGraphics();
            Bitmap bm = new Bitmap(this.Width, this.Height); //bitmap area size of whole screen
            Graphics offScreenGraphics = Graphics.FromImage(bm); //Sets off-screen graphics to the bitmap

            Pen wallPen = new Pen(Color.Navy, 5);
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);

            SoundPlayer startSoundPlayer = new SoundPlayer(Properties.Resources.ufoTakeoff);
            startSoundPlayer.Play();
            Thread.Sleep(2000);

            SoundPlayer alarmPlayer = new SoundPlayer(Properties.Resources.fireAlarm);
            alarmPlayer.Play();

            for (int x = 2; x <= 110; x += 6) //Going right loop
            {

                // Drawing walls
                offScreenGraphics.DrawLine(wallPen, 0, 5, 150, 5);
                offScreenGraphics.DrawLine(wallPen, 0, 45, 105, 45);
                offScreenGraphics.DrawLine(wallPen, 148, 3, 148, 100);
                offScreenGraphics.DrawLine(wallPen, 102, 45, 102, 100);

                // Drawing Pacman
                offScreenGraphics.FillPie(pacBrush, x, 10, 30, 30, 30, 300);

                onScreenGraphics.DrawImage(bm, 0, 0);
                Thread.Sleep(200);
                offScreenGraphics.Clear(Color.Black);

                offScreenGraphics.DrawLine(wallPen, 0, 5, 150, 5);
                offScreenGraphics.DrawLine(wallPen, 0, 45, 105, 45);
                offScreenGraphics.DrawLine(wallPen, 148, 3, 148, 100);
                offScreenGraphics.DrawLine(wallPen, 102, 45, 102, 100);

                offScreenGraphics.FillPie(pacBrush, x, 10, 30, 30, 0, 360);

                onScreenGraphics.DrawImage(bm, 0, 0);
                Thread.Sleep(200);
                offScreenGraphics.Clear(Color.Black);
            }
            // Going down loop
            for (int x = 10; x <= 75; x += 6)
            {
                // Drawing Walls
                offScreenGraphics.DrawLine(wallPen, 0, 5, 150, 5);
                offScreenGraphics.DrawLine(wallPen, 0, 45, 105, 45);
                offScreenGraphics.DrawLine(wallPen, 148, 3, 148, 100);
                offScreenGraphics.DrawLine(wallPen, 102, 45, 102, 100);

                // Drawing Pacman
                offScreenGraphics.FillPie(pacBrush, 110, x, 30, 30, 120, 300);

                onScreenGraphics.DrawImage(bm, 0, 0);
                Thread.Sleep(200);
                offScreenGraphics.Clear(Color.Black);

                offScreenGraphics.DrawLine(wallPen, 0, 5, 150, 5);
                offScreenGraphics.DrawLine(wallPen, 0, 45, 105, 45);
                offScreenGraphics.DrawLine(wallPen, 148, 3, 148, 100);
                offScreenGraphics.DrawLine(wallPen, 102, 45, 102, 100);

                offScreenGraphics.FillPie(pacBrush, 110, x, 30, 30, 0, 360);

                onScreenGraphics.DrawImage(bm, 0, 0);
                Thread.Sleep(200);
                offScreenGraphics.Clear(Color.Black);

            }
            offScreenGraphics.DrawLine(wallPen, 0, 5, 150, 5);
            offScreenGraphics.DrawLine(wallPen, 0, 45, 105, 45);
            offScreenGraphics.DrawLine(wallPen, 148, 3, 148, 100);
            offScreenGraphics.DrawLine(wallPen, 102, 45, 102, 100);

            offScreenGraphics.FillPie(pacBrush, 110, 75, 30, 30, 120, 300);

            Font winFont = new Font("Arial", 26, FontStyle.Bold);
            SolidBrush winBrush = new SolidBrush(Color.Yellow);
            offScreenGraphics.DrawString("Congrulations", winFont, winBrush, 20, 100);

            onScreenGraphics.DrawImage(bm, 0, 0);
            Thread.Sleep(500);
        
            alarmPlayer.Stop();
        }
    }
}
