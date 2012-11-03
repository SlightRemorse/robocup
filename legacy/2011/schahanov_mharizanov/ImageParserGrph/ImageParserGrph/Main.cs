using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
namespace ImageParserGrph
{
    public partial class Main : Form
    {
        int checkDistance = 10;
        public Main()
        {
            InitializeComponent();
        }
        bool CloseTo(Color which, Color to)
        {
            if ((Math.Abs(which.R - to.R) < 100) && (Math.Abs(which.G - to.G) < 100) && (Math.Abs(which.B - to.B) < 100))
            {
                return true;
            }
            return false;
        }
        bool PointNearby(Point center, UnsafeBitmap bmp, Rectangle boundRect, Color objectColor)
        {
            Point p = new Point(center.X, center.Y - 1);//up
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            p = new Point(center.X + 1, center.Y - 1);//upright
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            p = new Point(center.X + 1, center.Y);//right
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            p = new Point(center.X + 1, center.Y + 1);//downright
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            p = new Point(center.X, center.Y + 1); //down
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            p = new Point(center.X - 1, center.Y + 1); //downleft
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            p = new Point(center.X - 1, center.Y); //left
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            p = new Point(center.X - 1, center.Y - 1); //upleft
            if (boundRect.Contains(p))
                if (CloseTo(bmp.GetPixel(p.X, p.Y), objectColor)) return true;

            return false;
        }
        bool IsPointValid(Point p, Color objectColor, UnsafeBitmap bmp, Rectangle boundRect, Point last)
        {
            if (!boundRect.Contains(p)) return false; //is the point in the image?
            Color pCol = bmp.GetPixel(p.X, p.Y);
            if (CloseTo(pCol, objectColor)) return false; //is the point on the object?
            if (p == last) return false;
            if (PointNearby(p, bmp, boundRect, objectColor)) return true; //is the point next to the object?
            return false;//not next to the object, die.
        }
        List<Point> FindBorders(Point p, Color objectColor, UnsafeBitmap bmp)
        {
            List<Point> checkedPoints = new List<Point>();
            Point current = p;
            Point start = p;
            Point last = new Point(-1, -1);
            Rectangle boundRect = new Rectangle(0, 0, bmp.SafeBitmap.Width, bmp.SafeBitmap.Height);
            int i = 0;
            bool overflow = false;
            do
            {
                i++;
                if (i >= 5000)
                {
                    overflow = true;
                    break;
                }
                //bmp.SetPixel(current.X, current.Y, Color.Black);
                Point rightp = new Point(current.X + 1, current.Y);
                Point leftp = new Point(current.X - 1, current.Y);
                Point upp = new Point(current.X, current.Y - 1);
                Point downp = new Point(current.X, current.Y + 1);
                if (current.X == start.X && current.Y == start.Y && i > 1)
                {
                    break;
                }
                if (IsPointValid(upp, objectColor, bmp, boundRect, last))
                {
                    last = current;
                    current = upp;
                    checkedPoints.Add(upp);
                    continue;
                }
                else if (IsPointValid(leftp, objectColor, bmp, boundRect, last))
                {
                    last = current;
                    current = leftp;
                    checkedPoints.Add(leftp);
                    continue;
                }
                else if (IsPointValid(downp, objectColor, bmp, boundRect, last))
                {
                    last = current;
                    current = downp;
                    checkedPoints.Add(downp);
                    continue;
                }
                else if (IsPointValid(rightp, objectColor, bmp, boundRect, last))
                {
                    last = current;
                    current = rightp;
                    checkedPoints.Add(rightp);
                    continue;
                }

            } while (current != start);
            if (!overflow)
            {
                return checkedPoints;
            }
            else
            {
                return new List<Point>();
            }
        }
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string filename = txtPath.Text;
            Color red = Color.White;
            Bitmap img = (Bitmap)Image.FromFile(filename);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<Rectangle> rects;
            UnsafeBitmap uBtm;
            GetRectangles(img, out rects, out uBtm);
            sw.Stop();
            Graphics g = Graphics.FromImage(uBtm.SafeBitmap);
            g.DrawRectangles(Pens.Black, rects.ToArray());
            StringBuilder b = new StringBuilder();
            b.AppendLine("Objects found: ("+ sw.ElapsedMilliseconds.ToString() +"ms.)");
            foreach (Rectangle r in rects)
            {
                b.AppendLine(r.ToString());
            }
            g.DrawString(b.ToString(), new System.Drawing.Font("Arial", 10), Brushes.Black, new PointF(5, 5));
            uBtm.SafeBitmap.Save("C:/output.png", ImageFormat.Png);
            this.Text = sw.ElapsedMilliseconds.ToString();
            pbImage.Image = (Bitmap)uBtm.SafeBitmap.Clone();
            uBtm.Dispose();
            MessageBox.Show(b.ToString());
        }

        private void GetRectangles(Bitmap img, out List<Rectangle> rects, out UnsafeBitmap uBtm)
        {
            Rectangle boundRect = new Rectangle(0, 0, img.Width, img.Height);
            rects = new List<Rectangle>();

            uBtm = new UnsafeBitmap(img);
            int w = img.Width;
            int h = img.Height;
            uBtm.LockBits();
            List<Point> points = new List<Point>();
            for (int i = 0; i < 1; i++)
            {
                for (int y = 0; y < h; y += 20)
                {
                    for (int x = 0; x < w; x += 20)
                    {
                        Color c = uBtm.GetPixel(x, y);
                        if (CloseTo(c, Color.FromArgb(0, 255, 0)) || CloseTo(c, Color.Blue) || CloseTo(c, Color.Red) || CloseTo(c, Color.Black))
                        {
                            int newx = x;
                            int newy = y;
                            while (true)
                            {
                                newx = newx - 1;
                                newy = newy - 1;
                                Color newc = uBtm.GetPixel(newx, newy);
                                if (!boundRect.Contains(newx, newy))
                                {
                                    break;
                                }
                                if (!CloseTo(newc, c))
                                {
                                    Point newp = new Point(newx, newy);
                                    bool pointExists = false;
                                    foreach (Rectangle r in rects)
                                    {
                                        if (r.Contains(newp))
                                        {
                                            pointExists = true;
                                            break;
                                        }
                                    }
                                    if (pointExists)
                                    {
                                        break;
                                    }
                                    points = FindBorders(newp, c, uBtm);
                                    if (points.Count == 0) break;
                                    Point top, bottom, left, right;
                                    top = bottom = left = right = points[0];

                                    foreach (Point p in points)
                                    {
                                        if (p.Y < top.Y) top = p;
                                        if (p.Y > bottom.Y) bottom = p;
                                        if (p.X < left.X) left = p;
                                        if (p.X > right.X) right = p;
                                    }
                                    Rectangle rect = new Rectangle(left.X, top.Y, right.X - left.X, bottom.Y - top.Y);
                                    rects.Add(rect);
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            uBtm.UnlockBits();
        }
        void displayImage(Bitmap img)
        {
            //Bitmap bmp = new Bitmap(img.Width, img.Height, PixelFormat.Format24bppRgb);
            //Graphics g = Graphics.FromImage(bmp);
            //g.Clear(Color.White);
            //List<Rectangle> drawRects = new List<Rectangle>();
            //for(int i = 0; i<spots.GetLength(0);i++)
            //{
            //    for (int j = 0; j < spots.GetLength(1); j++)
            //    {
            //        g.FillRectangle(new SolidBrush(spots[i,j]), new Rectangle(i*checkDistance, j*checkDistance, checkDistance,checkDistance));
            //    }
            //}
            //pbImage.Image = bmp;
        }

    }
}
