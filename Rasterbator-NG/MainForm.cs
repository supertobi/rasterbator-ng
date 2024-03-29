
// The Rasterbator-NG Version 1.0
// Copyright (C) 2004-2005 Matias �rje
//               2008-2009 Tobias Jakobs
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Rasterbator
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.LinkLabel TranslatorUrl;
        private System.Windows.Forms.LinkLabel TranslatorUrl2;
        private System.Windows.Forms.ComboBox MeasureDimensionCombo;
        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox OpenFileCheckbox;
        private System.Windows.Forms.Panel Panel2_SourceImage;
        private System.Windows.Forms.ListBox LanguageListBox;
        private System.Windows.Forms.RadioButton MultiColorRadio;
        private System.Windows.Forms.Panel Panel8_Rasterbating;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Panel Panel4_OutputSize;
        private System.Windows.Forms.Label SaveAsLabel;
        private System.Windows.Forms.RadioButton BlackRadio;
        private System.Windows.Forms.Panel CustomColorDisplay;
        private System.Windows.Forms.Label OutputSizeLabel;
        private System.Windows.Forms.Label PrintInfoLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.PictureBox PortraitSymbol;
        private System.Windows.Forms.CheckBox LowPriorityRasterbation;
        private System.Windows.Forms.Panel Panel9_Completed;
        private System.Windows.Forms.CheckBox CutoutCheckbox;
        private System.Windows.Forms.Button BackButton1;
        private System.Windows.Forms.Button BackButton2;
        private System.Windows.Forms.Button BackButton3;
        private System.Windows.Forms.Button BackButton4;
        private System.Windows.Forms.Button BackButton5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel1_Welcome;
        private System.Windows.Forms.Label SelectSourceImageLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ContinueButton2;
        private System.Windows.Forms.Button ContinueButton3;
        private System.Windows.Forms.Button ContinueButton1;
        private System.Windows.Forms.Button ContinueButton4;
        private System.Windows.Forms.Button ContinueButton5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button RasterbateButton;
        private System.Windows.Forms.Label SetOptionsLabel;
        private System.Windows.Forms.Panel TitleBg;
        private System.Windows.Forms.Label ColorModeLabel;
        private System.Windows.Forms.Label DotSizeLabel;
        private System.Windows.Forms.Label GalleryPlugLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CutoutInfoLabel;
        private System.Windows.Forms.Label SelectLanguageLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox PaperAlignCombo;
        private System.Windows.Forms.Label PaperSizeLabel;
        private System.Windows.Forms.SaveFileDialog SelectRasterbationTargetDialog;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.RadioButton CustomColorRadio;
        private System.Windows.Forms.Label TranslatorInfo;
        private System.Windows.Forms.OpenFileDialog SelectRasterbationSourceDialog;
        private System.Windows.Forms.Label RasterbateBackgroundInfoLabel;
        private System.Windows.Forms.Button BrowseButton1;
        private System.Windows.Forms.Button BrowseButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox PaperSizeCombo;
        private System.Windows.Forms.Label CompletedLabel;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label SheetsLabel;
        private System.Windows.Forms.Label PleaseWaitLabel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox LandscapeSymbol;
        private System.Windows.Forms.Label DotSizeInfoLabel;
        private System.Windows.Forms.Panel Panel3_PaperSize;
        private System.Windows.Forms.Panel Panel5_Options;
        private System.Windows.Forms.Label EstimatedTimeRemainingLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label WelcomeTitle;
        private System.Windows.Forms.RadioButton CustomPaperRadio;
        private System.Windows.Forms.Label WelcomeInfo;
        private System.Windows.Forms.Panel Panel7_OutputFilename;
        private System.Windows.Forms.RadioButton StandardPaperRadio;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        [STAThread]
        public static void Main()
        {
            Application.Run(new MainForm());
        }

        #region Windows Forms Designer generated code
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StandardPaperRadio = new System.Windows.Forms.RadioButton();
            this.Panel7_OutputFilename = new System.Windows.Forms.Panel();
            this.BackButton5 = new System.Windows.Forms.Button();
            this.BrowseButton2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SaveAsLabel = new System.Windows.Forms.Label();
            this.RasterbateButton = new System.Windows.Forms.Button();
            this.WelcomeInfo = new System.Windows.Forms.Label();
            this.CustomPaperRadio = new System.Windows.Forms.RadioButton();
            this.WelcomeTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EstimatedTimeRemainingLabel = new System.Windows.Forms.Label();
            this.Panel5_Options = new System.Windows.Forms.Panel();
            this.BackButton4 = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.CustomColorDisplay = new System.Windows.Forms.Panel();
            this.MultiColorRadio = new System.Windows.Forms.RadioButton();
            this.CustomColorRadio = new System.Windows.Forms.RadioButton();
            this.BlackRadio = new System.Windows.Forms.RadioButton();
            this.DotSizeInfoLabel = new System.Windows.Forms.Label();
            this.CutoutInfoLabel = new System.Windows.Forms.Label();
            this.CutoutCheckbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ColorModeLabel = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.DotSizeLabel = new System.Windows.Forms.Label();
            this.SetOptionsLabel = new System.Windows.Forms.Label();
            this.ContinueButton5 = new System.Windows.Forms.Button();
            this.Panel3_PaperSize = new System.Windows.Forms.Panel();
            this.PortraitSymbol = new System.Windows.Forms.PictureBox();
            this.LandscapeSymbol = new System.Windows.Forms.PictureBox();
            this.BackButton2 = new System.Windows.Forms.Button();
            this.PaperAlignCombo = new System.Windows.Forms.ComboBox();
            this.PaperSizeCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.PaperSizeLabel = new System.Windows.Forms.Label();
            this.ContinueButton3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.PleaseWaitLabel = new System.Windows.Forms.Label();
            this.SheetsLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.BrowseButton1 = new System.Windows.Forms.Button();
            this.RasterbateBackgroundInfoLabel = new System.Windows.Forms.Label();
            this.SelectRasterbationSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.TranslatorInfo = new System.Windows.Forms.Label();
            this.SelectRasterbationTargetDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SelectLanguageLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GalleryPlugLabel = new System.Windows.Forms.Label();
            this.TitleBg = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.ContinueButton4 = new System.Windows.Forms.Button();
            this.ContinueButton1 = new System.Windows.Forms.Button();
            this.ContinueButton2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectSourceImageLabel = new System.Windows.Forms.Label();
            this.Panel1_Welcome = new System.Windows.Forms.Panel();
            this.TranslatorUrl = new System.Windows.Forms.LinkLabel();
            this.LanguageListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BackButton3 = new System.Windows.Forms.Button();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.Panel9_Completed = new System.Windows.Forms.Panel();
            this.TranslatorUrl2 = new System.Windows.Forms.LinkLabel();
            this.OpenFileCheckbox = new System.Windows.Forms.CheckBox();
            this.CloseApplicationButton = new System.Windows.Forms.Button();
            this.PrintInfoLabel = new System.Windows.Forms.Label();
            this.LowPriorityRasterbation = new System.Windows.Forms.CheckBox();
            this.OutputSizeLabel = new System.Windows.Forms.Label();
            this.Panel4_OutputSize = new System.Windows.Forms.Panel();
            this.MeasureDimensionCombo = new System.Windows.Forms.ComboBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.Panel8_Rasterbating = new System.Windows.Forms.Panel();
            this.Panel2_SourceImage = new System.Windows.Forms.Panel();
            this.Panel7_OutputFilename.SuspendLayout();
            this.Panel5_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.Panel3_PaperSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortraitSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandscapeSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBg.SuspendLayout();
            this.Panel1_Welcome.SuspendLayout();
            this.Panel9_Completed.SuspendLayout();
            this.Panel4_OutputSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.Panel8_Rasterbating.SuspendLayout();
            this.Panel2_SourceImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandardPaperRadio
            // 
            this.StandardPaperRadio.Checked = true;
            this.StandardPaperRadio.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.StandardPaperRadio.Location = new System.Drawing.Point(106, 138);
            this.StandardPaperRadio.Name = "StandardPaperRadio";
            this.StandardPaperRadio.Size = new System.Drawing.Size(576, 29);
            this.StandardPaperRadio.TabIndex = 11;
            this.StandardPaperRadio.TabStop = true;
            this.StandardPaperRadio.Text = "Use standard paper size";
            this.StandardPaperRadio.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
            // 
            // Panel7_OutputFilename
            // 
            this.Panel7_OutputFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel7_OutputFilename.Controls.Add(this.BackButton5);
            this.Panel7_OutputFilename.Controls.Add(this.BrowseButton2);
            this.Panel7_OutputFilename.Controls.Add(this.textBox2);
            this.Panel7_OutputFilename.Controls.Add(this.SaveAsLabel);
            this.Panel7_OutputFilename.Controls.Add(this.RasterbateButton);
            this.Panel7_OutputFilename.Location = new System.Drawing.Point(0, 158);
            this.Panel7_OutputFilename.Name = "Panel7_OutputFilename";
            this.Panel7_OutputFilename.Size = new System.Drawing.Size(829, 476);
            this.Panel7_OutputFilename.TabIndex = 13;
            this.Panel7_OutputFilename.Visible = false;
            // 
            // BackButton5
            // 
            this.BackButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BackButton5.Location = new System.Drawing.Point(96, 408);
            this.BackButton5.Name = "BackButton5";
            this.BackButton5.Size = new System.Drawing.Size(115, 39);
            this.BackButton5.TabIndex = 28;
            this.BackButton5.Text = "< Back";
            this.BackButton5.Click += new System.EventHandler(this.Button15Click);
            // 
            // BrowseButton2
            // 
            this.BrowseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BrowseButton2.Location = new System.Drawing.Point(570, 158);
            this.BrowseButton2.Name = "BrowseButton2";
            this.BrowseButton2.Size = new System.Drawing.Size(154, 34);
            this.BrowseButton2.TabIndex = 10;
            this.BrowseButton2.Text = "Browse...";
            this.BrowseButton2.Click += new System.EventHandler(this.Button8Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.textBox2.Location = new System.Drawing.Point(96, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(628, 27);
            this.textBox2.TabIndex = 9;
            // 
            // SaveAsLabel
            // 
            this.SaveAsLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.SaveAsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveAsLabel.Location = new System.Drawing.Point(96, 69);
            this.SaveAsLabel.Name = "SaveAsLabel";
            this.SaveAsLabel.Size = new System.Drawing.Size(614, 29);
            this.SaveAsLabel.TabIndex = 8;
            this.SaveAsLabel.Text = "Save rasterbation as (5/5)";
            // 
            // RasterbateButton
            // 
            this.RasterbateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RasterbateButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.RasterbateButton.Location = new System.Drawing.Point(560, 408);
            this.RasterbateButton.Name = "RasterbateButton";
            this.RasterbateButton.Size = new System.Drawing.Size(164, 39);
            this.RasterbateButton.TabIndex = 7;
            this.RasterbateButton.Text = "Rasterbate!";
            this.RasterbateButton.Click += new System.EventHandler(this.Button9Click);
            // 
            // WelcomeInfo
            // 
            this.WelcomeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeInfo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.WelcomeInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WelcomeInfo.Location = new System.Drawing.Point(96, 138);
            this.WelcomeInfo.Name = "WelcomeInfo";
            this.WelcomeInfo.Size = new System.Drawing.Size(407, 220);
            this.WelcomeInfo.TabIndex = 5;
            this.WelcomeInfo.Text = "Rasterbator-NG creates huge, rasterized, multi-page images from any picture. The " +
    "rasterized images can be printed and assembled into extremely cool looking poste" +
    "rs.";
            // 
            // CustomPaperRadio
            // 
            this.CustomPaperRadio.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.CustomPaperRadio.Location = new System.Drawing.Point(106, 246);
            this.CustomPaperRadio.Name = "CustomPaperRadio";
            this.CustomPaperRadio.Size = new System.Drawing.Size(585, 30);
            this.CustomPaperRadio.TabIndex = 12;
            this.CustomPaperRadio.Text = "Use custom paper size";
            this.CustomPaperRadio.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
            // 
            // WelcomeTitle
            // 
            this.WelcomeTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.WelcomeTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WelcomeTitle.Location = new System.Drawing.Point(96, 69);
            this.WelcomeTitle.Name = "WelcomeTitle";
            this.WelcomeTitle.Size = new System.Drawing.Size(413, 59);
            this.WelcomeTitle.TabIndex = 4;
            this.WelcomeTitle.Text = "Welcome to The Rasterbator!";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.textBox1.Location = new System.Drawing.Point(96, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // EstimatedTimeRemainingLabel
            // 
            this.EstimatedTimeRemainingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EstimatedTimeRemainingLabel.Location = new System.Drawing.Point(167, 217);
            this.EstimatedTimeRemainingLabel.Name = "EstimatedTimeRemainingLabel";
            this.EstimatedTimeRemainingLabel.Size = new System.Drawing.Size(557, 19);
            this.EstimatedTimeRemainingLabel.TabIndex = 21;
            this.EstimatedTimeRemainingLabel.Text = "Estimated time remaining:";
            this.EstimatedTimeRemainingLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Panel5_Options
            // 
            this.Panel5_Options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel5_Options.Controls.Add(this.BackButton4);
            this.Panel5_Options.Controls.Add(this.SelectButton);
            this.Panel5_Options.Controls.Add(this.CustomColorDisplay);
            this.Panel5_Options.Controls.Add(this.MultiColorRadio);
            this.Panel5_Options.Controls.Add(this.CustomColorRadio);
            this.Panel5_Options.Controls.Add(this.BlackRadio);
            this.Panel5_Options.Controls.Add(this.DotSizeInfoLabel);
            this.Panel5_Options.Controls.Add(this.CutoutInfoLabel);
            this.Panel5_Options.Controls.Add(this.CutoutCheckbox);
            this.Panel5_Options.Controls.Add(this.label10);
            this.Panel5_Options.Controls.Add(this.ColorModeLabel);
            this.Panel5_Options.Controls.Add(this.numericUpDown5);
            this.Panel5_Options.Controls.Add(this.DotSizeLabel);
            this.Panel5_Options.Controls.Add(this.SetOptionsLabel);
            this.Panel5_Options.Controls.Add(this.ContinueButton5);
            this.Panel5_Options.Location = new System.Drawing.Point(0, 158);
            this.Panel5_Options.Name = "Panel5_Options";
            this.Panel5_Options.Size = new System.Drawing.Size(829, 476);
            this.Panel5_Options.TabIndex = 12;
            this.Panel5_Options.Visible = false;
            this.Panel5_Options.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_OptionsPaint);
            // 
            // BackButton4
            // 
            this.BackButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BackButton4.Location = new System.Drawing.Point(96, 408);
            this.BackButton4.Name = "BackButton4";
            this.BackButton4.Size = new System.Drawing.Size(115, 39);
            this.BackButton4.TabIndex = 27;
            this.BackButton4.Text = "< Back";
            this.BackButton4.Click += new System.EventHandler(this.Button14Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.SelectButton.Location = new System.Drawing.Point(298, 335);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(134, 29);
            this.SelectButton.TabIndex = 26;
            this.SelectButton.Text = "Select...";
            this.SelectButton.Click += new System.EventHandler(this.Button7Click);
            // 
            // CustomColorDisplay
            // 
            this.CustomColorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.CustomColorDisplay.Location = new System.Drawing.Point(259, 335);
            this.CustomColorDisplay.Name = "CustomColorDisplay";
            this.CustomColorDisplay.Size = new System.Drawing.Size(29, 29);
            this.CustomColorDisplay.TabIndex = 25;
            // 
            // MultiColorRadio
            // 
            this.MultiColorRadio.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.MultiColorRadio.Location = new System.Drawing.Point(230, 374);
            this.MultiColorRadio.Name = "MultiColorRadio";
            this.MultiColorRadio.Size = new System.Drawing.Size(298, 30);
            this.MultiColorRadio.TabIndex = 24;
            this.MultiColorRadio.Text = "Multi-color";
            // 
            // CustomColorRadio
            // 
            this.CustomColorRadio.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.CustomColorRadio.Location = new System.Drawing.Point(230, 305);
            this.CustomColorRadio.Name = "CustomColorRadio";
            this.CustomColorRadio.Size = new System.Drawing.Size(365, 30);
            this.CustomColorRadio.TabIndex = 23;
            this.CustomColorRadio.Text = "Custom color:";
            // 
            // BlackRadio
            // 
            this.BlackRadio.Checked = true;
            this.BlackRadio.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BlackRadio.Location = new System.Drawing.Point(230, 276);
            this.BlackRadio.Name = "BlackRadio";
            this.BlackRadio.Size = new System.Drawing.Size(298, 29);
            this.BlackRadio.TabIndex = 22;
            this.BlackRadio.TabStop = true;
            this.BlackRadio.Text = "Black";
            // 
            // DotSizeInfoLabel
            // 
            this.DotSizeInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DotSizeInfoLabel.Location = new System.Drawing.Point(125, 217);
            this.DotSizeInfoLabel.Name = "DotSizeInfoLabel";
            this.DotSizeInfoLabel.Size = new System.Drawing.Size(627, 59);
            this.DotSizeInfoLabel.TabIndex = 21;
            this.DotSizeInfoLabel.Text = "Dot size defines the maximum size of the dots of the rasterbation. Typical range " +
    "is 5-25 mm, but other sizes can be used too, if you want to play around.";
            // 
            // CutoutInfoLabel
            // 
            this.CutoutInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CutoutInfoLabel.Location = new System.Drawing.Point(125, 108);
            this.CutoutInfoLabel.Name = "CutoutInfoLabel";
            this.CutoutInfoLabel.Size = new System.Drawing.Size(618, 50);
            this.CutoutInfoLabel.TabIndex = 20;
            this.CutoutInfoLabel.Text = resources.GetString("CutoutInfoLabel.Text");
            // 
            // CutoutCheckbox
            // 
            this.CutoutCheckbox.Checked = true;
            this.CutoutCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CutoutCheckbox.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.CutoutCheckbox.Location = new System.Drawing.Point(106, 79);
            this.CutoutCheckbox.Name = "CutoutCheckbox";
            this.CutoutCheckbox.Size = new System.Drawing.Size(585, 29);
            this.CutoutCheckbox.TabIndex = 19;
            this.CutoutCheckbox.Text = "Draw cutout line around rasterbated area";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(307, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "mm";
            this.label10.Click += new System.EventHandler(this.Label4Click);
            // 
            // ColorModeLabel
            // 
            this.ColorModeLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ColorModeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColorModeLabel.Location = new System.Drawing.Point(106, 276);
            this.ColorModeLabel.Name = "ColorModeLabel";
            this.ColorModeLabel.Size = new System.Drawing.Size(441, 29);
            this.ColorModeLabel.TabIndex = 15;
            this.ColorModeLabel.Text = "Color mode";
            this.ColorModeLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.numericUpDown5.Location = new System.Drawing.Point(211, 177);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(87, 27);
            this.numericUpDown5.TabIndex = 14;
            this.numericUpDown5.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DotSizeLabel
            // 
            this.DotSizeLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.DotSizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DotSizeLabel.Location = new System.Drawing.Point(106, 177);
            this.DotSizeLabel.Name = "DotSizeLabel";
            this.DotSizeLabel.Size = new System.Drawing.Size(441, 30);
            this.DotSizeLabel.TabIndex = 13;
            this.DotSizeLabel.Text = "Dot size";
            this.DotSizeLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // SetOptionsLabel
            // 
            this.SetOptionsLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.SetOptionsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SetOptionsLabel.Location = new System.Drawing.Point(106, 30);
            this.SetOptionsLabel.Name = "SetOptionsLabel";
            this.SetOptionsLabel.Size = new System.Drawing.Size(662, 29);
            this.SetOptionsLabel.TabIndex = 8;
            this.SetOptionsLabel.Text = "Set rasterbation options (4/5)";
            this.SetOptionsLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // ContinueButton5
            // 
            this.ContinueButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueButton5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ContinueButton5.Location = new System.Drawing.Point(560, 408);
            this.ContinueButton5.Name = "ContinueButton5";
            this.ContinueButton5.Size = new System.Drawing.Size(164, 39);
            this.ContinueButton5.TabIndex = 7;
            this.ContinueButton5.Text = "Continue >";
            this.ContinueButton5.Click += new System.EventHandler(this.Button6Click);
            // 
            // Panel3_PaperSize
            // 
            this.Panel3_PaperSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3_PaperSize.Controls.Add(this.PortraitSymbol);
            this.Panel3_PaperSize.Controls.Add(this.LandscapeSymbol);
            this.Panel3_PaperSize.Controls.Add(this.BackButton2);
            this.Panel3_PaperSize.Controls.Add(this.PaperAlignCombo);
            this.Panel3_PaperSize.Controls.Add(this.PaperSizeCombo);
            this.Panel3_PaperSize.Controls.Add(this.label7);
            this.Panel3_PaperSize.Controls.Add(this.label8);
            this.Panel3_PaperSize.Controls.Add(this.numericUpDown2);
            this.Panel3_PaperSize.Controls.Add(this.HeightLabel);
            this.Panel3_PaperSize.Controls.Add(this.numericUpDown1);
            this.Panel3_PaperSize.Controls.Add(this.WidthLabel);
            this.Panel3_PaperSize.Controls.Add(this.CustomPaperRadio);
            this.Panel3_PaperSize.Controls.Add(this.StandardPaperRadio);
            this.Panel3_PaperSize.Controls.Add(this.PaperSizeLabel);
            this.Panel3_PaperSize.Controls.Add(this.ContinueButton3);
            this.Panel3_PaperSize.Location = new System.Drawing.Point(0, 158);
            this.Panel3_PaperSize.Name = "Panel3_PaperSize";
            this.Panel3_PaperSize.Size = new System.Drawing.Size(829, 476);
            this.Panel3_PaperSize.TabIndex = 10;
            this.Panel3_PaperSize.Visible = false;
            this.Panel3_PaperSize.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_PaperSizePaint);
            // 
            // PortraitSymbol
            // 
            this.PortraitSymbol.Location = new System.Drawing.Point(605, 158);
            this.PortraitSymbol.Name = "PortraitSymbol";
            this.PortraitSymbol.Size = new System.Drawing.Size(50, 51);
            this.PortraitSymbol.TabIndex = 23;
            this.PortraitSymbol.TabStop = false;
            // 
            // LandscapeSymbol
            // 
            this.LandscapeSymbol.Location = new System.Drawing.Point(605, 158);
            this.LandscapeSymbol.Name = "LandscapeSymbol";
            this.LandscapeSymbol.Size = new System.Drawing.Size(50, 51);
            this.LandscapeSymbol.TabIndex = 22;
            this.LandscapeSymbol.TabStop = false;
            // 
            // BackButton2
            // 
            this.BackButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BackButton2.Location = new System.Drawing.Point(96, 408);
            this.BackButton2.Name = "BackButton2";
            this.BackButton2.Size = new System.Drawing.Size(115, 39);
            this.BackButton2.TabIndex = 21;
            this.BackButton2.Text = "< Back";
            this.BackButton2.Click += new System.EventHandler(this.Button12Click);
            // 
            // PaperAlignCombo
            // 
            this.PaperAlignCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaperAlignCombo.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.PaperAlignCombo.Items.AddRange(new object[] {
            "Portrait",
            "Landscape"});
            this.PaperAlignCombo.Location = new System.Drawing.Point(442, 167);
            this.PaperAlignCombo.Name = "PaperAlignCombo";
            this.PaperAlignCombo.Size = new System.Drawing.Size(144, 26);
            this.PaperAlignCombo.TabIndex = 20;
            this.PaperAlignCombo.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
            // 
            // PaperSizeCombo
            // 
            this.PaperSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaperSizeCombo.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.PaperSizeCombo.Items.AddRange(new object[] {
            "A4 (210x297 mm)",
            "A3 (297x420 mm)",
            "US Letter (216x279 mm)",
            "US Legal (216x356 mm)"});
            this.PaperSizeCombo.Location = new System.Drawing.Point(154, 167);
            this.PaperSizeCombo.Name = "PaperSizeCombo";
            this.PaperSizeCombo.Size = new System.Drawing.Size(268, 26);
            this.PaperSizeCombo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(365, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "mm";
            this.label7.Click += new System.EventHandler(this.Label4Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(365, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "mm";
            this.label8.Click += new System.EventHandler(this.Label4Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.numericUpDown2.Location = new System.Drawing.Point(259, 325);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(96, 27);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // HeightLabel
            // 
            this.HeightLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HeightLabel.Location = new System.Drawing.Point(163, 325);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(96, 29);
            this.HeightLabel.TabIndex = 15;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.numericUpDown1.Location = new System.Drawing.Point(259, 286);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 27);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // WidthLabel
            // 
            this.WidthLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.WidthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WidthLabel.Location = new System.Drawing.Point(163, 286);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(77, 29);
            this.WidthLabel.TabIndex = 13;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // PaperSizeLabel
            // 
            this.PaperSizeLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.PaperSizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PaperSizeLabel.Location = new System.Drawing.Point(96, 69);
            this.PaperSizeLabel.Name = "PaperSizeLabel";
            this.PaperSizeLabel.Size = new System.Drawing.Size(643, 29);
            this.PaperSizeLabel.TabIndex = 8;
            this.PaperSizeLabel.Text = "Select paper size (2/5)";
            this.PaperSizeLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // ContinueButton3
            // 
            this.ContinueButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueButton3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ContinueButton3.Location = new System.Drawing.Point(560, 408);
            this.ContinueButton3.Name = "ContinueButton3";
            this.ContinueButton3.Size = new System.Drawing.Size(164, 39);
            this.ContinueButton3.TabIndex = 7;
            this.ContinueButton3.Text = "Continue >";
            this.ContinueButton3.Click += new System.EventHandler(this.Button5Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.linkLabel1.Location = new System.Drawing.Point(96, 417);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(317, 29);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/supertobi/rasterbator-ng";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.linkLabel2.Location = new System.Drawing.Point(96, 417);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(413, 29);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://rasterbator.net/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // PleaseWaitLabel
            // 
            this.PleaseWaitLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.PleaseWaitLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PleaseWaitLabel.Location = new System.Drawing.Point(96, 167);
            this.PleaseWaitLabel.Name = "PleaseWaitLabel";
            this.PleaseWaitLabel.Size = new System.Drawing.Size(624, 30);
            this.PleaseWaitLabel.TabIndex = 4;
            this.PleaseWaitLabel.Text = "Rasterbating, please wait...";
            // 
            // SheetsLabel
            // 
            this.SheetsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetsLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.SheetsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SheetsLabel.Location = new System.Drawing.Point(532, 130);
            this.SheetsLabel.Name = "SheetsLabel";
            this.SheetsLabel.Size = new System.Drawing.Size(76, 30);
            this.SheetsLabel.TabIndex = 13;
            this.SheetsLabel.Text = "sheets";
            this.SheetsLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.CompletedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CompletedLabel.Location = new System.Drawing.Point(96, 69);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(442, 29);
            this.CompletedLabel.TabIndex = 4;
            this.CompletedLabel.Text = "Rasterbation completed!";
            // 
            // BrowseButton1
            // 
            this.BrowseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BrowseButton1.Location = new System.Drawing.Point(570, 158);
            this.BrowseButton1.Name = "BrowseButton1";
            this.BrowseButton1.Size = new System.Drawing.Size(154, 34);
            this.BrowseButton1.TabIndex = 10;
            this.BrowseButton1.Text = "Browse...";
            this.BrowseButton1.Click += new System.EventHandler(this.Button3Click);
            // 
            // RasterbateBackgroundInfoLabel
            // 
            this.RasterbateBackgroundInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RasterbateBackgroundInfoLabel.Location = new System.Drawing.Point(115, 417);
            this.RasterbateBackgroundInfoLabel.Name = "RasterbateBackgroundInfoLabel";
            this.RasterbateBackgroundInfoLabel.Size = new System.Drawing.Size(618, 50);
            this.RasterbateBackgroundInfoLabel.TabIndex = 23;
            this.RasterbateBackgroundInfoLabel.Text = "Check this if you want to use other programs while rasterbating. The rasterbation" +
    " will take more time, but other programs become more responsive.";
            // 
            // SelectRasterbationSourceDialog
            // 
            this.SelectRasterbationSourceDialog.Filter = "Image files (*.jpg, *.png, *.gif, *.tif, *.bmp)|*.jpg;*.gif;*.png;*.tif;*.tiff;*." +
    "jpeg;*.bmp|All files (*.*)|*.*";
            this.SelectRasterbationSourceDialog.Title = "Select Rasterbation source...";
            this.SelectRasterbationSourceDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
            // 
            // TranslatorInfo
            // 
            this.TranslatorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslatorInfo.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.TranslatorInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TranslatorInfo.Location = new System.Drawing.Point(532, 280);
            this.TranslatorInfo.Name = "TranslatorInfo";
            this.TranslatorInfo.Size = new System.Drawing.Size(259, 39);
            this.TranslatorInfo.TabIndex = 11;
            this.TranslatorInfo.Text = "Translated by ";
            // 
            // SelectRasterbationTargetDialog
            // 
            this.SelectRasterbationTargetDialog.Filter = "Pdf files (*.pdf)|*.pdf";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(96, 197);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(628, 20);
            this.progressBar1.TabIndex = 8;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            // 
            // SelectLanguageLabel
            // 
            this.SelectLanguageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLanguageLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.SelectLanguageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectLanguageLabel.Location = new System.Drawing.Point(532, 89);
            this.SelectLanguageLabel.Name = "SelectLanguageLabel";
            this.SelectLanguageLabel.Size = new System.Drawing.Size(249, 49);
            this.SelectLanguageLabel.TabIndex = 9;
            this.SelectLanguageLabel.Text = "Please select language:";
            this.SelectLanguageLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(38, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 363);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GalleryPlugLabel
            // 
            this.GalleryPlugLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GalleryPlugLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.GalleryPlugLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GalleryPlugLabel.Location = new System.Drawing.Point(96, 266);
            this.GalleryPlugLabel.Name = "GalleryPlugLabel";
            this.GalleryPlugLabel.Size = new System.Drawing.Size(647, 59);
            this.GalleryPlugLabel.TabIndex = 21;
            this.GalleryPlugLabel.Text = "Please take a photograph of your picture and submit it to the Rasterbation Galler" +
    "y!";
            // 
            // TitleBg
            // 
            this.TitleBg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBg.BackColor = System.Drawing.Color.White;
            this.TitleBg.Controls.Add(this.pictureBox1);
            this.TitleBg.Location = new System.Drawing.Point(0, 0);
            this.TitleBg.Name = "TitleBg";
            this.TitleBg.Size = new System.Drawing.Size(829, 152);
            this.TitleBg.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label25.Location = new System.Drawing.Point(96, 457);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(720, 29);
            this.label25.TabIndex = 8;
            this.label25.Text = "The Rasterbator-NG 1.0 - Licenced under GPL";
            // 
            // ContinueButton4
            // 
            this.ContinueButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueButton4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ContinueButton4.Location = new System.Drawing.Point(560, 408);
            this.ContinueButton4.Name = "ContinueButton4";
            this.ContinueButton4.Size = new System.Drawing.Size(164, 39);
            this.ContinueButton4.TabIndex = 7;
            this.ContinueButton4.Text = "Continue >";
            this.ContinueButton4.Click += new System.EventHandler(this.Button4Click);
            // 
            // ContinueButton1
            // 
            this.ContinueButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueButton1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ContinueButton1.Location = new System.Drawing.Point(560, 408);
            this.ContinueButton1.Name = "ContinueButton1";
            this.ContinueButton1.Size = new System.Drawing.Size(164, 39);
            this.ContinueButton1.TabIndex = 6;
            this.ContinueButton1.Text = "Continue >";
            this.ContinueButton1.Click += new System.EventHandler(this.Button1Click);
            // 
            // ContinueButton2
            // 
            this.ContinueButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueButton2.Enabled = false;
            this.ContinueButton2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.ContinueButton2.Location = new System.Drawing.Point(560, 408);
            this.ContinueButton2.Name = "ContinueButton2";
            this.ContinueButton2.Size = new System.Drawing.Size(164, 39);
            this.ContinueButton2.TabIndex = 7;
            this.ContinueButton2.Text = "Continue >";
            this.ContinueButton2.Click += new System.EventHandler(this.Button2Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(426, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 137);
            this.label11.TabIndex = 15;
            this.label11.Click += new System.EventHandler(this.Label4Click);
            // 
            // SelectSourceImageLabel
            // 
            this.SelectSourceImageLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.SelectSourceImageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectSourceImageLabel.Location = new System.Drawing.Point(96, 69);
            this.SelectSourceImageLabel.Name = "SelectSourceImageLabel";
            this.SelectSourceImageLabel.Size = new System.Drawing.Size(634, 29);
            this.SelectSourceImageLabel.TabIndex = 8;
            this.SelectSourceImageLabel.Text = "Select source image (1/5)";
            // 
            // Panel1_Welcome
            // 
            this.Panel1_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1_Welcome.BackColor = System.Drawing.Color.White;
            this.Panel1_Welcome.Controls.Add(this.TranslatorUrl);
            this.Panel1_Welcome.Controls.Add(this.TranslatorInfo);
            this.Panel1_Welcome.Controls.Add(this.LanguageListBox);
            this.Panel1_Welcome.Controls.Add(this.SelectLanguageLabel);
            this.Panel1_Welcome.Controls.Add(this.label25);
            this.Panel1_Welcome.Controls.Add(this.ContinueButton1);
            this.Panel1_Welcome.Controls.Add(this.linkLabel1);
            this.Panel1_Welcome.Controls.Add(this.WelcomeTitle);
            this.Panel1_Welcome.Controls.Add(this.WelcomeInfo);
            this.Panel1_Welcome.Location = new System.Drawing.Point(0, 158);
            this.Panel1_Welcome.Name = "Panel1_Welcome";
            this.Panel1_Welcome.Size = new System.Drawing.Size(829, 476);
            this.Panel1_Welcome.TabIndex = 5;
            // 
            // TranslatorUrl
            // 
            this.TranslatorUrl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.TranslatorUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TranslatorUrl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.TranslatorUrl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.TranslatorUrl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.TranslatorUrl.Location = new System.Drawing.Point(532, 319);
            this.TranslatorUrl.Name = "TranslatorUrl";
            this.TranslatorUrl.Size = new System.Drawing.Size(240, 20);
            this.TranslatorUrl.TabIndex = 12;
            this.TranslatorUrl.TabStop = true;
            this.TranslatorUrl.Text = "http://translatorurl";
            this.TranslatorUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TranslatorUrlLinkClicked);
            // 
            // LanguageListBox
            // 
            this.LanguageListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageListBox.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.LanguageListBox.ItemHeight = 19;
            this.LanguageListBox.Location = new System.Drawing.Point(532, 138);
            this.LanguageListBox.Name = "LanguageListBox";
            this.LanguageListBox.Size = new System.Drawing.Size(201, 118);
            this.LanguageListBox.TabIndex = 10;
            this.LanguageListBox.SelectedIndexChanged += new System.EventHandler(this.LanguageListBoxSelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // BackButton3
            // 
            this.BackButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BackButton3.Location = new System.Drawing.Point(426, 408);
            this.BackButton3.Name = "BackButton3";
            this.BackButton3.Size = new System.Drawing.Size(115, 39);
            this.BackButton3.TabIndex = 23;
            this.BackButton3.Text = "< Back";
            this.BackButton3.Click += new System.EventHandler(this.Button13Click);
            // 
            // BackButton1
            // 
            this.BackButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.BackButton1.Location = new System.Drawing.Point(96, 408);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(115, 39);
            this.BackButton1.TabIndex = 11;
            this.BackButton1.Text = "< Back";
            this.BackButton1.Click += new System.EventHandler(this.Button11Click);
            // 
            // Panel9_Completed
            // 
            this.Panel9_Completed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel9_Completed.Controls.Add(this.TranslatorUrl2);
            this.Panel9_Completed.Controls.Add(this.GalleryPlugLabel);
            this.Panel9_Completed.Controls.Add(this.OpenFileCheckbox);
            this.Panel9_Completed.Controls.Add(this.CloseApplicationButton);
            this.Panel9_Completed.Controls.Add(this.linkLabel2);
            this.Panel9_Completed.Controls.Add(this.CompletedLabel);
            this.Panel9_Completed.Controls.Add(this.PrintInfoLabel);
            this.Panel9_Completed.Location = new System.Drawing.Point(0, 158);
            this.Panel9_Completed.Name = "Panel9_Completed";
            this.Panel9_Completed.Size = new System.Drawing.Size(829, 476);
            this.Panel9_Completed.TabIndex = 15;
            this.Panel9_Completed.Visible = false;
            // 
            // TranslatorUrl2
            // 
            this.TranslatorUrl2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.TranslatorUrl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TranslatorUrl2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.TranslatorUrl2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.TranslatorUrl2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.TranslatorUrl2.Location = new System.Drawing.Point(96, 391);
            this.TranslatorUrl2.Name = "TranslatorUrl2";
            this.TranslatorUrl2.Size = new System.Drawing.Size(394, 29);
            this.TranslatorUrl2.TabIndex = 23;
            this.TranslatorUrl2.TabStop = true;
            this.TranslatorUrl2.Text = "https://github.com/supertobi/rasterbator-ng/";
            this.TranslatorUrl2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TranslatorUrlLinkClicked);
            // 
            // OpenFileCheckbox
            // 
            this.OpenFileCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileCheckbox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OpenFileCheckbox.Checked = true;
            this.OpenFileCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenFileCheckbox.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.OpenFileCheckbox.Location = new System.Drawing.Point(522, 368);
            this.OpenFileCheckbox.Name = "OpenFileCheckbox";
            this.OpenFileCheckbox.Size = new System.Drawing.Size(298, 30);
            this.OpenFileCheckbox.TabIndex = 20;
            this.OpenFileCheckbox.Text = "Open rasticulate file";
            this.OpenFileCheckbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseApplicationButton.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.CloseApplicationButton.Location = new System.Drawing.Point(541, 408);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(221, 39);
            this.CloseApplicationButton.TabIndex = 6;
            this.CloseApplicationButton.Text = "Close application";
            this.CloseApplicationButton.Click += new System.EventHandler(this.Button10Click);
            // 
            // PrintInfoLabel
            // 
            this.PrintInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintInfoLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.PrintInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrintInfoLabel.Location = new System.Drawing.Point(96, 108);
            this.PrintInfoLabel.Name = "PrintInfoLabel";
            this.PrintInfoLabel.Size = new System.Drawing.Size(647, 128);
            this.PrintInfoLabel.TabIndex = 5;
            this.PrintInfoLabel.Text = resources.GetString("PrintInfoLabel.Text");
            // 
            // LowPriorityRasterbation
            // 
            this.LowPriorityRasterbation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LowPriorityRasterbation.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.LowPriorityRasterbation.Location = new System.Drawing.Point(96, 388);
            this.LowPriorityRasterbation.Name = "LowPriorityRasterbation";
            this.LowPriorityRasterbation.Size = new System.Drawing.Size(586, 29);
            this.LowPriorityRasterbation.TabIndex = 22;
            this.LowPriorityRasterbation.Text = "Rasterbate on low priority";
            this.LowPriorityRasterbation.CheckedChanged += new System.EventHandler(this.LowPriorityRasterbationCheckedChanged);
            // 
            // OutputSizeLabel
            // 
            this.OutputSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputSizeLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.OutputSizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutputSizeLabel.Location = new System.Drawing.Point(416, 49);
            this.OutputSizeLabel.Name = "OutputSizeLabel";
            this.OutputSizeLabel.Size = new System.Drawing.Size(375, 59);
            this.OutputSizeLabel.TabIndex = 8;
            this.OutputSizeLabel.Text = "Define output size (3/5)";
            this.OutputSizeLabel.Click += new System.EventHandler(this.Label4Click);
            // 
            // Panel4_OutputSize
            // 
            this.Panel4_OutputSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel4_OutputSize.Controls.Add(this.BackButton3);
            this.Panel4_OutputSize.Controls.Add(this.MeasureDimensionCombo);
            this.Panel4_OutputSize.Controls.Add(this.pictureBox2);
            this.Panel4_OutputSize.Controls.Add(this.label11);
            this.Panel4_OutputSize.Controls.Add(this.numericUpDown4);
            this.Panel4_OutputSize.Controls.Add(this.SheetsLabel);
            this.Panel4_OutputSize.Controls.Add(this.OutputSizeLabel);
            this.Panel4_OutputSize.Controls.Add(this.ContinueButton4);
            this.Panel4_OutputSize.Location = new System.Drawing.Point(0, 158);
            this.Panel4_OutputSize.Name = "Panel4_OutputSize";
            this.Panel4_OutputSize.Size = new System.Drawing.Size(829, 476);
            this.Panel4_OutputSize.TabIndex = 11;
            this.Panel4_OutputSize.Visible = false;
            // 
            // MeasureDimensionCombo
            // 
            this.MeasureDimensionCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeasureDimensionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeasureDimensionCombo.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.MeasureDimensionCombo.Items.AddRange(new object[] {
            "wide",
            "high"});
            this.MeasureDimensionCombo.Location = new System.Drawing.Point(618, 128);
            this.MeasureDimensionCombo.Name = "MeasureDimensionCombo";
            this.MeasureDimensionCombo.Size = new System.Drawing.Size(106, 26);
            this.MeasureDimensionCombo.TabIndex = 22;
            this.MeasureDimensionCombo.SelectedIndexChanged += new System.EventHandler(this.NumericUpDown4ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown4.DecimalPlaces = 1;
            this.numericUpDown4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.numericUpDown4.Location = new System.Drawing.Point(426, 128);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(96, 27);
            this.numericUpDown4.TabIndex = 14;
            this.numericUpDown4.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.NumericUpDown4ValueChanged);
            // 
            // Panel8_Rasterbating
            // 
            this.Panel8_Rasterbating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel8_Rasterbating.Controls.Add(this.RasterbateBackgroundInfoLabel);
            this.Panel8_Rasterbating.Controls.Add(this.LowPriorityRasterbation);
            this.Panel8_Rasterbating.Controls.Add(this.EstimatedTimeRemainingLabel);
            this.Panel8_Rasterbating.Controls.Add(this.PleaseWaitLabel);
            this.Panel8_Rasterbating.Controls.Add(this.progressBar1);
            this.Panel8_Rasterbating.Location = new System.Drawing.Point(0, 158);
            this.Panel8_Rasterbating.Name = "Panel8_Rasterbating";
            this.Panel8_Rasterbating.Size = new System.Drawing.Size(829, 476);
            this.Panel8_Rasterbating.TabIndex = 14;
            this.Panel8_Rasterbating.Visible = false;
            // 
            // Panel2_SourceImage
            // 
            this.Panel2_SourceImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2_SourceImage.Controls.Add(this.BackButton1);
            this.Panel2_SourceImage.Controls.Add(this.BrowseButton1);
            this.Panel2_SourceImage.Controls.Add(this.textBox1);
            this.Panel2_SourceImage.Controls.Add(this.SelectSourceImageLabel);
            this.Panel2_SourceImage.Controls.Add(this.ContinueButton2);
            this.Panel2_SourceImage.Location = new System.Drawing.Point(0, 158);
            this.Panel2_SourceImage.Name = "Panel2_SourceImage";
            this.Panel2_SourceImage.Size = new System.Drawing.Size(829, 476);
            this.Panel2_SourceImage.TabIndex = 9;
            this.Panel2_SourceImage.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 638);
            this.Controls.Add(this.Panel9_Completed);
            this.Controls.Add(this.TitleBg);
            this.Controls.Add(this.Panel1_Welcome);
            this.Controls.Add(this.Panel4_OutputSize);
            this.Controls.Add(this.Panel8_Rasterbating);
            this.Controls.Add(this.Panel7_OutputFilename);
            this.Controls.Add(this.Panel5_Options);
            this.Controls.Add(this.Panel3_PaperSize);
            this.Controls.Add(this.Panel2_SourceImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(840, 677);
            this.Name = "MainForm";
            this.Text = "The Rasterbator";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Resize += new System.EventHandler(this.MainFormResize);
            this.Panel7_OutputFilename.ResumeLayout(false);
            this.Panel7_OutputFilename.PerformLayout();
            this.Panel5_Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.Panel3_PaperSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PortraitSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandscapeSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBg.ResumeLayout(false);
            this.Panel1_Welcome.ResumeLayout(false);
            this.Panel9_Completed.ResumeLayout(false);
            this.Panel4_OutputSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.Panel8_Rasterbating.ResumeLayout(false);
            this.Panel2_SourceImage.ResumeLayout(false);
            this.Panel2_SourceImage.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        bool CheckFile(string dir, string filename)
        {
            if (File.Exists(dir + filename)) return true;
            MessageBox.Show("Cannot find file " + filename + " - make sure it is in the installation directory (" + dir + "). Cannot continue, sorry.");
            return false;
        }

        Control FindControl(Control Source, string s)
        {
            foreach (Control C in Source.Controls)
            {
                if (C.Name == s) return C;
                Control c = FindControl(C, s);
                if (c != null) return c;
            }
            return null;
        }

        void LanguageListBoxSelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                XmlTextReader Rdr = new XmlTextReader(LanguageFileNames[LanguageListBox.SelectedIndex]);
                Labels.Clear();
                while (Rdr.Read())
                {
                    if (Rdr.NodeType != XmlNodeType.Element) continue;
                    if (Rdr.Name != "item") continue;

                    string n = Rdr.GetAttribute("name");
                    string s = Rdr.ReadElementString();

                    Control C = FindControl(this, n);

                    Labels[n] = s;

                    if (C is Label) (C as Label).Text = s;
                    if (C is Button) (C as Button).Text = s;
                    if (C is CheckBox) (C as CheckBox).Text = s;
                    if (C is RadioButton) (C as RadioButton).Text = s;
                    if (C is ComboBox)
                    {
                        string[] p = s.Split('|');
                        for (int i = 0; i < p.Length; i++) (C as ComboBox).Items[i] = p[i];
                    }
                    if (C is LinkLabel)
                    {
                        // prevent running of processes
                        if (!s.ToLower().StartsWith("http://")) s = "";
                        try
                        {
                            new Uri(s); // check
                            (C as LinkLabel).Text = s;
                            (C as LinkLabel).Visible = true;
                            if (n == "TranslatorUrl")
                            {
                                TranslatorUrl2.Text = s;
                                TranslatorUrl2.Visible = true;
                            }
                        }
                        catch
                        {
                            (C as LinkLabel).Visible = false;
                            (C as LinkLabel).Text = "";
                            if (n == "TranslatorUrl")
                            {
                                TranslatorUrl2.Text = "";
                                TranslatorUrl2.Visible = false;
                            }
                        }
                    }
                }
                Rdr.Close();
                SelectRasterbationSourceDialog.Title = Labels["SelectSource"].ToString();
                SelectRasterbationSourceDialog.Filter = Labels["SelectSourceFilter"].ToString();
                SelectRasterbationTargetDialog.Filter = Labels["SelectTargetFilter"].ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error in language data file " + LanguageFileNames[LanguageListBox.SelectedIndex] + " - " + E.Message);
            }
        }

        string[] LanguageFileNames = null;
        string ApplicationDirectory = "";
        readonly Hashtable Labels = new Hashtable();

        void MainFormLoad(object sender, System.EventArgs e)
        {
            ApplicationDirectory = Assembly.GetExecutingAssembly().CodeBase;
            Uri ApplicationDirectoryUri = new Uri(ApplicationDirectory);
            ApplicationDirectory = Uri.UnescapeDataString(ApplicationDirectoryUri.AbsolutePath);
            ApplicationDirectory = Path.GetDirectoryName(ApplicationDirectory) + Path.DirectorySeparatorChar;

            if (!CheckFile(ApplicationDirectory, "itextsharp.dll"))
            {
                Close();
                return;
            }
            
            if (!CheckFile(ApplicationDirectory, "ICSharpCode.SharpZipLib.dll"))
            {
                Close();
                return;
            }
            
            if (!Directory.Exists(ApplicationDirectory + "languages"))
            {
                MessageBox.Show("The language data directory (" + ApplicationDirectory + "languages) seems to be missing. Please extract the language directory from the archive file.");
                Close();
            }

            LanguageListBox.Items.Clear();
            LanguageFileNames = Directory.GetFiles(ApplicationDirectory + "languages");
            foreach (string s in LanguageFileNames)
            {
                XmlTextReader Rdr = null;
                try
                {
                    Rdr = new XmlTextReader(s);
                    while (Rdr.Read())
                    {
                        if (Rdr.NodeType != XmlNodeType.Element) continue;
                        if (Rdr.Name == "language")
                        {
                            string lt = Rdr.GetAttribute("nativename");
                            if (Rdr.GetAttribute("englishname") != null) lt = Rdr.GetAttribute("englishname") + " (" + lt + ")";
                            LanguageListBox.Items.Add(lt);
                            string ISOLanguageName = Rdr.GetAttribute("TwoLetterISOLanguageName");
                            if ((lt.ToLower() == "english") & (LanguageListBox.SelectedIndex == -1))
                            {
                                LanguageListBox.SelectedIndex = LanguageListBox.Items.Count - 1;
                            }
                            if (ISOLanguageName == System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
                            {
                                LanguageListBox.SelectedIndex = LanguageListBox.Items.Count - 1;
                            }
                        }
                    }
                    Rdr.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error in language data file " + s + " - " + E.Message);
                    Rdr.Close();
                }
            }

            if (LanguageListBox.Items.Count == 0)
            {
                MessageBox.Show("Could not find any language files. Please extract the language directory from the archive file.");
                Close();
            }
        }

        void Button1Click(object sender, System.EventArgs e)
        {
            Panel1_Welcome.Visible = false;
            Panel2_SourceImage.Visible = true;
        }

        void Button2Click(object sender, System.EventArgs e)
        {
            Panel2_SourceImage.Visible = false;
            Panel3_PaperSize.Visible = true;
            if (PaperSizeCombo.SelectedIndex < 0) PaperSizeCombo.SelectedIndex = 0;
            if (PaperAlignCombo.SelectedIndex < 0) PaperAlignCombo.SelectedIndex = 0;
        }

        void Button3Click(object sender, System.EventArgs e)
        {
            SelectRasterbationSourceDialog.ShowDialog();
        }

        void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Text = SelectRasterbationSourceDialog.FileName;
        }

        void TextBox1TextChanged(object sender, System.EventArgs e)
        {
            ContinueButton2.Enabled = File.Exists(textBox1.Text);
            string s = textBox1.Text;
            if (s.IndexOf(".") < 0) s += ".";
            s = s.Substring(0, s.LastIndexOf("."));
            string fn = s;
            int c = 0;
            while (File.Exists(fn + ".pdf"))
            {
                c++;
                fn = s + "_" + c;
            }
            textBox2.Text = fn + ".pdf";
        }

        void Label4Click(object sender, System.EventArgs e)
        {

        }

        void ComboBox2SelectedIndexChanged(object sender, System.EventArgs e)
        {
            PortraitSymbol.Visible = PaperAlignCombo.SelectedIndex == 0;
            LandscapeSymbol.Visible = PaperAlignCombo.SelectedIndex == 1;
        }

        Bitmap DisplayImage = null;
        Bitmap OriginalImage = null;

        // in millimeters
        decimal PaperWidth = 210M;
        decimal PaperHeight = 297M;

        void Button5Click(object sender, System.EventArgs e)
        {
            Panel3_PaperSize.Visible = false;
            Panel4_OutputSize.Visible = true;
            if (MeasureDimensionCombo.SelectedIndex < 0) MeasureDimensionCombo.SelectedIndex = 0;

            if (StandardPaperRadio.Checked)
            {
                decimal s1 = 0, s2 = 0;
                switch (PaperSizeCombo.SelectedIndex)
                {
                    case 0: s1 = 210M; s2 = 297M; break;
                    case 1: s1 = 297M; s2 = 420M; break;
                    case 2: s1 = 216M; s2 = 279M; break;
                    case 3: s1 = 216M; s2 = 356M; break;
                }

                if (PaperAlignCombo.SelectedIndex == 0)
                {
                    PaperWidth = s1;
                    PaperHeight = s2;
                }
                else
                {
                    PaperWidth = s2;
                    PaperHeight = s1;
                }

            }
            else
            {
                PaperWidth = numericUpDown1.Value;
                PaperHeight = numericUpDown2.Value;
            }

            int d;
            if (pictureBox2.Width < pictureBox2.Height) d = pictureBox2.Width;
            else d = pictureBox2.Height;

            OriginalImage = Image.FromFile(textBox1.Text) as Bitmap;
            double w, h;
            if (OriginalImage.Width > OriginalImage.Height)
            {
                w = d;
                h = d * (double)OriginalImage.Height / (double)OriginalImage.Width;
            }
            else
            {
                h = d;
                w = d * (double)OriginalImage.Width / (double)OriginalImage.Height;
            }
            DisplayImage = new Bitmap(OriginalImage, new Size((int)w, (int)h));


            DisplayPaging();
        }

        decimal OutputWidth = 0, OutputHeight = 0;

        void DisplayPaging()
        {
            if (DisplayImage == null) return;

            int d;
            if (pictureBox2.Width < pictureBox2.Height) d = pictureBox2.Width;
            else d = pictureBox2.Height;

            decimal w = DisplayImage.Width;
            decimal h = DisplayImage.Height;
            Bitmap B = new Bitmap(DisplayImage);
            Graphics G = Graphics.FromImage(B);

            decimal Pages = numericUpDown4.Value;

            bool AdjustWidth = true;
            if (MeasureDimensionCombo.SelectedIndex == 1) AdjustWidth = false;

            decimal DisplayPageWidth, DisplayPageHeight, PagesX, PagesY;

            if (AdjustWidth)
            {
                DisplayPageWidth = w / Pages;
                DisplayPageHeight = PaperHeight / PaperWidth * DisplayPageWidth;
                PagesX = Pages;
                PagesY = PaperWidth / PaperHeight * PagesX * h / w;
            }
            else
            {
                DisplayPageHeight = h / Pages;
                DisplayPageWidth = PaperWidth / PaperHeight * DisplayPageHeight;
                PagesY = Pages;
                PagesX = PaperHeight / PaperWidth * PagesY * w / h;
            }

            Pen DarkPen = new Pen(Color.FromArgb(0x88, 0, 0, 0));
            Pen LightPen = new Pen(Color.FromArgb(0x88, 255, 255, 255));

            decimal p = DisplayPageWidth;
            while (p < w)
            {
                int x = (int)Math.Round(p);
                G.DrawLine(LightPen, x, 0, x, (int)h);
                G.DrawLine(DarkPen, x + 1, 0, x + 1, (int)h);
                p += DisplayPageWidth;
            }

            p = DisplayPageHeight;
            while (p < h)
            {
                int y = (int)Math.Round(p);
                G.DrawLine(LightPen, 0, y, (int)w, y);
                G.DrawLine(DarkPen, 0, y + 1, (int)w, y + 1);
                p += DisplayPageHeight;
            }

            G.Save();
            G.Dispose();

            Bitmap B2 = new Bitmap(d, d);

            G = Graphics.FromImage(B2);
            G.FillRectangle(new SolidBrush(Color.White), 0, 0, d, d);

            TextureBrush TB = new TextureBrush(B, WrapMode.Clamp);
            TB.TranslateTransform((int)Math.Round((d - (decimal)w) / 2), (int)Math.Round(((decimal)d - h) / 2));

            G.FillRectangle(TB, (int)Math.Round(((decimal)d - w) / 2), (int)Math.Round(((decimal)d - h) / 2), (int)w, (int)h);
            G.Save();

            pictureBox2.Image = B2 as Image;

            int px = (int)Math.Ceiling((double)PagesX);
            int py = (int)Math.Ceiling((double)PagesY);

            string Stats;

            OutputWidth = PaperWidth * PagesX;
            OutputHeight = PaperHeight * PagesY;

            if (OutputWidth > 1000 || OutputHeight > 1000)
                Stats = Labels["OutputImageSize"] + "\n" + (OutputWidth / 1000).ToString("f2") + " x " + (OutputHeight / 1000).ToString("f2") + " m\n\n";
            else
                Stats = Labels["OutputImageSize"] + "\n" + (OutputWidth / 10).ToString("f1") + " x " + (OutputHeight / 10).ToString("f1") + " cm\n\n";

            Stats += Labels["PaperConsumption"] + "\n" + px + " x " + py + " = " + (px * py) + " " + Labels["sheet" + (px * py == 1 ? "" : "s")];

            label11.Text = Stats;
        }

        void NumericUpDown4ValueChanged(object sender, System.EventArgs e)
        {
            DisplayPaging();
        }

        void Panel5_OptionsPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        void Button7Click(object sender, System.EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            CustomColorRadio.Checked = true;
            CustomColorDisplay.BackColor = colorDialog1.Color;
        }

        void Button4Click(object sender, System.EventArgs e)
        {
            DisplayPaging();
            Panel4_OutputSize.Visible = false;
            Panel5_Options.Visible = true;
        }

        void Panel3_PaperSizePaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        void RadioButton2CheckedChanged(object sender, System.EventArgs e)
        {
            PaperSizeCombo.Enabled = StandardPaperRadio.Checked;
            PaperAlignCombo.Enabled = StandardPaperRadio.Checked;
            numericUpDown1.Enabled = CustomPaperRadio.Checked;
            numericUpDown2.Enabled = CustomPaperRadio.Checked;
        }

        //		void NumericUpDown4KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        //		{
        //		  DisplayPaging();
        //		}

        void Button8Click(object sender, System.EventArgs e)
        {
            if (SelectRasterbationTargetDialog.ShowDialog() != DialogResult.OK) return;
            textBox2.Text = SelectRasterbationTargetDialog.FileName;
        }

        void Button6Click(object sender, System.EventArgs e)
        {
            if (numericUpDown5.Value < 3M)
            {
                if (MessageBox.Show(Labels["SmallDotSizeWarning"].ToString(),
                                   Labels["ConfirmOptions"].ToString(),
                                   MessageBoxButtons.YesNo) == DialogResult.No) return;
            }
            Panel5_Options.Visible = false;
            Panel7_OutputFilename.Visible = true;
        }

        void LinkLabel1LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/supertobi/rasterbator-ng");
        }

        Rasterbator R;

        void Button9Click(object sender, System.EventArgs e)
        {
            string WorkDir = Path.GetDirectoryName(textBox2.Text);
            //		  string WorkDir=textBox2.Text.Substring(0, textBox2.Text.LastIndexOf("\\")+1);
            try
            {
                Directory.CreateDirectory(WorkDir);
            }
            catch (Exception E)
            {
                MessageBox.Show("Invalid directory: " + E.Message);
                return;
            }

            Panel7_OutputFilename.Visible = false;
            Panel8_Rasterbating.Visible = true;

            NameValueCollection S = new NameValueCollection
            {
                ["ImageWidth"] = ((int)OutputWidth).ToString(),
                ["ImageHeight"] = ((int)OutputHeight).ToString(),
                ["PaperWidth"] = PaperWidth.ToString(),
                ["PaperHeight"] = PaperHeight.ToString(),
                ["RasterSize"] = numericUpDown5.Value.ToString(),
                ["CroppingRectangle"] = CutoutCheckbox.Checked.ToString()
            };

            if (BlackRadio.Checked) S["RasterColor"] = "000000";

            if (CustomColorRadio.Checked)
            {
                Color C = colorDialog1.Color;
                S["RasterColor"] = C.R.ToString("x2") + C.G.ToString("x2") + C.B.ToString("x2");
            }
            if (MultiColorRadio.Checked) S["RasterColor"] = "avg";

            S["OriginalImageWidth"] = OriginalImage.Width.ToString();
            S["OriginalImageHeight"] = OriginalImage.Height.ToString();
            S["DisplayImageWidth"] = OriginalImage.Width.ToString();
            S["DisplayImageHeight"] = OriginalImage.Height.ToString();
            S["x1"] = "0";
            S["y1"] = "0";
            S["x2"] = OriginalImage.Width.ToString();
            S["y2"] = OriginalImage.Height.ToString();
            S["OriginalFilename"] = textBox1.Text;
            S["TargetFilename"] = textBox2.Text;

            S["WorkDirectory"] = WorkDir;

            R = new Rasterbator(S);
            R.Worker = new Thread(new ThreadStart(R.Go))
            {
                Priority = ThreadPriority.Lowest
            };
            R.Worker.Start();

            EstimatedTimeRemainingLabel.Text = "";
            StartTime = DateTime.Now;

            progressBar1.ForeColor = Color.FromArgb(0xff, 0x4e, 0x07, 0x07);
            timer1.Enabled = true;
        }

        DateTime StartTime;
        double LastProgress = -1;

        void Timer1Tick(object sender, System.EventArgs e)
        {
            double p = R.Progress;
            progressBar1.Value = (int)(p * 100d);

            if (StartTime.AddSeconds(2) < DateTime.Now && p != LastProgress)
            {

                double SecondsElapsed = DateTime.Now.Subtract(StartTime).TotalSeconds;
                int SecondsRemaining = (int)(SecondsElapsed / p * (1d - p));

                if (SecondsRemaining > 0)
                {
                    string s = Labels["EstimatedTimeRemainingLabel"].ToString();
                    if (SecondsRemaining > 0)
                    {
                        int m = SecondsRemaining / 60;
                        if (m > 0) s += " " + m + " " + Labels["minute" + (m == 1 ? "" : "s")];
                        SecondsRemaining %= 60;
                    }
                    s += " " + SecondsRemaining + " " + Labels["second" + (SecondsRemaining == 1 ? "" : "s")];

                    EstimatedTimeRemainingLabel.Text = s;
                }
                else
                {
                    EstimatedTimeRemainingLabel.Text = "";
                }

                LastProgress = p;
            }

            if (R.Worker.ThreadState == System.Threading.ThreadState.Running) return;
            OriginalImage.Dispose();

            timer1.Enabled = false;
            if (R.ErrorMessage != "") MessageBox.Show("An error occurred while rasterbating. Please read the help files for possible solutions." +
                                                      "\n\nThe error message is:\n" + R.ErrorMessage);

            Panel8_Rasterbating.Visible = false;
            Panel9_Completed.Visible = true;
        }

        void Button10Click(object sender, System.EventArgs e)
        {
            if (OpenFileCheckbox.Checked) if (File.Exists(textBox2.Text))
                {
                    //https://stackoverflow.com/questions/46808315/net-core-2-0-process-start-throws-the-specified-executable-is-not-a-valid-appl
                    //https://github.com/dotnet/runtime/issues/17938

                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        new Process { StartInfo = new ProcessStartInfo(textBox2.Text) { UseShellExecute = true } }.Start();
                    }
                    else
                    {
                        _ = System.Diagnostics.Process.Start(textBox2.Text);
                    }
                }

            Close();
        }

        void LowPriorityRasterbationCheckedChanged(object sender, System.EventArgs e)
        {
            R.Worker.Priority = LowPriorityRasterbation.Checked ? ThreadPriority.BelowNormal : ThreadPriority.Normal;
        }

        void Button11Click(object sender, System.EventArgs e)
        {
            Panel2_SourceImage.Visible = false;
            Panel1_Welcome.Visible = true;
        }

        void Button12Click(object sender, System.EventArgs e)
        {
            Panel3_PaperSize.Visible = false;
            Panel2_SourceImage.Visible = true;
        }

        void Button13Click(object sender, System.EventArgs e)
        {
            Panel4_OutputSize.Visible = false;
            Panel3_PaperSize.Visible = true;
        }

        void Button14Click(object sender, System.EventArgs e)
        {
            Panel5_Options.Visible = false;
            Panel4_OutputSize.Visible = true;
            Button5Click(sender, e);
        }

        void Button15Click(object sender, System.EventArgs e)
        {
            Panel7_OutputFilename.Visible = false;
            Panel5_Options.Visible = true;
        }

        void TranslatorUrlLinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (TranslatorUrl.Text == "") return;
            System.Diagnostics.Process.Start(TranslatorUrl.Text);
        }

        void MainFormResize(object sender, System.EventArgs e)
        {
            if (Panel4_OutputSize.Visible) Button5Click(sender, e);
        }

    }
}
