
namespace APIcheck
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
            this.btnNearestStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNearestStore
            // 
            this.btnNearestStore.Location = new System.Drawing.Point(202, 113);
            this.btnNearestStore.Name = "btnNearestStore";
            this.btnNearestStore.Size = new System.Drawing.Size(395, 66);
            this.btnNearestStore.TabIndex = 0;
            this.btnNearestStore.Text = "Click Here To Find The Product on a nearest store";
            this.btnNearestStore.UseVisualStyleBackColor = true;
            this.btnNearestStore.Click += new System.EventHandler(this.btnNearestStore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNearestStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNearestStore;
    }
}

