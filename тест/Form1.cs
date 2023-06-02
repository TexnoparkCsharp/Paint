using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Drawing.Imaging;

namespace тест
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Width = 1000;
            Height = 1000;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        WindowsMediaPlayer ddd = new WindowsMediaPlayer();
        ColorDialog ghg = new ColorDialog();
        Color new_Color;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sx, sy, cx, cy;
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - cx;
            sy = y - cy;
            
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
            if (index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if(index == 5)
            {
                g.DrawLine(p, cx, cy, x, y);
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {

                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;

                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
                
            }
            pic.Refresh();
            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
           Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);

                }

                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }
        }

        private void circle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void colour_Click(object sender, EventArgs e)
        {
            ghg.ShowDialog();
            new_Color = ghg.Color;
            pic_color.BackColor = ghg.Color;
            p.Color = ghg.Color;
        }

        private void pencil_Click(object sender, EventArgs e)
        {
            index = 1;
            
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x , int y, Color old_color,Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_Color);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_Color);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_Color);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_Color);
                }
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(pictureBox1, e.Location);
            pic_color.BackColor=((Bitmap)pictureBox1.Image).GetPixel(point.X, point.Y);
            new_Color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }

        private void fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index==7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_Color);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg|*.jpg|(*.*|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Saved");
            }
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        float floa;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            floa = float.Parse(numericUpDown1.Value.ToString());
            erase.Width = floa;
            p.Width = floa;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cx = e.X;
            cy = e.Y;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f*pb.Image.Width/pb.Width;
            float pY = 1f*pb.Image.Height/pb.Height;
            return new Point((int)(pt.X*pX),(int)(pt.Y*pY));
        }
    }
}
