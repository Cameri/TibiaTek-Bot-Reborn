using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TibiaTekBot
{
    public partial class LagBarForm : Form
    {

        public Tibia client;
        private bool dragging = false;
        private Point dif = new Point(0, 0);

        public LagBarForm(Tibia client)
        {
            this.client = client;

            InitializeComponent();
            Label2.Capture = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            lagBarTimer.Stop();
            Hide();
        }

        private void LagBarForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                lagBarTimer.Start();
            } else
            {
                lagBarTimer.Stop();
            }
        }

        private void lagBarTimer_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                if (lagBarTimer.Interval != 10000)
                {
                    lagBarTimer.Interval = 10000;
                }
                //if (lagBarTimer)
                if (!client.IsConnected)
                {
                    PictureBox1.Size = new Size(0, 9);
                    Label2.Text = "N/C";
                    Label2.ForeColor = Color.White;
                    return;
                }

                DateTime startTime = DateTime.Now;
                DateTime timeout = startTime.AddSeconds(9);
                long elapsed = 0;
                try
                {
                    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    s.Connect(new System.Net.IPAddress(0x37C0E736), 80);
                    while (!s.Connected)
                    {
                        if (DateTime.Now > timeout)
                        {
                            Label2.Text = "+5000 ms"; ;
                            return;
                        }
                        System.Threading.Thread.Sleep(0);
                    }
                    elapsed = (long)(DateTime.Now - startTime).TotalMilliseconds;
                    if (s.Connected)
                    {
                        s.Close();
                    }
                }
                catch (SocketException ex)
                {

                }

                Label2.Text = elapsed + " ms";
                if (elapsed <= 200)
                {
                    Label2.ForeColor = Color.Lime;
                }
                else if (elapsed <= 300)
                {
                    Label2.ForeColor = Color.Yellow;
                }
                else if (elapsed <= 400)
                {
                    Label2.ForeColor = Color.Orange;
                }
                else if (elapsed <= 500)
                {
                    Label2.ForeColor = Color.DarkOrange;
                }
                else
                {
                    Label2.ForeColor = Color.Red;
                }

                PictureBox1.Size = new Size((int)Math.Max(0, Math.Min(88, elapsed * 88 / 500)), 9);
            }
        }

        private void LagBarForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > 25 && e.Y < 32 && e.X > 85 && e.X < 95)
            {
                return;
            }
            ((Control)sender).Capture = false;
            dragging = true;
            
            dif = Point.Subtract(Location, new Size(Cursor.Position));
        }

        private void LagBarForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Location = Point.Add(Cursor.Position, new Size(dif));
            }
        }

        private void LagBarForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void LagBarForm_Load(object sender, EventArgs e)
        {
          
        }

        private void LagBarForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            this.Hide();
            this.Parent = null;
           

        }
    }
}
