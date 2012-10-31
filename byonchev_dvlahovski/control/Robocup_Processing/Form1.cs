using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;

namespace Robocup_Processing
{
    public partial class Form1 : Form
    {
        private VideoCaptureDevice videoSource = null;
        private FilterInfoCollection videoDevices = null;
        private static Size VIDEO_RESOLUTION = new Size(640, 480);
        private const int VIDEO_MAX_FRAMERATE = 10;

        private Bitmap image;
        private Bitmap processedImage;

        private bool[,] binaryImage = new bool[VIDEO_RESOLUTION.Width, VIDEO_RESOLUTION.Height];

        private HSLColorRange debugRange;

        private HSLColorRange frontRange;
        private HSLColorRange backRange;
        private HSLColorRange ballRange;

        private bool showProcessed = false;
        private bool debugMode = true;

        private Graphics debugGraphics;
        private Pen debugPen = new Pen(Color.FromArgb(0, 0, 0), 5);

        private bool noiseFilterEnabled = false;
        private int noiseFilterRadius = 0;
        private int noiseFilterThreshold = 0;

        public Form1()
        {
            InitializeComponent();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                camerasList.Enabled = false;
            }
            else
            {
                foreach (FilterInfo i in videoDevices)
                {
                    camerasList.Items.Add(i.Name);
                }

                camerasList.SelectedIndex = 0;
            }
        }


        private void video_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = eventArgs.Frame;

            image = (Bitmap)frame.Clone();

            if (debugMode)
            {
                debugGraphics = Graphics.FromImage(image);
                updateDebugImage();
            }
        }


        private void updateDebugImage()
        {
            processedImage = image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);

            BitmapData bmpData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bmpData2 = processedImage.LockBits(new Rectangle(0, 0, image.Width, image.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            int leftPoint = image.Width,
               rightPoint = 0,
               topPoint = image.Height,
               bottomPoint = 0;
 
            unsafe
            {
                byte* ptr = (byte*)bmpData.Scan0.ToPointer();
                byte* ptr2 = (byte*)bmpData2.Scan0.ToPointer();
                
                int offset = bmpData.Stride - bmpData.Width * 3;

                for (int y = 0; y < bmpData.Height; ++y)
                {
                    for (int x = 0; x < bmpData.Width; ++x)
                    {
                        /*
                        B = ptr[0];
                        G = ptr[1];
                        R = ptr[2];
                        */

                        HSLColor color = HSLColor.FromRGB(ptr[2], ptr[1], ptr[0]);

                        if ((color.Hue >= debugRange.minHue) && (color.Hue <= debugRange.maxHue) && (color.Saturation >= debugRange.minSaturation) && (color.Saturation <= debugRange.maxSaturation) && (color.Luminance >= debugRange.minLuminance) && (color.Luminance <= debugRange.maxLuminance))                        
                        {
                            if (noiseFilterEnabled)
                            {
                                binaryImage[x, y] = true;
                            }

                            ptr2[0] = 255;
                            ptr2[1] = 255;
                            ptr2[2] = 255;

                            /* Finds out the end points of the object from the virtual binary image */
                            leftPoint = Math.Min(leftPoint, x);
                            rightPoint = Math.Max(rightPoint, x);
                            topPoint = Math.Min(topPoint, y);
                            bottomPoint = Math.Max(bottomPoint, y);
                        }
                        else
                        {
                            ptr2[0] = 0;
                            ptr2[1] = 0;
                            ptr2[2] = 0;
                        }

                        ptr += 3;
                        ptr2 += 3;
                    }

                    ptr += offset;
                    ptr2 += offset;
                }

            }
            image.UnlockBits(bmpData);
            processedImage.UnlockBits(bmpData2);
    

            
            debugGraphics.DrawRectangle(debugPen, leftPoint, topPoint, rightPoint - leftPoint, bottomPoint - topPoint);
           

            if (debugMode)
            {
                if (showProcessed)
                {
                    debugView.Image = processedImage;
                }
                else
                {
                    debugView.Image = image;
                }
            }                       
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            frontRange = new HSLColorRange();
            backRange = new HSLColorRange();
            ballRange = new HSLColorRange();
    
            frontRange.minHue = frontCircle_hueMin.Value;
            frontRange.maxHue = frontCircle_hueMax.Value;            
            frontRange.minSaturation = frontCircle_saturationMin.Value / 100.0f;
            frontRange.maxSaturation = frontCircle_saturationMax.Value / 100.0f;
            frontRange.minLuminance = frontCircle_luminanceMin.Value / 100.0f;
            frontRange.maxLuminance = frontCircle_luminanceMax.Value / 100.0f;

            backRange.minHue = backCircle_hueMin.Value;
            backRange.maxHue = backCircle_hueMax.Value;
            backRange.minSaturation = backCircle_saturationMin.Value / 100.0f;
            backRange.maxSaturation = backCircle_saturationMax.Value / 100.0f;
            backRange.minLuminance = backCircle_luminanceMin.Value / 100.0f;
            backRange.maxLuminance = backCircle_luminanceMax.Value / 100.0f;

            ballRange.minHue = ball_hueMin.Value;
            ballRange.maxHue = ball_hueMax.Value;
            ballRange.minSaturation = ball_saturationMin.Value / 100.0f;
            ballRange.maxSaturation = ball_saturationMax.Value / 100.0f;
            ballRange.minLuminance = ball_luminanceMin.Value / 100.0f;
            ballRange.maxLuminance = ball_luminanceMax.Value / 100.0f;

            debugRange = frontRange;

            noiseFilter_radius.Enabled = noiseFilter_threshold.Enabled = noiseFilterEnabled;
        }


        private void frontCircle_hueMin_ValueChanged(object sender, EventArgs e)
        {
            frontRange.minHue = frontCircle_hueMin.Value;            
        }

        private void frontCircle_hueMax_ValueChanged(object sender, EventArgs e)
        {
            frontRange.maxHue = frontCircle_hueMax.Value;
        }

        private void frontCircle_saturationMin_ValueChanged(object sender, EventArgs e)
        {
            frontRange.minSaturation = frontCircle_saturationMin.Value / 100.0f;
        }

        private void frontCircle_saturationMax_ValueChanged(object sender, EventArgs e)
        {
            frontRange.maxSaturation = frontCircle_saturationMax.Value / 100.0f;            
        }

        private void frontCircle_luminanceMin_ValueChanged(object sender, EventArgs e)
        {
            frontRange.minLuminance = frontCircle_luminanceMin.Value / 100.0f;
        }         

        private void frontCircle_luminanceMax_ValueChanged(object sender, EventArgs e)
        {
            frontRange.maxLuminance = frontCircle_luminanceMax.Value / 100.0f;
        }


        private void backCircle_hueMin_ValueChanged(object sender, EventArgs e)
        {
            backRange.minHue = backCircle_hueMin.Value;   
        }

        private void backCircle_hueMax_ValueChanged(object sender, EventArgs e)
        {
            backRange.maxHue = backCircle_hueMax.Value; 
        }

        private void backCircle_saturationMin_ValueChanged(object sender, EventArgs e)
        {
            backRange.minSaturation = backCircle_saturationMin.Value / 100.0f; 
        }

        private void backCircle_saturationMax_ValueChanged(object sender, EventArgs e)
        {
            backRange.maxSaturation = backCircle_saturationMax.Value / 100.0f;
        }

        private void backCircle_luminanceMin_ValueChanged(object sender, EventArgs e)
        {
            backRange.minLuminance = backCircle_luminanceMin.Value / 100.0f;
        }

        private void backCircle_luminanceMax_ValueChanged(object sender, EventArgs e)
        {
            backRange.maxLuminance = backCircle_luminanceMax.Value / 100.0f;            
        }


        private void ball_hueMin_ValueChanged(object sender, EventArgs e)
        {
            ballRange.minHue = ball_hueMin.Value;
        }

        private void ball_hueMax_ValueChanged(object sender, EventArgs e)
        {
            ballRange.maxHue = ball_hueMax.Value;
        }

        private void ball_saturationMin_ValueChanged(object sender, EventArgs e)
        {
            ballRange.minSaturation = ball_saturationMin.Value / 100.0f;
        }

        private void ball_saturationMax_ValueChanged(object sender, EventArgs e)
        {
            ballRange.maxSaturation = ball_saturationMax.Value / 100.0f;
        }

        private void ball_luminanceMin_ValueChanged(object sender, EventArgs e)
        {
            ballRange.minLuminance = ball_luminanceMin.Value / 100.0f;
        }

        private void ball_luminanceMax_ValueChanged(object sender, EventArgs e)
        {
            ballRange.maxLuminance = ball_luminanceMax.Value / 100.0f;
        }


        private void rangeSettingsTabs_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                {
                    debugRange = frontRange;

                    break;
                }

                case 1:
                {
                    debugRange = backRange;

                    break;
                }

                case 2:
                {
                    debugRange = ballRange;

                    break;
                }
            }            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCamera();
        }

        private void stopCamera()
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.Stop();
            }
        }

        private void checkBox_ProcessView_CheckedChanged(object sender, EventArgs e)
        {
            showProcessed = checkBox_ProcessView.Checked;
        }

        private void checkBox_Debug_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_ProcessView.Enabled = rangeSettingsTabs.Enabled = camerasList.Enabled = debugMode = checkBox_Debug.Checked;

            if (!debugMode)
            {
                debugView.Image = null;
            }
        }

        private void camerasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopCamera();

            videoSource = new VideoCaptureDevice(videoDevices[camerasList.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_newFrame);
            videoSource.DesiredFrameSize = VIDEO_RESOLUTION;
            videoSource.DesiredFrameRate = VIDEO_MAX_FRAMERATE;
            videoSource.Start();
        }             

        private void checkBox_noiseFilter_CheckedChanged(object sender, EventArgs e)
        {
            noiseFilter_threshold.Enabled = noiseFilter_radius.Enabled = noiseFilterEnabled = checkBox_noiseFilter.Checked;
        }

        private void noiseFilter_radius_ValueChanged(object sender, EventArgs e)
        {
            noiseFilter_threshold.Maximum = (int)Math.Pow((1 + (noiseFilter_radius.Value * 2)), 2);
            noiseFilterRadius = noiseFilter_radius.Value;
        }

        private void noiseFilter_threshold_ValueChanged(object sender, EventArgs e)
        {
            noiseFilterThreshold = noiseFilter_threshold.Value;
        }
    }
}
