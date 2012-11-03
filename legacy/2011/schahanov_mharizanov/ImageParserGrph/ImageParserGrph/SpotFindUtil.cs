using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
namespace ImageParserGrph
{
    class SpotFindUtil
    {
        static List<Point> pointsFound = new List<Point>();
        static bool[,] forbidden;
        static Color BaseColor;
        static Color[,] bitmap;
        public static Main main;
        static PointComparer pointComparer = new PointComparer();
        static BitmapData bitmapData;
        public static List<Point> GetSpot(Color[,] img, Point origin, Color baseColor)
        {
            bitmap = img;
            BaseColor = baseColor;
            forbidden = new bool[img.GetLength(0), img.GetLength(1)];
            CheckPoint(origin);
            return pointsFound;
        }
        static void CheckPoint(Point point)
        {
            main.Text = point.ToString();
            if (!IsPointAllowed(point))
            {
                return;
            }
            forbidden[point.X, point.Y] = true;
            pointsFound.Add(point);
            CheckPoint(new Point(point.X - 1, point.Y));
            CheckPoint(new Point(point.X + 1, point.Y));
            CheckPoint(new Point(point.X, point.Y + 1));
            CheckPoint(new Point(point.X, point.Y - 1));
            
        }
        static bool IsPointWithinBounds(Point point)
        {
            if (point.X < bitmap.GetLength(0) && point.Y < bitmap.GetLength(1) && point.X >= 0 && point.Y >= 0)
            {
                return true;
            }
            return false;
        }
        static unsafe bool IsColorValid(Point point)
        {
            Color c = bitmap[point.X, point.Y];
            
            if (IsColorCloseToBase(c.R, c.G, c.B)) return true;
            return false;
        }
        static bool IsColorCloseToBase(int R, int G, int B)
        {
            if (R >= (BaseColor.R - 30) && R <= (BaseColor.R + 30) &&
                G >= (BaseColor.G - 30) && G <= (BaseColor.G + 30) &&
                B >= (BaseColor.B - 30) && B <= (BaseColor.B + 30))
                return true;
            return false;
        }
        static bool IsPointAllowed(Point point)
        {
            if (IsPointWithinBounds(point) && IsColorValid(point))
            {
                if (forbidden[point.X, point.Y] == false) return true;
            }
            return false;
        }
    }
    class PointComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point a, Point b)
        {
            if ((a.X == b.X) && (a.Y == b.Y)) return true;
            return false;
        }
        public int GetHashCode(Point point)
        {
            return point.GetHashCode();
        }

    }
}
