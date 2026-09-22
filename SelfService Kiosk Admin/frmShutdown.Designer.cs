namespace Admin
{
    partial class frmShutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShutdown));
            this.picPowersign = new System.Windows.Forms.PictureBox();
            this.lblSystemShut = new System.Windows.Forms.Label();
            this.btnOpenSytem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPowersign)).BeginInit();
            this.SuspendLayout();
            // 
            // picPowersign
            // 
            this.picPowersign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPowersign.Image = ((System.Drawing.Image)(resources.GetObject("picPowersign.Image")));
            this.picPowersign.Location = new System.Drawing.Point(323, 166);
            this.picPowersign.Name = "picPowersign";
            this.picPowersign.Size = new System.Drawing.Size(84, 50);
            this.picPowersign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPowersign.TabIndex = 1;
            this.picPowersign.TabStop = false;
            // 
            // lblSystemShut
            // 
            this.lblSystemShut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSystemShut.AutoSize = true;
            this.lblSystemShut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemShut.ForeColor = System.Drawing.Color.DimGray;
            this.lblSystemShut.Location = new System.Drawing.Point(248, 236);
            this.lblSystemShut.Name = "lblSystemShut";
            this.lblSystemShut.Size = new System.Drawing.Size(235, 31);
            this.lblSystemShut.TabIndex = 0;
            this.lblSystemShut.Text = "System is Shut down";
            // 
            // btnOpenSytem
            // 
            this.btnOpenSytem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenSytem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnOpenSytem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSytem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSytem.ForeColor = System.Drawing.Color.White;
            this.btnOpenSytem.Location = new System.Drawing.Point(285, 294);
            this.btnOpenSytem.Name = "btnOpenSytem";
            this.btnOpenSytem.Size = new System.Drawing.Size(152, 34);
            this.btnOpenSytem.TabIndex = 2;
            this.btnOpenSytem.Text = "Open System";
            this.btnOpenSytem.UseMnemonic = false;
            this.btnOpenSytem.UseVisualStyleBackColor = false;
            this.btnOpenSytem.Click += new System.EventHandler(this.btnOpenSytem_Click);
            // 
            // frmShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenSytem);
            this.Controls.Add(this.picPowersign);
            this.Controls.Add(this.lblSystemShut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShutdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShutdown";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShutdown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPowersign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPowersign;
        private System.Windows.Forms.Label lblSystemShut;
        private System.Windows.Forms.Button btnOpenSytem;
    }
}