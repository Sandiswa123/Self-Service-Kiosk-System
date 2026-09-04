using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshMart_Self_Service_kiosk
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
            this.Text = "FreshMart Checkout";
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SetupCheckoutScreen();
        }
        private void SetupCheckoutScreen()
        {
            Label titleLabel = new Label();
            titleLabel.Text = "Checkout";
            titleLabel.Font = new Font("Segoe UI", 32, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(60, 60);
            this.Controls.Add(titleLabel);
            Label subLabel = new Label();
            subLabel.Text = "This screen is coming soon.";
            subLabel.Font = new Font("Segoe UI", 14);
            subLabel.ForeColor = Color.Gainsboro;
            subLabel.AutoSize = true;
            subLabel.Location = new Point(60, 120);
            this.Controls.Add(subLabel);
            Button backButton = new Button();
            backButton.Text = "BACK TO WELCOME SCREEN";
            backButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            backButton.ForeColor = Color.White;
            backButton.BackColor = Color.FromArgb(46, 175, 84);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Size = new Size(280, 50);
            backButton.Location = new Point(60, 180);
            backButton.Click += BackButton_Click;
            this.Controls.Add(backButton);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            frmFreshmartSelfServiceKiosk welcomeForm = new frmFreshmartSelfServiceKiosk();
            welcomeForm.Show();
            this.Close();
        }
        
        private void frmCheckout_Load(object sender, EventArgs e)
        {

        }
    }
}
