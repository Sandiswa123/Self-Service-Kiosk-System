namespace Admin
{
    partial class frmRestart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestart));
            this.picRestart = new System.Windows.Forms.PictureBox();
            this.lblRestarting = new System.Windows.Forms.Label();
            this.timerRestart = new System.Windows.Forms.Timer(this.components);
            this.pnlRestartContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).BeginInit();
            this.pnlRestartContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRestart
            // 
            this.picRestart.BackColor = System.Drawing.Color.Black;
            this.picRestart.Image = ((System.Drawing.Image)(resources.GetObject("picRestart.Image")));
            this.picRestart.Location = new System.Drawing.Point(123, 13);
            this.picRestart.Name = "picRestart";
            this.picRestart.Size = new System.Drawing.Size(70, 70);
            this.picRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRestart.TabIndex = 0;
            this.picRestart.TabStop = false;
            // 
            // lblRestarting
            // 
            this.lblRestarting.AutoSize = true;
            this.lblRestarting.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestarting.ForeColor = System.Drawing.Color.Gray;
            this.lblRestarting.Location = new System.Drawing.Point(86, 95);
            this.lblRestarting.Name = "lblRestarting";
            this.lblRestarting.Size = new System.Drawing.Size(164, 25);
            this.lblRestarting.TabIndex = 1;
            this.lblRestarting.Text = "Restarting system...";
            // 
            // timerRestart
            // 
            this.timerRestart.Enabled = true;
            this.timerRestart.Tick += new System.EventHandler(this.timerRestart_Tick);
            // 
            // pnlRestartContent
            // 
            this.pnlRestartContent.Controls.Add(this.picRestart);
            this.pnlRestartContent.Controls.Add(this.lblRestarting);
            this.pnlRestartContent.Location = new System.Drawing.Point(230, 179);
            this.pnlRestartContent.Name = "pnlRestartContent";
            this.pnlRestartContent.Size = new System.Drawing.Size(352, 150);
            this.pnlRestartContent.TabIndex = 2;
            // 
            // frmRestart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRestartContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRestart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restarting System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmRestart_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).EndInit();
            this.pnlRestartContent.ResumeLayout(false);
            this.pnlRestartContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRestart;
        private System.Windows.Forms.Label lblRestarting;
        private System.Windows.Forms.Timer timerRestart;
        private System.Windows.Forms.Panel pnlRestartContent;
    }
}