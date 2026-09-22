using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmRestart : Form
    {
        private int elapsedTime = 0;
        private Image originalImage;
        private Form adminForm;
        public frmRestart(Form admin)
        {
            InitializeComponent();

            originalImage = picRestart.Image;
            adminForm = admin;
            CenterRestartContent();
        }
        private void CenterRestartContent()
        {
            pnlRestartContent.Left =
                (this.ClientSize.Width - pnlRestartContent.Width) / 2;

            pnlRestartContent.Top =
                (this.ClientSize.Height - pnlRestartContent.Height) / 2;
        }

        private void timerRestart_Tick(object sender, EventArgs e)
        {
            elapsedTime += 100;

            picRestart.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picRestart.Refresh();

            if (elapsedTime >= 3000)
            {
                // Return to Admin
                timerRestart.Stop();
                adminForm.Show();
                this.Close();
            }
        }

        private void frmRestart_Resize(object sender, EventArgs e)
        {
            CenterRestartContent();
        }
       
    }     }
