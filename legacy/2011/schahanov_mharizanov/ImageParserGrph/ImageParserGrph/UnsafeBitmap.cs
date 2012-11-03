using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
namespace ImageParserGrph
{
    class UnsafeBitmap
    {
        private bool isLocked = false;
        private Bitmap internalBitmap;
        private BitmapData bitmapData;
        private int PixelSize = 3;
        public UnsafeBitmap(Bitmap bitmap)
        {
            internalBitmap = bitmap;
        }
        public Bitmap SafeBitmap
        {
            get
            {
                return internalBitmap;
            }
        }
        public UnsafeBitmap(int x, int y)
        {
            internalBitmap = new Bitmap(x, y);
        }
        public void Dispose()
        {
            UnlockBits();
            internalBitmap.Dispose();
        }
        public UnsafeBitmap(int x, int y, PixelFormat format)
        {
            internalBitmap = new Bitmap(x, y, format);
        }
        public void LockBits()
        {
            bitmapData = internalBitmap.LockBits(new Rectangle(0, 0, internalBitmap.Width, internalBitmap.Height),
                                  System.Drawing.Imaging.ImageLockMode.ReadWrite,
                                  internalBitmap.PixelFormat);

            if (bitmapData != null) isLocked = true;
        }
        public void UnlockBits()
        {
            if (isLocked)
            {
                internalBitmap.UnlockBits(bitmapData);
                isLocked = false;
            }
        }
        public unsafe Color GetPixel(int x, int y)
        {
            if (x < 0 || y < 0) return Color.White;
            byte* row = (byte*)bitmapData.Scan0 + (y * bitmapData.Stride);
            int b = row[x * PixelSize];
            int g = row[x * PixelSize + 1];
            int r = row[x * PixelSize + 2];
            return Color.FromArgb(r, g, b);
        }
        public unsafe void SetPixel(int x, int y, Color color)
        {
            byte* row = (byte*)bitmapData.Scan0 + (y * bitmapData.Stride);
            row[x * PixelSize] = color.B;
            row[x * PixelSize + 1] = color.G;
            row[x * PixelSize + 2] = color.R;
        }
        
    }
}
