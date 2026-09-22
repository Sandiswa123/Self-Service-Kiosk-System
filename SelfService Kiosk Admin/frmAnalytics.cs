using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
            // START WITH BY HOUR SELECTED
            btnByHour.BackColor = Color.FromArgb(0, 180, 100);
            btnByDay.BackColor = Color.FromArgb(35, 53, 80);
            btnByMonth.BackColor = Color.FromArgb(35, 53, 80);

            // Show Hour
            pnlByHour.Visible = true;
            pnlByHour.BringToFront();

            pnlRecentTransactions.Visible = true;
            pnlRecentTransactions.BringToFront();

            // Hide Day
            pnlByDay.Visible = false;
            pnlRecentTransactionDay.Visible = false;

            // Hide Month
            pnlByMonth.Visible = false;
            LoadTransactions();

        }
        private void AddTransactionRow(
    string transactionNumber,
    DateTime date,
    decimal total,
    int itemCount)
        {
            // Create one transaction row
            Panel row = new Panel();

            row.Width = flpRecentTransactionsHour.ClientSize.Width - 25;
            row.Height = 80;
            row.BackColor = Color.FromArgb(31, 49, 75);
            row.Margin = new Padding(0, 0, 0, 5);


            // Transaction number
            Label lblNumber = new Label();

            lblNumber.Text = transactionNumber;
            lblNumber.ForeColor = Color.White;
            lblNumber.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(10, 10);


            // Date and time
            Label lblDate = new Label();

            lblDate.Text =
                date.ToString("dddd, MMMM d, yyyy • hh:mm:ss tt");

            lblDate.ForeColor = Color.LightSteelBlue;
            lblDate.Font = new Font("Segoe UI", 9);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(10, 38);


            // Transaction total
            Label lblTotal = new Label();

            lblTotal.Text = "R " + total.ToString("0.00");
            lblTotal.ForeColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(row.Width - 120, 10);


            // Number of items
            Label lblItems = new Label();

            if (itemCount == 1)
            {
                lblItems.Text = "1 item";
            }
            else
            {
                lblItems.Text = itemCount + " items";
            }

            lblItems.ForeColor = Color.LightSteelBlue;
            lblItems.Font = new Font("Segoe UI", 9);
            lblItems.AutoSize = true;
            lblItems.Location = new Point(row.Width - 120, 38);


            // Add labels to the row
            row.Controls.Add(lblNumber);
            row.Controls.Add(lblDate);
            row.Controls.Add(lblTotal);
            row.Controls.Add(lblItems);


            // Add the row to Recent Transactions
            flpRecentTransactionsHour.Controls.Add(row);
        }

      
        private void LoadTransactions()
        {
            flpRecentTransactionsHour.Controls.Clear();

            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "FreshMart");

            string filePath = Path.Combine(folder, "transactions.txt");

            if (!File.Exists(filePath))
            {
                lblHourTransactions.Text = "0";
                lblRevenueHour.Text = "R 0.00";
                lblHourTransaction.Text = "R 0.00";
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            int totalTransactions = 0;
            decimal totalRevenue = 0;

            // Read from newest to oldest
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                string[] parts = lines[i].Split('|');

                if (parts.Length == 4)
                {
                    string transactionNumber = parts[0];

                    DateTime date;
                    decimal total;
                    int itemCount;

                    bool validDate = DateTime.TryParse(
                        parts[1],
                        out date);

                    bool validTotal = decimal.TryParse(
                        parts[2],
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out total);

                    bool validItems = int.TryParse(
                        parts[3],
                        out itemCount);

                    if (validDate && validTotal && validItems)
                    {
                        AddTransactionRow(
                            transactionNumber,
                            date,
                            total,
                            itemCount);

                        totalTransactions++;
                        totalRevenue += total;
                    }
                }
            }

            // Update the three values at the top
            lblHourTransactions.Text =
                totalTransactions.ToString();

            lblRevenueHour.Text =
                "R " + totalRevenue.ToString("0.00");

            if (totalTransactions > 0)
            {
                decimal average =
                    totalRevenue / totalTransactions;

                lblHourTransaction.Text =
                    "R " + average.ToString("0.00");
            }
            else
            {
                lblHourTransaction.Text = "R 0.00";
            }
        }
        private void AddDayTransactionRow(
    string transactionNumber,
    DateTime date,
    decimal total,
    int itemCount)
        {
            Panel row = new Panel();

            row.Width = flpRecentTransactionDay.ClientSize.Width - 25;
            row.Height = 80;
            row.BackColor = Color.FromArgb(31, 49, 75);
            row.Margin = new Padding(0, 0, 0, 5);

            // Transaction number
            Label lblNumber = new Label();
            lblNumber.Text = transactionNumber;
            lblNumber.ForeColor = Color.White;
            lblNumber.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(10, 10);

            // Date
            Label lblDate = new Label();
            lblDate.Text =
                date.ToString("dddd, MMMM d, yyyy • hh:mm:ss tt");

            lblDate.ForeColor = Color.LightSteelBlue;
            lblDate.Font = new Font("Segoe UI", 9);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(10, 38);

            // Total
            Label lblTotal = new Label();
            lblTotal.Text = "R " + total.ToString("0.00");
            lblTotal.ForeColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(row.Width - 120, 10);
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Items
            Label lblItems = new Label();

            if (itemCount == 1)
            {
                lblItems.Text = "1 item";
            }
            else
            {
                lblItems.Text = itemCount + " items";
            }

            lblItems.ForeColor = Color.LightSteelBlue;
            lblItems.Font = new Font("Segoe UI", 9);
            lblItems.AutoSize = true;
            lblItems.Location = new Point(row.Width - 120, 38);
            lblItems.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            row.Controls.Add(lblNumber);
            row.Controls.Add(lblDate);
            row.Controls.Add(lblTotal);
            row.Controls.Add(lblItems);

            // IMPORTANT: Day FlowLayoutPanel
            flpRecentTransactionDay.Controls.Add(row);
        }

        private void btnByDay_Click(object sender, EventArgs e)
        {
            // Button colours
            btnByHour.BackColor = Color.FromArgb(35, 53, 80);
            btnByDay.BackColor = Color.FromArgb(0, 180, 100);
            btnByMonth.BackColor = Color.FromArgb(35, 53, 80);

            // Hide Hour and Month
            pnlByHour.Visible = false;
            pnlByMonth.Visible = false;
            pnlMonthlyRecentTransactions.Visible = false;
            // Hide Hour Recent Transactions
            pnlRecentTransactions.Visible = false;

            // Show Day
            pnlByDay.Visible = true;
            pnlByDay.BringToFront();

            // Show Day Recent Transactions
            pnlRecentTransactionDay.Visible = true;
            pnlRecentTransactionDay.BringToFront();

            // Load today's information
            LoadDayAnalytics();
        }
        private void AddMonthTransactionRow(
    string transactionNumber,
    DateTime date,
    decimal total,
    int itemCount)
        {
            Panel row = new Panel();

            row.Width = flpRecentTransactionMonthly.ClientSize.Width - 25;
            row.Height = 80;
            row.BackColor = Color.FromArgb(31, 49, 75);
            row.Margin = new Padding(0, 0, 0, 5);

            // Transaction number
            Label lblNumber = new Label();
            lblNumber.Text = transactionNumber;
            lblNumber.ForeColor = Color.White;
            lblNumber.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(10, 10);

            // Date and time
            Label lblDate = new Label();
            lblDate.Text =
                date.ToString("dddd, MMMM d, yyyy • hh:mm:ss tt");

            lblDate.ForeColor = Color.LightSteelBlue;
            lblDate.Font = new Font("Segoe UI", 9);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(10, 38);

            // Total
            Label lblTotal = new Label();
            lblTotal.Text = "R " + total.ToString("0.00");
            lblTotal.ForeColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(row.Width - 120, 10);
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Number of items
            Label lblItems = new Label();

            if (itemCount == 1)
            {
                lblItems.Text = "1 item";
            }
            else
            {
                lblItems.Text = itemCount + " items";
            }

            lblItems.ForeColor = Color.LightSteelBlue;
            lblItems.Font = new Font("Segoe UI", 9);
            lblItems.AutoSize = true;
            lblItems.Location = new Point(row.Width - 120, 38);
            lblItems.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Add labels to row
            row.Controls.Add(lblNumber);
            row.Controls.Add(lblDate);
            row.Controls.Add(lblTotal);
            row.Controls.Add(lblItems);

            // Add row to Month Recent Transactions
            flpRecentTransactionMonthly.Controls.Add(row);
        }

        private void btnByHour_Click(object sender, EventArgs e)
        {
            // Button colours
            btnByHour.BackColor = Color.FromArgb(0, 180, 100);
            btnByDay.BackColor = Color.FromArgb(35, 53, 80);
            btnByMonth.BackColor = Color.FromArgb(35, 53, 80);

            // Hide Day and Month
            pnlByDay.Visible = false;
            pnlByMonth.Visible = false;
            pnlMonthlyRecentTransactions.Visible = false;
            // Hide Day Recent Transactions
            pnlRecentTransactionDay.Visible = false;

            // Show Hour
            pnlByHour.Visible = true;
            pnlByHour.BringToFront();

            // Show Hour Recent Transactions
            pnlRecentTransactions.Visible = true;
            pnlRecentTransactions.BringToFront();
        }

        private void LoadDayAnalytics()
        {
            flpRecentTransactionDay.Controls.Clear();

            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "FreshMart");

            string filePath = Path.Combine(folder, "transactions.txt");

            int todayTransactions = 0;
            decimal todayRevenue = 0;

            if (!File.Exists(filePath))
            {
                lblDayTransactions.Text = "0";
                lblDayRevenue.Text = "R 0.00";
                lblDayAverage.Text = "R 0.00";
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                string[] parts = lines[i].Split('|');

                if (parts.Length == 4)
                {
                    string transactionNumber = parts[0];

                    DateTime date;
                    decimal total;
                    int itemCount;

                    bool validDate = DateTime.TryParse(
                        parts[1],
                        out date);

                    bool validTotal = decimal.TryParse(
                        parts[2],
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out total);

                    bool validItems = int.TryParse(
                        parts[3],
                        out itemCount);

                    if (validDate && validTotal && validItems)
                    {
                        if (date.Date == DateTime.Today)
                        {
                            todayTransactions++;
                            todayRevenue += total;

                            AddDayTransactionRow(
                                transactionNumber,
                                date,
                                total,
                                itemCount);
                        }
                    }
                }
            }

            lblDayTransactions.Text =
                todayTransactions.ToString();

            lblDayRevenue.Text =
                "R " + todayRevenue.ToString("0.00");

            if (todayTransactions > 0)
            {
                decimal average =
                    todayRevenue / todayTransactions;

                lblDayAverage.Text =
                    "R " + average.ToString("0.00");
            }
            else
            {
                lblDayAverage.Text = "R 0.00";
            }
        }
        private void LoadMonthAnalytics()
        {
            // Clear old Month transactions
            flpRecentTransactionMonthly.Controls.Clear();

            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "FreshMart");

            string filePath = Path.Combine(
                folder,
                "transactions.txt");

            int monthTransactions = 0;
            decimal monthRevenue = 0;

            if (!File.Exists(filePath))
            {
                lblTransactionsMonthly.Text = "0";
                lblTotalMonthlyRevenue.Text = "R 0.00";
                lblAvgTransactionMonthly.Text = "R 0.00";
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            // Read newest transaction first
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                string[] parts = lines[i].Split('|');

                if (parts.Length == 4)
                {
                    string transactionNumber = parts[0];

                    DateTime date;
                    decimal total;
                    int itemCount;

                    bool validDate = DateTime.TryParse(
                        parts[1],
                        out date);

                    bool validTotal = decimal.TryParse(
                        parts[2],
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out total);

                    bool validItems = int.TryParse(
                        parts[3],
                        out itemCount);

                    if (validDate && validTotal && validItems)
                    {
                        // Only transactions from THIS MONTH
                        if (date.Month == DateTime.Today.Month &&
                            date.Year == DateTime.Today.Year)
                        {
                            monthTransactions++;
                            monthRevenue += total;

                            AddMonthTransactionRow(
                                transactionNumber,
                                date,
                                total,
                                itemCount);
                        }
                    }
                }
            }

            // Total transactions this month
            lblMontlyRevenue.Text =
                monthTransactions.ToString();

            // Total revenue this month
            lblMontlyRevenue.Text =
                "R " + monthRevenue.ToString("0.00");

            // Average transaction this month
            if (monthTransactions > 0)
            {
                decimal average =
                    monthRevenue / monthTransactions;

                lblMontlyRevenue.Text =
                    "R " + average.ToString("0.00");
            }
            else
            {
                lblMontlyRevenue.Text =
                    "R 0.00";
            }
        }

        private void pnlByDay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnByMonth_Click(object sender, EventArgs e)
        {
            // Button colours
            btnByHour.BackColor = Color.FromArgb(35, 53, 80);
            btnByDay.BackColor = Color.FromArgb(35, 53, 80);
            btnByMonth.BackColor = Color.FromArgb(0, 180, 100);

            // Hide Hour
            pnlByHour.Visible = false;
            pnlRecentTransactions.Visible = false;

            // Hide Day
            pnlByDay.Visible = false;
            pnlRecentTransactionDay.Visible = false;

            // Show Month
            pnlByMonth.Visible = true;
            pnlByMonth.BringToFront();

            // Show Month Recent Transactions
            pnlMonthlyRecentTransactions.Visible = true;
            pnlMonthlyRecentTransactions.BringToFront();

            // Load this month's information
            LoadMonthAnalytics();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin adminDashboard = new frmAdmin();
            adminDashboard.Show();

            this.Close();
        }
    }
}
