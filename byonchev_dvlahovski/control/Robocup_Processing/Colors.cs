using System;

namespace Robocup_Processing
{
    class RGBColorRange
    {
        public byte minRed, maxRed, minGreen, maxGreen, minBlue, maxBlue;

        public RGBColorRange()
        {
        }

        public RGBColorRange(byte minRed, byte maxRed, byte minGreen, byte maxGreen, byte minBlue, byte maxBlue)
        {
            this.minRed = minRed;
            this.maxRed = maxRed;
            this.minGreen = minGreen;
            this.maxGreen = maxGreen;
            this.minBlue = minBlue;
            this.maxBlue = maxBlue;
        }
    }

    public class HSLColor
    {
        /* Range [0; 359] */
        public int Hue;

        /* Range [0; 1] */
        public float Saturation;

        /* Range [0; 1] */
        public float Luminance;

        public HSLColor() {}

        public HSLColor(int Hue, float Saturation, float Luminance)
        {
            this.Hue = Hue;
            this.Saturation = Saturation;
            this.Luminance = Luminance;
        }

        public static HSLColor FromRGB(byte R, byte G, byte B)
        {
            HSLColor result = new HSLColor();

            float r = (R / 255.0f);
            float g = (G / 255.0f);
            float b = (B / 255.0f);

            float min = Math.Min(Math.Min(r, g), b);
            float max = Math.Max(Math.Max(r, g), b);
            float delta = max - min;

            result.Luminance = (max + min) / 2;

            /* Gray color */
            if (delta == 0)
            {
                result.Hue = 0;
                result.Saturation = 0.0f;
            }
            else
            {
                result.Saturation = (result.Luminance <= 0.5) ? (delta / (max + min)) : (delta / (2 - max - min));

                float hue;

                if (r == max)
                {
                    hue = ((g - b) / 6) / delta;
                }
                else if (g == max)
                {
                    hue = (1.0f / 3) + ((b - r) / 6) / delta;
                }
                else
                {
                    hue = (2.0f / 3) + ((r - g) / 6) / delta;
                }

                if (hue < 0)
                {
                    hue += 1;
                }
                else if (hue > 1)
                {
                    hue -= 1;
                }

                result.Hue = (int)(hue * 360);
            }

            return result;
        }
    }

    public class HSLColorRange
    {
        public int minHue, maxHue;
        public float minSaturation, maxSaturation;
        public float minLuminance, maxLuminance;

        public HSLColorRange() {}

        public HSLColorRange(int minHue, int maxHue, float minSaturation, float maxSaturation, float minLuminance, float maxLuminance)
        {
            this.minHue = minHue;
            this.maxHue = maxHue;
            this.minSaturation = minSaturation;
            this.maxSaturation = maxSaturation;
            this.minLuminance = minLuminance;
            this.maxLuminance = maxLuminance;
        }
    }
}
