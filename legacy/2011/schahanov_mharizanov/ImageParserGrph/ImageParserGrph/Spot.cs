using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace ImageParserGrph
{
    class Spot
    {
        public List<Point> Points = new List<Point>();
        public Color Color = new Color();
        public Size Size = new Size();
        public Rectangle Rectangle = new Rectangle();
        public Spot() { }
        public Spot(List<Point> points, Color color)
        {
            Points = points;
            Color = color;
            CalculateSize();
        }
        void CalculateSize()
        {
            Point mostTop, mostBottom, mostLeft, mostRight;
            mostTop = mostRight = mostLeft = mostBottom = Point.Empty;
            foreach (Point p in Points)
            {
                if (mostTop == Point.Empty) mostTop = p;
                if (mostBottom == Point.Empty) mostTop = p;
                if (mostLeft == Point.Empty) mostTop = p;
                if (mostRight == Point.Empty) mostTop = p;
                if (p.Y < mostTop.Y) mostTop = p;
                if (p.Y > mostBottom.Y) mostBottom = p;
                if (p.X < mostLeft.X) mostLeft = p;
                if (p.X > mostRight.X) mostRight = p;
            }
            Size = new Size(mostRight.X - mostLeft.X, mostBottom.Y - mostTop.Y);
            Rectangle = new Rectangle(new Point(mostLeft.X, mostTop.Y), Size);
        }
    }
}
