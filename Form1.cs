using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshMart_Self_Service_kiosk
{
    public partial class frmFreshmartSelfServiceKiosk : Form
    {
        private Timer clockTimer;
        private Label clockLabel;
        private Label dateLabel;
        private PictureBox bannerPicture;
        private Label highlightTag;
        private Label headlineLabel;
        private Label subtextLabel;
        private Label dotsLabel;
        private Button startButton;
        private Timer bannerTimer;

        private Image[] bannerImages;
        private string[] bannerHeadlines = { "Farm-Fresh Produce", "Weekend Specials", "Butchery && Seafood", "Premium Bakery" };
        private string[] bannerSubtext = {
            "Delivered daily from local farms",
            "Up to 40% off selected items this weekend only",
            "Hand-selected premium cuts and fresh catch",
            "Freshly baked breads & pastries from 6AM"
        };
        private int currentBanner = 0;
        public frmFreshmartSelfServiceKiosk()
        {
            InitializeComponent();
            this.Text = "FreshMart Self-Service Kiosk";
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.KeyPreview = true;

            SetupHeader();
            LoadBannerImages();
            SetupBanner();

        }
        private void SetupHeader()
        {
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 90;
            headerPanel.BackColor = Color.FromArgb(20, 20, 20);
            this.Controls.Add(headerPanel);

            Label logo = new Label();
            logo.Text = "F";
            logo.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            logo.ForeColor = Color.White;
            logo.BackColor = Color.FromArgb(46, 175, 84);
            logo.TextAlign = ContentAlignment.MiddleCenter;
            logo.Size = new Size(46, 46);
            logo.Location = new Point(24, 22);
            headerPanel.Controls.Add(logo);
            Label storeName = new Label();
            storeName.Text = "FreshMart Supermarket";
            storeName.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            storeName.ForeColor = Color.White;
            storeName.AutoSize = true;
            storeName.Location = new Point(84, 18);
            headerPanel.Controls.Add(storeName);

            Label storeSub = new Label();
            storeSub.Text = "Self-Service Kiosk";
            storeSub.Font = new Font("Segoe UI", 9.5f);
            storeSub.ForeColor = Color.Gainsboro;
            storeSub.AutoSize = true;
            storeSub.Location = new Point(84, 44);
            headerPanel.Controls.Add(storeSub);

            clockLabel = new Label();
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            clockLabel.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            clockLabel.ForeColor = Color.White;
            clockLabel.AutoSize = true;
            clockLabel.Location = new Point(1300, 16);
            headerPanel.Controls.Add(clockLabel);

            dateLabel = new Label();
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            dateLabel.Font = new Font("Segoe UI", 9.5f);
            dateLabel.ForeColor = Color.Gainsboro;
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(1300, 46);
            headerPanel.Controls.Add(dateLabel);

            clockTimer = new Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
        }
        private void LoadBannerImages()
        {
            string[] fileNames = { "produce.jpg", "specials.jpg", "butcher.jpg", "bakery.jpg" };
            bannerImages = new Image[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++)
            {
                string path = Path.Combine(Application.StartupPath, "Images", fileNames[i]);
                if (File.Exists(path))
                {
                    bannerImages[i] = Image.FromFile(path);
                }
            }
        }
        private void SetupBanner()
        {
            bannerPicture = new PictureBox();
            bannerPicture.Dock = DockStyle.Fill;
            bannerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            bannerPicture.Paint += BannerPicture_Paint;
            this.Controls.Add(bannerPicture);
            bannerPicture.BringToFront();

            highlightTag = new Label();
            highlightTag.Text = "TODAY'S HIGHLIGHT";
            highlightTag.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            highlightTag.ForeColor = Color.White;
            highlightTag.AutoSize = true;
            highlightTag.BackColor = Color.Transparent;
            highlightTag.Location = new Point(60, 400);
            bannerPicture.Controls.Add(highlightTag);
            headlineLabel = new Label();
            headlineLabel.Font = new Font("Segoe UI", 32, FontStyle.Bold);
            headlineLabel.ForeColor = Color.White;
            headlineLabel.AutoSize = true;
            headlineLabel.BackColor = Color.Transparent;
            headlineLabel.Location = new Point(60, 430);
            bannerPicture.Controls.Add(headlineLabel);

            subtextLabel = new Label();
            subtextLabel.Font = new Font("Segoe UI", 12);
            subtextLabel.ForeColor = Color.Gainsboro;
            subtextLabel.AutoSize = true;
            subtextLabel.BackColor = Color.Transparent;
            subtextLabel.Location = new Point(60, 510);
            bannerPicture.Controls.Add(subtextLabel);

            dotsLabel = new Label();
            dotsLabel.Font = new Font("Segoe UI", 12);
            dotsLabel.ForeColor = Color.White;
            dotsLabel.AutoSize = true;
            dotsLabel.BackColor = Color.Transparent;
            dotsLabel.Location = new Point(680, 700);
            bannerPicture.Controls.Add(dotsLabel);

            startButton = new Button();
            startButton.Text = "TAP TO START SHOPPING";
            startButton.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            startButton.ForeColor = Color.White;
            startButton.BackColor = Color.FromArgb(46, 175, 84);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.Size = new Size(360, 55);
            startButton.Location = new Point(600, 620);
            startButton.Click += StartButton_Click;
            bannerPicture.Controls.Add(startButton);

            ShowBanner(currentBanner);

            bannerTimer = new Timer();
            bannerTimer.Interval = 4000;
            bannerTimer.Tick += BannerTimer_Tick;
            bannerTimer.Start();
        }
        private void ShowBanner(int index)
        {
            if (bannerImages[index] != null)
                bannerPicture.Image = bannerImages[index];

            headlineLabel.Text = bannerHeadlines[index];
            subtextLabel.Text = bannerSubtext[index];

            string dots = "";
            for (int i = 0; i < bannerImages.Length; i++)
                dots += (i == index) ? "● " : "○ ";
            dotsLabel.Text = dots;
        }
        private void BannerPicture_Paint(object sender, PaintEventArgs e)
        {
            int width = bannerPicture.Width;
            int height = bannerPicture.Height;

            using (LinearGradientBrush bottomBrush = new LinearGradientBrush(
                new Point(0, height - 400),
                new Point(0, height),
                Color.FromArgb(0, 0, 0, 0),
                Color.FromArgb(180, 0, 0, 0)))
            {
                bottomBrush.WrapMode = WrapMode.TileFlipXY;
                e.Graphics.FillRectangle(bottomBrush, 0, height - 400, width, 400);
            }
        

            using (LinearGradientBrush topBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, 150),
                Color.FromArgb(120, 0, 0, 0),
                Color.FromArgb(0, 0, 0, 0)))
            {
                topBrush.WrapMode = WrapMode.TileFlipXY;   
                e.Graphics.FillRectangle(topBrush, 0, 0, width, 150);
            }
        }
        
        private void BannerTimer_Tick(object sender, EventArgs e)
        {
            currentBanner++;
            if (currentBanner >= bannerImages.Length)
                currentBanner = 0;
            ShowBanner(currentBanner);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
           frmCheckout checkoutForm = new frmCheckout();
            checkoutForm.Show();
            this.Hide();
        }
        
        private void frmFreshmartSelfServiceKiosk_Load(object sender, EventArgs e)
        {

        }
        


        

    
    }
}
