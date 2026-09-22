using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmShutdown : Form
    {
        public frmShutdown()
        {
            InitializeComponent();
            

            this.WindowState = FormWindowState.Maximized;

            
            lblSystemShut.Left = (this.ClientSize.Width - lblSystemShut.Width) / 2;
            btnOpenSytem.Left = (this.ClientSize.Width - btnOpenSytem.Width) / 2;
        }

        private void frmShutdown_Load(object sender, EventArgs e)
        {
            
            btnOpenSytem.Top = (this.ClientSize.Height - btnOpenSytem.Height) / 2;
            picPowersign.Left = (this.ClientSize.Width - picPowersign.Width) / 2;
            lblSystemShut.Left = (this.ClientSize.Width - lblSystemShut.Width) / 2;

            // Position them relative to the button
            lblSystemShut.Top = btnOpenSytem.Top - lblSystemShut.Height - 20
                ;

            picPowersign.Top = lblSystemShut.Top - picPowersign.Height - 20;
        }

        private void btnOpenSytem_Click(object sender, EventArgs e)
        {
            FreshMartKiosk.FormWelcome welcome =
       new FreshMartKiosk.FormWelcome();

            welcome.Show();

            this.Hide();
        }
    }
}
