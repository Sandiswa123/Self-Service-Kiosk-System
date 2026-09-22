namespace Admin
{
    partial class frmAnalytics
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
            this.btnByHour = new System.Windows.Forms.Button();
            this.btnByDay = new System.Windows.Forms.Button();
            this.btnByMonth = new System.Windows.Forms.Button();
            this.pnlByHour = new System.Windows.Forms.Panel();
            this.lblHourTransaction = new System.Windows.Forms.Label();
            this.lblHourAvgTransaction = new System.Windows.Forms.Label();
            this.lblRevenueHour = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblHourTransactions = new System.Windows.Forms.Label();
            this.lblHourTotalTransactions = new System.Windows.Forms.Label();
            this.lblHourTitle = new System.Windows.Forms.Label();
            this.pnlRecentTransactions = new System.Windows.Forms.Panel();
            this.lblRecentTransactions = new System.Windows.Forms.Label();
            this.flpRecentTransactionsHour = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDayTitle = new System.Windows.Forms.Label();
            this.lblDayTotalTransactions = new System.Windows.Forms.Label();
            this.lblDayTotalRevenue = new System.Windows.Forms.Label();
            this.lblDayAvgTransaction = new System.Windows.Forms.Label();
            this.lblDayTransactions = new System.Windows.Forms.Label();
            this.lblDayRevenue = new System.Windows.Forms.Label();
            this.lblDayAverage = new System.Windows.Forms.Label();
            this.pnlByDay = new System.Windows.Forms.Panel();
            this.pnlByMonth = new System.Windows.Forms.Panel();
            this.lblAvgTransactionMonthly = new System.Windows.Forms.Label();
            this.lblMontlyRevenue = new System.Windows.Forms.Label();
            this.lblTransactionsMonthly = new System.Windows.Forms.Label();
            this.lblMonthlyAvgTransactions = new System.Windows.Forms.Label();
            this.lblTotalMonthlyRevenue = new System.Windows.Forms.Label();
            this.lblMonthlyTotalTransactions = new System.Windows.Forms.Label();
            this.lblMonthlyTransaction = new System.Windows.Forms.Label();
            this.pnlRecentTransactionDay = new System.Windows.Forms.Panel();
            this.lblRecentTransactionsDay = new System.Windows.Forms.Label();
            this.flpRecentTransactionDay = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMonthlyRecentTransactions = new System.Windows.Forms.Panel();
            this.flpRecentTransactionMonthly = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecentTransactionMonthly = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlByHour.SuspendLayout();
            this.pnlRecentTransactions.SuspendLayout();
            this.pnlByDay.SuspendLayout();
            this.pnlByMonth.SuspendLayout();
            this.pnlRecentTransactionDay.SuspendLayout();
            this.pnlMonthlyRecentTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnByHour
            // 
            this.btnByHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.btnByHour.FlatAppearance.BorderSize = 0;
            this.btnByHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByHour.ForeColor = System.Drawing.Color.White;
            this.btnByHour.Location = new System.Drawing.Point(30, 33);
            this.btnByHour.Name = "btnByHour";
            this.btnByHour.Size = new System.Drawing.Size(129, 53);
            this.btnByHour.TabIndex = 0;
            this.btnByHour.Text = "By Hour";
            this.btnByHour.UseVisualStyleBackColor = false;
            this.btnByHour.Click += new System.EventHandler(this.btnByHour_Click);
            // 
            // btnByDay
            // 
            this.btnByDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.btnByDay.FlatAppearance.BorderSize = 0;
            this.btnByDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDay.ForeColor = System.Drawing.Color.White;
            this.btnByDay.Location = new System.Drawing.Point(184, 32);
            this.btnByDay.Name = "btnByDay";
            this.btnByDay.Size = new System.Drawing.Size(129, 53);
            this.btnByDay.TabIndex = 1;
            this.btnByDay.Text = "By Day";
            this.btnByDay.UseVisualStyleBackColor = false;
            this.btnByDay.Click += new System.EventHandler(this.btnByDay_Click);
            // 
            // btnByMonth
            // 
            this.btnByMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.btnByMonth.FlatAppearance.BorderSize = 0;
            this.btnByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByMonth.ForeColor = System.Drawing.Color.White;
            this.btnByMonth.Location = new System.Drawing.Point(346, 32);
            this.btnByMonth.Name = "btnByMonth";
            this.btnByMonth.Size = new System.Drawing.Size(129, 53);
            this.btnByMonth.TabIndex = 2;
            this.btnByMonth.Text = "By Month";
            this.btnByMonth.UseVisualStyleBackColor = false;
            this.btnByMonth.Click += new System.EventHandler(this.btnByMonth_Click);
            // 
            // pnlByHour
            // 
            this.pnlByHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlByHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.pnlByHour.Controls.Add(this.lblHourTransaction);
            this.pnlByHour.Controls.Add(this.lblHourAvgTransaction);
            this.pnlByHour.Controls.Add(this.lblRevenueHour);
            this.pnlByHour.Controls.Add(this.lblTotalRevenue);
            this.pnlByHour.Controls.Add(this.lblHourTransactions);
            this.pnlByHour.Controls.Add(this.lblHourTotalTransactions);
            this.pnlByHour.Controls.Add(this.lblHourTitle);
            this.pnlByHour.ForeColor = System.Drawing.Color.White;
            this.pnlByHour.Location = new System.Drawing.Point(30, 127);
            this.pnlByHour.Name = "pnlByHour";
            this.pnlByHour.Size = new System.Drawing.Size(1442, 205);
            this.pnlByHour.TabIndex = 3;
            // 
            // lblHourTransaction
            // 
            this.lblHourTransaction.AutoSize = true;
            this.lblHourTransaction.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourTransaction.ForeColor = System.Drawing.Color.White;
            this.lblHourTransaction.Location = new System.Drawing.Point(1209, 167);
            this.lblHourTransaction.Name = "lblHourTransaction";
            this.lblHourTransaction.Size = new System.Drawing.Size(75, 31);
            this.lblHourTransaction.TabIndex = 7;
            this.lblHourTransaction.Text = "R 0.00";
            // 
            // lblHourAvgTransaction
            // 
            this.lblHourAvgTransaction.AutoSize = true;
            this.lblHourAvgTransaction.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourAvgTransaction.ForeColor = System.Drawing.Color.White;
            this.lblHourAvgTransaction.Location = new System.Drawing.Point(1180, 132);
            this.lblHourAvgTransaction.Name = "lblHourAvgTransaction";
            this.lblHourAvgTransaction.Size = new System.Drawing.Size(183, 25);
            this.lblHourAvgTransaction.TabIndex = 6;
            this.lblHourAvgTransaction.Text = "Avg per Transaction";
            // 
            // lblRevenueHour
            // 
            this.lblRevenueHour.AutoSize = true;
            this.lblRevenueHour.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueHour.ForeColor = System.Drawing.Color.White;
            this.lblRevenueHour.Location = new System.Drawing.Point(725, 174);
            this.lblRevenueHour.Name = "lblRevenueHour";
            this.lblRevenueHour.Size = new System.Drawing.Size(75, 31);
            this.lblRevenueHour.TabIndex = 5;
            this.lblRevenueHour.Text = "R 0.00";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(689, 138);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(133, 25);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "Total Revenue";
            // 
            // lblHourTransactions
            // 
            this.lblHourTransactions.AutoSize = true;
            this.lblHourTransactions.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourTransactions.ForeColor = System.Drawing.Color.White;
            this.lblHourTransactions.Location = new System.Drawing.Point(57, 167);
            this.lblHourTransactions.Name = "lblHourTransactions";
            this.lblHourTransactions.Size = new System.Drawing.Size(34, 41);
            this.lblHourTransactions.TabIndex = 3;
            this.lblHourTransactions.Text = "0";
            // 
            // lblHourTotalTransactions
            // 
            this.lblHourTotalTransactions.AutoSize = true;
            this.lblHourTotalTransactions.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourTotalTransactions.ForeColor = System.Drawing.Color.White;
            this.lblHourTotalTransactions.Location = new System.Drawing.Point(14, 138);
            this.lblHourTotalTransactions.Name = "lblHourTotalTransactions";
            this.lblHourTotalTransactions.Size = new System.Drawing.Size(166, 25);
            this.lblHourTotalTransactions.TabIndex = 2;
            this.lblHourTotalTransactions.Text = "Total Transactions";
            // 
            // lblHourTitle
            // 
            this.lblHourTitle.AutoSize = true;
            this.lblHourTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourTitle.ForeColor = System.Drawing.Color.White;
            this.lblHourTitle.Location = new System.Drawing.Point(12, 13);
            this.lblHourTitle.Name = "lblHourTitle";
            this.lblHourTitle.Size = new System.Drawing.Size(281, 38);
            this.lblHourTitle.TabIndex = 0;
            this.lblHourTitle.Text = "Transaction by Hour";
            // 
            // pnlRecentTransactions
            // 
            this.pnlRecentTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentTransactions.Controls.Add(this.lblRecentTransactions);
            this.pnlRecentTransactions.Controls.Add(this.flpRecentTransactionsHour);
            this.pnlRecentTransactions.Location = new System.Drawing.Point(3, 395);
            this.pnlRecentTransactions.Name = "pnlRecentTransactions";
            this.pnlRecentTransactions.Size = new System.Drawing.Size(1469, 298);
            this.pnlRecentTransactions.TabIndex = 4;
            // 
            // lblRecentTransactions
            // 
            this.lblRecentTransactions.AutoSize = true;
            this.lblRecentTransactions.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentTransactions.ForeColor = System.Drawing.Color.White;
            this.lblRecentTransactions.Location = new System.Drawing.Point(35, 3);
            this.lblRecentTransactions.Name = "lblRecentTransactions";
            this.lblRecentTransactions.Size = new System.Drawing.Size(275, 38);
            this.lblRecentTransactions.TabIndex = 0;
            this.lblRecentTransactions.Text = "Recent Transactions";
            // 
            // flpRecentTransactionsHour
            // 
            this.flpRecentTransactionsHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRecentTransactionsHour.AutoScroll = true;
            this.flpRecentTransactionsHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.flpRecentTransactionsHour.Location = new System.Drawing.Point(32, 44);
            this.flpRecentTransactionsHour.Name = "flpRecentTransactionsHour";
            this.flpRecentTransactionsHour.Size = new System.Drawing.Size(1411, 248);
            this.flpRecentTransactionsHour.TabIndex = 1;
            // 
            // lblDayTitle
            // 
            this.lblDayTitle.AutoSize = true;
            this.lblDayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTitle.ForeColor = System.Drawing.Color.White;
            this.lblDayTitle.Location = new System.Drawing.Point(25, 20);
            this.lblDayTitle.Name = "lblDayTitle";
            this.lblDayTitle.Size = new System.Drawing.Size(290, 32);
            this.lblDayTitle.TabIndex = 0;
            this.lblDayTitle.Text = "Transactions by Day";
            // 
            // lblDayTotalTransactions
            // 
            this.lblDayTotalTransactions.AutoSize = true;
            this.lblDayTotalTransactions.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTotalTransactions.ForeColor = System.Drawing.Color.White;
            this.lblDayTotalTransactions.Location = new System.Drawing.Point(31, 129);
            this.lblDayTotalTransactions.Name = "lblDayTotalTransactions";
            this.lblDayTotalTransactions.Size = new System.Drawing.Size(166, 25);
            this.lblDayTotalTransactions.TabIndex = 1;
            this.lblDayTotalTransactions.Text = "Total Transactions";
            // 
            // lblDayTotalRevenue
            // 
            this.lblDayTotalRevenue.AutoSize = true;
            this.lblDayTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblDayTotalRevenue.Location = new System.Drawing.Point(666, 129);
            this.lblDayTotalRevenue.Name = "lblDayTotalRevenue";
            this.lblDayTotalRevenue.Size = new System.Drawing.Size(133, 25);
            this.lblDayTotalRevenue.TabIndex = 2;
            this.lblDayTotalRevenue.Text = "Total Revenue";
            // 
            // lblDayAvgTransaction
            // 
            this.lblDayAvgTransaction.AutoSize = true;
            this.lblDayAvgTransaction.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAvgTransaction.ForeColor = System.Drawing.Color.White;
            this.lblDayAvgTransaction.Location = new System.Drawing.Point(1238, 129);
            this.lblDayAvgTransaction.Name = "lblDayAvgTransaction";
            this.lblDayAvgTransaction.Size = new System.Drawing.Size(176, 25);
            this.lblDayAvgTransaction.TabIndex = 3;
            this.lblDayAvgTransaction.Text = "Avg by Transaction";
            // 
            // lblDayTransactions
            // 
            this.lblDayTransactions.AutoSize = true;
            this.lblDayTransactions.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTransactions.ForeColor = System.Drawing.Color.White;
            this.lblDayTransactions.Location = new System.Drawing.Point(28, 154);
            this.lblDayTransactions.Name = "lblDayTransactions";
            this.lblDayTransactions.Size = new System.Drawing.Size(35, 41);
            this.lblDayTransactions.TabIndex = 4;
            this.lblDayTransactions.Text = "0";
            // 
            // lblDayRevenue
            // 
            this.lblDayRevenue.AutoSize = true;
            this.lblDayRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayRevenue.ForeColor = System.Drawing.Color.White;
            this.lblDayRevenue.Location = new System.Drawing.Point(663, 156);
            this.lblDayRevenue.Name = "lblDayRevenue";
            this.lblDayRevenue.Size = new System.Drawing.Size(105, 41);
            this.lblDayRevenue.TabIndex = 5;
            this.lblDayRevenue.Text = "R 0.00";
            // 
            // lblDayAverage
            // 
            this.lblDayAverage.AutoSize = true;
            this.lblDayAverage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAverage.ForeColor = System.Drawing.Color.White;
            this.lblDayAverage.Location = new System.Drawing.Point(1235, 154);
            this.lblDayAverage.Name = "lblDayAverage";
            this.lblDayAverage.Size = new System.Drawing.Size(105, 41);
            this.lblDayAverage.TabIndex = 6;
            this.lblDayAverage.Text = "R 0.00";
            // 
            // pnlByDay
            // 
            this.pnlByDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlByDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.pnlByDay.Controls.Add(this.lblDayAverage);
            this.pnlByDay.Controls.Add(this.lblDayRevenue);
            this.pnlByDay.Controls.Add(this.lblDayTransactions);
            this.pnlByDay.Controls.Add(this.lblDayAvgTransaction);
            this.pnlByDay.Controls.Add(this.lblDayTotalRevenue);
            this.pnlByDay.Controls.Add(this.lblDayTotalTransactions);
            this.pnlByDay.Controls.Add(this.lblDayTitle);
            this.pnlByDay.Location = new System.Drawing.Point(29, 127);
            this.pnlByDay.Name = "pnlByDay";
            this.pnlByDay.Size = new System.Drawing.Size(1442, 205);
            this.pnlByDay.TabIndex = 9;
            this.pnlByDay.Visible = false;
            this.pnlByDay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlByDay_Paint);
            // 
            // pnlByMonth
            // 
            this.pnlByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlByMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.pnlByMonth.Controls.Add(this.lblAvgTransactionMonthly);
            this.pnlByMonth.Controls.Add(this.lblMontlyRevenue);
            this.pnlByMonth.Controls.Add(this.lblTransactionsMonthly);
            this.pnlByMonth.Controls.Add(this.lblMonthlyAvgTransactions);
            this.pnlByMonth.Controls.Add(this.lblTotalMonthlyRevenue);
            this.pnlByMonth.Controls.Add(this.lblMonthlyTotalTransactions);
            this.pnlByMonth.Controls.Add(this.lblMonthlyTransaction);
            this.pnlByMonth.Location = new System.Drawing.Point(29, 127);
            this.pnlByMonth.Name = "pnlByMonth";
            this.pnlByMonth.Size = new System.Drawing.Size(1443, 205);
            this.pnlByMonth.TabIndex = 10;
            this.pnlByMonth.Visible = false;
            // 
            // lblAvgTransactionMonthly
            // 
            this.lblAvgTransactionMonthly.AutoSize = true;
            this.lblAvgTransactionMonthly.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgTransactionMonthly.ForeColor = System.Drawing.Color.White;
            this.lblAvgTransactionMonthly.Location = new System.Drawing.Point(1235, 154);
            this.lblAvgTransactionMonthly.Name = "lblAvgTransactionMonthly";
            this.lblAvgTransactionMonthly.Size = new System.Drawing.Size(105, 41);
            this.lblAvgTransactionMonthly.TabIndex = 6;
            this.lblAvgTransactionMonthly.Text = "R 0.00";
            // 
            // lblMontlyRevenue
            // 
            this.lblMontlyRevenue.AutoSize = true;
            this.lblMontlyRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontlyRevenue.ForeColor = System.Drawing.Color.White;
            this.lblMontlyRevenue.Location = new System.Drawing.Point(663, 156);
            this.lblMontlyRevenue.Name = "lblMontlyRevenue";
            this.lblMontlyRevenue.Size = new System.Drawing.Size(105, 41);
            this.lblMontlyRevenue.TabIndex = 5;
            this.lblMontlyRevenue.Text = "R 0.00";
            // 
            // lblTransactionsMonthly
            // 
            this.lblTransactionsMonthly.AutoSize = true;
            this.lblTransactionsMonthly.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionsMonthly.ForeColor = System.Drawing.Color.White;
            this.lblTransactionsMonthly.Location = new System.Drawing.Point(28, 154);
            this.lblTransactionsMonthly.Name = "lblTransactionsMonthly";
            this.lblTransactionsMonthly.Size = new System.Drawing.Size(35, 41);
            this.lblTransactionsMonthly.TabIndex = 4;
            this.lblTransactionsMonthly.Text = "0";
            // 
            // lblMonthlyAvgTransactions
            // 
            this.lblMonthlyAvgTransactions.AutoSize = true;
            this.lblMonthlyAvgTransactions.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAvgTransactions.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyAvgTransactions.Location = new System.Drawing.Point(1238, 129);
            this.lblMonthlyAvgTransactions.Name = "lblMonthlyAvgTransactions";
            this.lblMonthlyAvgTransactions.Size = new System.Drawing.Size(176, 25);
            this.lblMonthlyAvgTransactions.TabIndex = 3;
            this.lblMonthlyAvgTransactions.Text = "Avg by Transaction";
            // 
            // lblTotalMonthlyRevenue
            // 
            this.lblTotalMonthlyRevenue.AutoSize = true;
            this.lblTotalMonthlyRevenue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMonthlyRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalMonthlyRevenue.Location = new System.Drawing.Point(666, 129);
            this.lblTotalMonthlyRevenue.Name = "lblTotalMonthlyRevenue";
            this.lblTotalMonthlyRevenue.Size = new System.Drawing.Size(133, 25);
            this.lblTotalMonthlyRevenue.TabIndex = 2;
            this.lblTotalMonthlyRevenue.Text = "Total Revenue";
            // 
            // lblMonthlyTotalTransactions
            // 
            this.lblMonthlyTotalTransactions.AutoSize = true;
            this.lblMonthlyTotalTransactions.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTotalTransactions.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyTotalTransactions.Location = new System.Drawing.Point(31, 129);
            this.lblMonthlyTotalTransactions.Name = "lblMonthlyTotalTransactions";
            this.lblMonthlyTotalTransactions.Size = new System.Drawing.Size(166, 25);
            this.lblMonthlyTotalTransactions.TabIndex = 1;
            this.lblMonthlyTotalTransactions.Text = "Total Transactions";
            // 
            // lblMonthlyTransaction
            // 
            this.lblMonthlyTransaction.AutoSize = true;
            this.lblMonthlyTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyTransaction.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyTransaction.Location = new System.Drawing.Point(25, 20);
            this.lblMonthlyTransaction.Name = "lblMonthlyTransaction";
            this.lblMonthlyTransaction.Size = new System.Drawing.Size(321, 32);
            this.lblMonthlyTransaction.TabIndex = 0;
            this.lblMonthlyTransaction.Text = "Transactions by Month";
            // 
            // pnlRecentTransactionDay
            // 
            this.pnlRecentTransactionDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentTransactionDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnlRecentTransactionDay.Controls.Add(this.lblRecentTransactionsDay);
            this.pnlRecentTransactionDay.Controls.Add(this.flpRecentTransactionDay);
            this.pnlRecentTransactionDay.Location = new System.Drawing.Point(3, 395);
            this.pnlRecentTransactionDay.Name = "pnlRecentTransactionDay";
            this.pnlRecentTransactionDay.Size = new System.Drawing.Size(1469, 295);
            this.pnlRecentTransactionDay.TabIndex = 11;
            // 
            // lblRecentTransactionsDay
            // 
            this.lblRecentTransactionsDay.AutoSize = true;
            this.lblRecentTransactionsDay.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentTransactionsDay.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentTransactionsDay.ForeColor = System.Drawing.Color.White;
            this.lblRecentTransactionsDay.Location = new System.Drawing.Point(9, 20);
            this.lblRecentTransactionsDay.Name = "lblRecentTransactionsDay";
            this.lblRecentTransactionsDay.Size = new System.Drawing.Size(262, 38);
            this.lblRecentTransactionsDay.TabIndex = 1;
            this.lblRecentTransactionsDay.Text = "Recent Transations";
            // 
            // flpRecentTransactionDay
            // 
            this.flpRecentTransactionDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRecentTransactionDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.flpRecentTransactionDay.Location = new System.Drawing.Point(9, 61);
            this.flpRecentTransactionDay.Name = "flpRecentTransactionDay";
            this.flpRecentTransactionDay.Size = new System.Drawing.Size(1457, 231);
            this.flpRecentTransactionDay.TabIndex = 0;
            // 
            // pnlMonthlyRecentTransactions
            // 
            this.pnlMonthlyRecentTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMonthlyRecentTransactions.Controls.Add(this.flpRecentTransactionMonthly);
            this.pnlMonthlyRecentTransactions.Controls.Add(this.lblRecentTransactionMonthly);
            this.pnlMonthlyRecentTransactions.Location = new System.Drawing.Point(3, 398);
            this.pnlMonthlyRecentTransactions.Name = "pnlMonthlyRecentTransactions";
            this.pnlMonthlyRecentTransactions.Size = new System.Drawing.Size(1469, 292);
            this.pnlMonthlyRecentTransactions.TabIndex = 12;
            // 
            // flpRecentTransactionMonthly
            // 
            this.flpRecentTransactionMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRecentTransactionMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.flpRecentTransactionMonthly.Location = new System.Drawing.Point(0, 41);
            this.flpRecentTransactionMonthly.Name = "flpRecentTransactionMonthly";
            this.flpRecentTransactionMonthly.Size = new System.Drawing.Size(1466, 248);
            this.flpRecentTransactionMonthly.TabIndex = 1;
            // 
            // lblRecentTransactionMonthly
            // 
            this.lblRecentTransactionMonthly.AutoSize = true;
            this.lblRecentTransactionMonthly.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentTransactionMonthly.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentTransactionMonthly.ForeColor = System.Drawing.Color.White;
            this.lblRecentTransactionMonthly.Location = new System.Drawing.Point(9, 0);
            this.lblRecentTransactionMonthly.Name = "lblRecentTransactionMonthly";
            this.lblRecentTransactionMonthly.Size = new System.Drawing.Size(263, 38);
            this.lblRecentTransactionMonthly.TabIndex = 0;
            this.lblRecentTransactionMonthly.Text = "Recent Transaction";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1457, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "↩️ Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1544, 741);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnByMonth);
            this.Controls.Add(this.btnByDay);
            this.Controls.Add(this.btnByHour);
            this.Controls.Add(this.pnlByMonth);
            this.Controls.Add(this.pnlRecentTransactionDay);
            this.Controls.Add(this.pnlRecentTransactions);
            this.Controls.Add(this.pnlMonthlyRecentTransactions);
            this.Controls.Add(this.pnlByDay);
            this.Controls.Add(this.pnlByHour);
            this.Name = "frmAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlByHour.ResumeLayout(false);
            this.pnlByHour.PerformLayout();
            this.pnlRecentTransactions.ResumeLayout(false);
            this.pnlRecentTransactions.PerformLayout();
            this.pnlByDay.ResumeLayout(false);
            this.pnlByDay.PerformLayout();
            this.pnlByMonth.ResumeLayout(false);
            this.pnlByMonth.PerformLayout();
            this.pnlRecentTransactionDay.ResumeLayout(false);
            this.pnlRecentTransactionDay.PerformLayout();
            this.pnlMonthlyRecentTransactions.ResumeLayout(false);
            this.pnlMonthlyRecentTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnByHour;
        private System.Windows.Forms.Button btnByDay;
        private System.Windows.Forms.Button btnByMonth;
        private System.Windows.Forms.Panel pnlByHour;
        private System.Windows.Forms.Label lblHourTitle;
        private System.Windows.Forms.Label lblHourTotalTransactions;
        private System.Windows.Forms.Label lblHourTransactions;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblRevenueHour;
        private System.Windows.Forms.Label lblHourAvgTransaction;
        private System.Windows.Forms.Label lblHourTransaction;
        private System.Windows.Forms.Panel pnlRecentTransactions;
        private System.Windows.Forms.Label lblRecentTransactions;
        private System.Windows.Forms.FlowLayoutPanel flpRecentTransactionsHour;
        private System.Windows.Forms.Label lblDayTitle;
        private System.Windows.Forms.Label lblDayTotalTransactions;
        private System.Windows.Forms.Label lblDayTotalRevenue;
        private System.Windows.Forms.Label lblDayAvgTransaction;
        private System.Windows.Forms.Label lblDayTransactions;
        private System.Windows.Forms.Label lblDayRevenue;
        private System.Windows.Forms.Label lblDayAverage;
        private System.Windows.Forms.Panel pnlByDay;
        private System.Windows.Forms.Panel pnlByMonth;
        private System.Windows.Forms.Label lblAvgTransactionMonthly;
        private System.Windows.Forms.Label lblMontlyRevenue;
        private System.Windows.Forms.Label lblTransactionsMonthly;
        private System.Windows.Forms.Label lblMonthlyAvgTransactions;
        private System.Windows.Forms.Label lblTotalMonthlyRevenue;
        private System.Windows.Forms.Label lblMonthlyTotalTransactions;
        private System.Windows.Forms.Label lblMonthlyTransaction;
        private System.Windows.Forms.Panel pnlRecentTransactionDay;
        private System.Windows.Forms.FlowLayoutPanel flpRecentTransactionDay;
        private System.Windows.Forms.Label lblRecentTransactionsDay;
        private System.Windows.Forms.Panel pnlMonthlyRecentTransactions;
        private System.Windows.Forms.Label lblRecentTransactionMonthly;
        private System.Windows.Forms.FlowLayoutPanel flpRecentTransactionMonthly;
        private System.Windows.Forms.Button btnBack;
    }
}