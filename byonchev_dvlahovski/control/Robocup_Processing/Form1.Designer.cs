namespace Robocup_Processing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frontCircle_hueMin = new System.Windows.Forms.TrackBar();
            this.frontCircle_hueMax = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rangeSettingsTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.frontCircle_luminanceMax = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.frontCircle_luminanceMin = new System.Windows.Forms.TrackBar();
            this.frontCircle_saturationMax = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.frontCircle_saturationMin = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backCircle_luminanceMax = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.backCircle_luminanceMin = new System.Windows.Forms.TrackBar();
            this.backCircle_saturationMax = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.backCircle_saturationMin = new System.Windows.Forms.TrackBar();
            this.backCircle_hueMax = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.backCircle_hueMin = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ball_luminanceMax = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.ball_luminanceMin = new System.Windows.Forms.TrackBar();
            this.ball_saturationMax = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.ball_saturationMin = new System.Windows.Forms.TrackBar();
            this.ball_hueMax = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.ball_hueMin = new System.Windows.Forms.TrackBar();
            this.debugView = new System.Windows.Forms.PictureBox();
            this.checkBox_ProcessView = new System.Windows.Forms.CheckBox();
            this.checkBox_Debug = new System.Windows.Forms.CheckBox();
            this.camerasList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.noiseFilter_threshold = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.noiseFilter_radius = new System.Windows.Forms.TrackBar();
            this.checkBox_noiseFilter = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.checkBox_ExecuteCommands = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_hueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_hueMax)).BeginInit();
            this.rangeSettingsTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_luminanceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_luminanceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_saturationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_saturationMin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_luminanceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_luminanceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_saturationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_saturationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_hueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_hueMin)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball_luminanceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_luminanceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_saturationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_saturationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_hueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_hueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseFilter_threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseFilter_radius)).BeginInit();
            this.SuspendLayout();
            // 
            // frontCircle_hueMin
            // 
            this.frontCircle_hueMin.Location = new System.Drawing.Point(6, 24);
            this.frontCircle_hueMin.Maximum = 359;
            this.frontCircle_hueMin.Name = "frontCircle_hueMin";
            this.frontCircle_hueMin.Size = new System.Drawing.Size(165, 45);
            this.frontCircle_hueMin.TabIndex = 0;
            this.frontCircle_hueMin.TickFrequency = 60;
            this.frontCircle_hueMin.ValueChanged += new System.EventHandler(this.frontCircle_hueMin_ValueChanged);
            // 
            // frontCircle_hueMax
            // 
            this.frontCircle_hueMax.Location = new System.Drawing.Point(6, 50);
            this.frontCircle_hueMax.Maximum = 359;
            this.frontCircle_hueMax.Name = "frontCircle_hueMax";
            this.frontCircle_hueMax.Size = new System.Drawing.Size(165, 45);
            this.frontCircle_hueMax.TabIndex = 1;
            this.frontCircle_hueMax.TickFrequency = 60;
            this.frontCircle_hueMax.Value = 359;
            this.frontCircle_hueMax.ValueChanged += new System.EventHandler(this.frontCircle_hueMax_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hue filter range";
            // 
            // rangeSettingsTabs
            // 
            this.rangeSettingsTabs.Controls.Add(this.tabPage1);
            this.rangeSettingsTabs.Controls.Add(this.tabPage2);
            this.rangeSettingsTabs.Controls.Add(this.tabPage3);
            this.rangeSettingsTabs.Location = new System.Drawing.Point(673, 12);
            this.rangeSettingsTabs.Name = "rangeSettingsTabs";
            this.rangeSettingsTabs.SelectedIndex = 0;
            this.rangeSettingsTabs.Size = new System.Drawing.Size(185, 295);
            this.rangeSettingsTabs.TabIndex = 3;
            this.rangeSettingsTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.rangeSettingsTabs_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.frontCircle_luminanceMax);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.frontCircle_luminanceMin);
            this.tabPage1.Controls.Add(this.frontCircle_saturationMax);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.frontCircle_saturationMin);
            this.tabPage1.Controls.Add(this.frontCircle_hueMax);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.frontCircle_hueMin);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(177, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Front Circle";
            // 
            // frontCircle_luminanceMax
            // 
            this.frontCircle_luminanceMax.Location = new System.Drawing.Point(6, 230);
            this.frontCircle_luminanceMax.Maximum = 100;
            this.frontCircle_luminanceMax.Name = "frontCircle_luminanceMax";
            this.frontCircle_luminanceMax.Size = new System.Drawing.Size(165, 45);
            this.frontCircle_luminanceMax.TabIndex = 7;
            this.frontCircle_luminanceMax.TickFrequency = 10;
            this.frontCircle_luminanceMax.Value = 100;
            this.frontCircle_luminanceMax.ValueChanged += new System.EventHandler(this.frontCircle_luminanceMax_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Luminance filter range";
            // 
            // frontCircle_luminanceMin
            // 
            this.frontCircle_luminanceMin.Location = new System.Drawing.Point(6, 204);
            this.frontCircle_luminanceMin.Maximum = 100;
            this.frontCircle_luminanceMin.Name = "frontCircle_luminanceMin";
            this.frontCircle_luminanceMin.Size = new System.Drawing.Size(165, 45);
            this.frontCircle_luminanceMin.TabIndex = 6;
            this.frontCircle_luminanceMin.TickFrequency = 10;
            this.frontCircle_luminanceMin.ValueChanged += new System.EventHandler(this.frontCircle_luminanceMin_ValueChanged);
            // 
            // frontCircle_saturationMax
            // 
            this.frontCircle_saturationMax.Location = new System.Drawing.Point(6, 140);
            this.frontCircle_saturationMax.Maximum = 100;
            this.frontCircle_saturationMax.Name = "frontCircle_saturationMax";
            this.frontCircle_saturationMax.Size = new System.Drawing.Size(165, 45);
            this.frontCircle_saturationMax.TabIndex = 4;
            this.frontCircle_saturationMax.TickFrequency = 10;
            this.frontCircle_saturationMax.Value = 100;
            this.frontCircle_saturationMax.ValueChanged += new System.EventHandler(this.frontCircle_saturationMax_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saturation filter range";
            // 
            // frontCircle_saturationMin
            // 
            this.frontCircle_saturationMin.Location = new System.Drawing.Point(6, 114);
            this.frontCircle_saturationMin.Maximum = 100;
            this.frontCircle_saturationMin.Name = "frontCircle_saturationMin";
            this.frontCircle_saturationMin.Size = new System.Drawing.Size(165, 45);
            this.frontCircle_saturationMin.TabIndex = 3;
            this.frontCircle_saturationMin.TickFrequency = 10;
            this.frontCircle_saturationMin.ValueChanged += new System.EventHandler(this.frontCircle_saturationMin_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.backCircle_luminanceMax);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.backCircle_luminanceMin);
            this.tabPage2.Controls.Add(this.backCircle_saturationMax);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.backCircle_saturationMin);
            this.tabPage2.Controls.Add(this.backCircle_hueMax);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.backCircle_hueMin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(177, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Back Circle";
            // 
            // backCircle_luminanceMax
            // 
            this.backCircle_luminanceMax.AutoSize = false;
            this.backCircle_luminanceMax.Location = new System.Drawing.Point(6, 230);
            this.backCircle_luminanceMax.Maximum = 100;
            this.backCircle_luminanceMax.Name = "backCircle_luminanceMax";
            this.backCircle_luminanceMax.Size = new System.Drawing.Size(165, 45);
            this.backCircle_luminanceMax.TabIndex = 16;
            this.backCircle_luminanceMax.TickFrequency = 10;
            this.backCircle_luminanceMax.Value = 100;
            this.backCircle_luminanceMax.ValueChanged += new System.EventHandler(this.backCircle_luminanceMax_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Luminance filter range";
            // 
            // backCircle_luminanceMin
            // 
            this.backCircle_luminanceMin.AutoSize = false;
            this.backCircle_luminanceMin.Location = new System.Drawing.Point(6, 204);
            this.backCircle_luminanceMin.Maximum = 100;
            this.backCircle_luminanceMin.Name = "backCircle_luminanceMin";
            this.backCircle_luminanceMin.Size = new System.Drawing.Size(165, 45);
            this.backCircle_luminanceMin.TabIndex = 15;
            this.backCircle_luminanceMin.TickFrequency = 10;
            this.backCircle_luminanceMin.ValueChanged += new System.EventHandler(this.backCircle_luminanceMin_ValueChanged);
            // 
            // backCircle_saturationMax
            // 
            this.backCircle_saturationMax.AutoSize = false;
            this.backCircle_saturationMax.Location = new System.Drawing.Point(6, 140);
            this.backCircle_saturationMax.Maximum = 100;
            this.backCircle_saturationMax.Name = "backCircle_saturationMax";
            this.backCircle_saturationMax.Size = new System.Drawing.Size(165, 45);
            this.backCircle_saturationMax.TabIndex = 13;
            this.backCircle_saturationMax.TickFrequency = 10;
            this.backCircle_saturationMax.Value = 100;
            this.backCircle_saturationMax.ValueChanged += new System.EventHandler(this.backCircle_saturationMax_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(35, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Saturation filter range";
            // 
            // backCircle_saturationMin
            // 
            this.backCircle_saturationMin.AutoSize = false;
            this.backCircle_saturationMin.Location = new System.Drawing.Point(6, 114);
            this.backCircle_saturationMin.Maximum = 100;
            this.backCircle_saturationMin.Name = "backCircle_saturationMin";
            this.backCircle_saturationMin.Size = new System.Drawing.Size(165, 45);
            this.backCircle_saturationMin.TabIndex = 12;
            this.backCircle_saturationMin.TickFrequency = 10;
            this.backCircle_saturationMin.ValueChanged += new System.EventHandler(this.backCircle_saturationMin_ValueChanged);
            // 
            // backCircle_hueMax
            // 
            this.backCircle_hueMax.AutoSize = false;
            this.backCircle_hueMax.Location = new System.Drawing.Point(6, 50);
            this.backCircle_hueMax.Maximum = 359;
            this.backCircle_hueMax.Name = "backCircle_hueMax";
            this.backCircle_hueMax.Size = new System.Drawing.Size(165, 45);
            this.backCircle_hueMax.TabIndex = 10;
            this.backCircle_hueMax.TickFrequency = 60;
            this.backCircle_hueMax.Value = 359;
            this.backCircle_hueMax.ValueChanged += new System.EventHandler(this.backCircle_hueMax_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(46, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hue filter range";
            // 
            // backCircle_hueMin
            // 
            this.backCircle_hueMin.AutoSize = false;
            this.backCircle_hueMin.Location = new System.Drawing.Point(6, 24);
            this.backCircle_hueMin.Maximum = 359;
            this.backCircle_hueMin.Name = "backCircle_hueMin";
            this.backCircle_hueMin.Size = new System.Drawing.Size(165, 45);
            this.backCircle_hueMin.TabIndex = 9;
            this.backCircle_hueMin.TickFrequency = 60;
            this.backCircle_hueMin.ValueChanged += new System.EventHandler(this.backCircle_hueMin_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.ball_luminanceMax);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.ball_luminanceMin);
            this.tabPage3.Controls.Add(this.ball_saturationMax);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.ball_saturationMin);
            this.tabPage3.Controls.Add(this.ball_hueMax);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.ball_hueMin);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(177, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ball";
            // 
            // ball_luminanceMax
            // 
            this.ball_luminanceMax.Location = new System.Drawing.Point(6, 230);
            this.ball_luminanceMax.Maximum = 100;
            this.ball_luminanceMax.Name = "ball_luminanceMax";
            this.ball_luminanceMax.Size = new System.Drawing.Size(165, 45);
            this.ball_luminanceMax.TabIndex = 16;
            this.ball_luminanceMax.TickFrequency = 10;
            this.ball_luminanceMax.Value = 100;
            this.ball_luminanceMax.ValueChanged += new System.EventHandler(this.ball_luminanceMax_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Luminance filter range";
            // 
            // ball_luminanceMin
            // 
            this.ball_luminanceMin.Location = new System.Drawing.Point(6, 204);
            this.ball_luminanceMin.Maximum = 100;
            this.ball_luminanceMin.Name = "ball_luminanceMin";
            this.ball_luminanceMin.Size = new System.Drawing.Size(165, 45);
            this.ball_luminanceMin.TabIndex = 15;
            this.ball_luminanceMin.TickFrequency = 10;
            this.ball_luminanceMin.ValueChanged += new System.EventHandler(this.ball_luminanceMin_ValueChanged);
            // 
            // ball_saturationMax
            // 
            this.ball_saturationMax.Location = new System.Drawing.Point(6, 140);
            this.ball_saturationMax.Maximum = 100;
            this.ball_saturationMax.Name = "ball_saturationMax";
            this.ball_saturationMax.Size = new System.Drawing.Size(165, 45);
            this.ball_saturationMax.TabIndex = 13;
            this.ball_saturationMax.TickFrequency = 10;
            this.ball_saturationMax.Value = 100;
            this.ball_saturationMax.ValueChanged += new System.EventHandler(this.ball_saturationMax_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Saturation filter range";
            // 
            // ball_saturationMin
            // 
            this.ball_saturationMin.Location = new System.Drawing.Point(6, 114);
            this.ball_saturationMin.Maximum = 100;
            this.ball_saturationMin.Name = "ball_saturationMin";
            this.ball_saturationMin.Size = new System.Drawing.Size(165, 45);
            this.ball_saturationMin.TabIndex = 12;
            this.ball_saturationMin.TickFrequency = 10;
            this.ball_saturationMin.ValueChanged += new System.EventHandler(this.ball_saturationMin_ValueChanged);
            // 
            // ball_hueMax
            // 
            this.ball_hueMax.Location = new System.Drawing.Point(6, 50);
            this.ball_hueMax.Maximum = 359;
            this.ball_hueMax.Name = "ball_hueMax";
            this.ball_hueMax.Size = new System.Drawing.Size(165, 45);
            this.ball_hueMax.TabIndex = 10;
            this.ball_hueMax.TickFrequency = 60;
            this.ball_hueMax.Value = 359;
            this.ball_hueMax.ValueChanged += new System.EventHandler(this.ball_hueMax_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Hue filter range";
            // 
            // ball_hueMin
            // 
            this.ball_hueMin.Location = new System.Drawing.Point(6, 24);
            this.ball_hueMin.Maximum = 359;
            this.ball_hueMin.Name = "ball_hueMin";
            this.ball_hueMin.Size = new System.Drawing.Size(165, 45);
            this.ball_hueMin.TabIndex = 9;
            this.ball_hueMin.TickFrequency = 60;
            this.ball_hueMin.ValueChanged += new System.EventHandler(this.ball_hueMin_ValueChanged);
            // 
            // debugView
            // 
            this.debugView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugView.Location = new System.Drawing.Point(12, 12);
            this.debugView.Name = "debugView";
            this.debugView.Size = new System.Drawing.Size(640, 480);
            this.debugView.TabIndex = 6;
            this.debugView.TabStop = false;
            // 
            // checkBox_ProcessView
            // 
            this.checkBox_ProcessView.AutoSize = true;
            this.checkBox_ProcessView.Location = new System.Drawing.Point(563, 505);
            this.checkBox_ProcessView.Name = "checkBox_ProcessView";
            this.checkBox_ProcessView.Size = new System.Drawing.Size(73, 17);
            this.checkBox_ProcessView.TabIndex = 7;
            this.checkBox_ProcessView.Text = "Filter view";
            this.checkBox_ProcessView.UseVisualStyleBackColor = true;
            this.checkBox_ProcessView.CheckedChanged += new System.EventHandler(this.checkBox_ProcessView_CheckedChanged);
            // 
            // checkBox_Debug
            // 
            this.checkBox_Debug.AutoSize = true;
            this.checkBox_Debug.Checked = true;
            this.checkBox_Debug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Debug.Location = new System.Drawing.Point(499, 505);
            this.checkBox_Debug.Name = "checkBox_Debug";
            this.checkBox_Debug.Size = new System.Drawing.Size(64, 17);
            this.checkBox_Debug.TabIndex = 8;
            this.checkBox_Debug.Text = "Preview";
            this.checkBox_Debug.UseVisualStyleBackColor = true;
            this.checkBox_Debug.CheckedChanged += new System.EventHandler(this.checkBox_Debug_CheckedChanged);
            // 
            // camerasList
            // 
            this.camerasList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camerasList.FormattingEnabled = true;
            this.camerasList.Location = new System.Drawing.Point(108, 503);
            this.camerasList.Name = "camerasList";
            this.camerasList.Size = new System.Drawing.Size(185, 21);
            this.camerasList.TabIndex = 11;
            this.camerasList.SelectedIndexChanged += new System.EventHandler(this.camerasList_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Selected camera:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(673, 316);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(185, 176);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.noiseFilter_threshold);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.noiseFilter_radius);
            this.tabPage4.Controls.Add(this.checkBox_noiseFilter);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(177, 150);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Noise filter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Threshold";
            // 
            // noiseFilter_threshold
            // 
            this.noiseFilter_threshold.Location = new System.Drawing.Point(6, 74);
            this.noiseFilter_threshold.Maximum = 1;
            this.noiseFilter_threshold.Minimum = 1;
            this.noiseFilter_threshold.Name = "noiseFilter_threshold";
            this.noiseFilter_threshold.Size = new System.Drawing.Size(165, 45);
            this.noiseFilter_threshold.TabIndex = 10;
            this.noiseFilter_threshold.TickFrequency = 12;
            this.noiseFilter_threshold.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.noiseFilter_threshold.Value = 1;
            this.noiseFilter_threshold.ValueChanged += new System.EventHandler(this.noiseFilter_threshold_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Filter radius";
            // 
            // noiseFilter_radius
            // 
            this.noiseFilter_radius.LargeChange = 2;
            this.noiseFilter_radius.Location = new System.Drawing.Point(6, 23);
            this.noiseFilter_radius.Maximum = 5;
            this.noiseFilter_radius.Name = "noiseFilter_radius";
            this.noiseFilter_radius.Size = new System.Drawing.Size(165, 45);
            this.noiseFilter_radius.TabIndex = 1;
            this.noiseFilter_radius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.noiseFilter_radius.ValueChanged += new System.EventHandler(this.noiseFilter_radius_ValueChanged);
            // 
            // checkBox_noiseFilter
            // 
            this.checkBox_noiseFilter.AutoSize = true;
            this.checkBox_noiseFilter.Location = new System.Drawing.Point(6, 127);
            this.checkBox_noiseFilter.Name = "checkBox_noiseFilter";
            this.checkBox_noiseFilter.Size = new System.Drawing.Size(65, 17);
            this.checkBox_noiseFilter.TabIndex = 0;
            this.checkBox_noiseFilter.Text = "Enabled";
            this.checkBox_noiseFilter.UseVisualStyleBackColor = true;
            this.checkBox_noiseFilter.CheckedChanged += new System.EventHandler(this.checkBox_noiseFilter_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(177, 150);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Circle detection";
            // 
            // checkBox_ExecuteCommands
            // 
            this.checkBox_ExecuteCommands.AutoSize = true;
            this.checkBox_ExecuteCommands.Enabled = false;
            this.checkBox_ExecuteCommands.Location = new System.Drawing.Point(374, 505);
            this.checkBox_ExecuteCommands.Name = "checkBox_ExecuteCommands";
            this.checkBox_ExecuteCommands.Size = new System.Drawing.Size(119, 17);
            this.checkBox_ExecuteCommands.TabIndex = 9;
            this.checkBox_ExecuteCommands.Text = "Execute commands";
            this.checkBox_ExecuteCommands.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.camerasList);
            this.Controls.Add(this.checkBox_ExecuteCommands);
            this.Controls.Add(this.checkBox_Debug);
            this.Controls.Add(this.checkBox_ProcessView);
            this.Controls.Add(this.debugView);
            this.Controls.Add(this.rangeSettingsTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Robocup Control Panel v0.1 ALPHA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_hueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_hueMax)).EndInit();
            this.rangeSettingsTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_luminanceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_luminanceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_saturationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontCircle_saturationMin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_luminanceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_luminanceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_saturationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_saturationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_hueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCircle_hueMin)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball_luminanceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_luminanceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_saturationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_saturationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_hueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball_hueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseFilter_threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseFilter_radius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar frontCircle_hueMin;
        private System.Windows.Forms.TrackBar frontCircle_hueMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl rangeSettingsTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar frontCircle_luminanceMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar frontCircle_luminanceMin;
        private System.Windows.Forms.TrackBar frontCircle_saturationMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar frontCircle_saturationMin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TrackBar backCircle_luminanceMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar backCircle_luminanceMin;
        private System.Windows.Forms.TrackBar backCircle_saturationMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar backCircle_saturationMin;
        private System.Windows.Forms.TrackBar backCircle_hueMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar backCircle_hueMin;
        private System.Windows.Forms.TrackBar ball_luminanceMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar ball_luminanceMin;
        private System.Windows.Forms.TrackBar ball_saturationMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar ball_saturationMin;
        private System.Windows.Forms.TrackBar ball_hueMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar ball_hueMin;
        private System.Windows.Forms.PictureBox debugView;
        private System.Windows.Forms.CheckBox checkBox_ProcessView;
        private System.Windows.Forms.CheckBox checkBox_Debug;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox camerasList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox checkBox_noiseFilter;
        private System.Windows.Forms.TrackBar noiseFilter_radius;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar noiseFilter_threshold;
        private System.Windows.Forms.CheckBox checkBox_ExecuteCommands;

    }
}

