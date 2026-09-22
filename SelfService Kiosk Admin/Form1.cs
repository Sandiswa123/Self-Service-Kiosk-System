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
using FreshMartKiosk;

namespace Admin
{
    public partial class frmAdmin : Form
    {

        List<Product> products = new List<Product>();
        DateTime startTime;
        bool isLoadingStock = false;
        public frmAdmin()

        {

            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;
            SetupProductControls();
            UpdateProductSummary();
            startTime = DateTime.Now;
            // Start on Stock Management
            flpProducts.Visible = true;

            
            pnlSystemCtrl.Visible = false;

            // Show stock headings
            lblProductitem.Visible = true;
            lblCode.Visible = true;
            lblStock.Visible = true;
            lblPrice.Visible = true;
            lblStatus.Visible = true;
            pnlHeaderLine.Visible = true;

            // Default button colours
            btnStockMangement.BackColor = Color.FromArgb(0, 180, 100);
            btnAnalytics.BackColor = Color.FromArgb(35, 53, 80);
            btnSystemControl.BackColor = Color.FromArgb(35, 53, 80);

            flpProducts.BringToFront();
            LoadTransactionSummary();
            ProductData.LoadAvailability();
            LoadAvailabilityButtons();
            UpdateProductSummary();
            LoadProductStock();
            bool isLoadingStock = false;
        }

        private void SetupProductControls()
        {
            foreach (Control control in flpProducts.Controls)
            {
                if (control is Panel productPanel)
                {
                    foreach (Control item in productPanel.Controls)
                    {
                       
                        if (item is Button btn)
                        {
                            
                            btn.Click -= AvailabilityButton_Click;
                            btn.Click += AvailabilityButton_Click;
                        }

                       
                        if (item is NumericUpDown stock)
                        {
                            stock.Minimum = 0;
                            stock.ValueChanged -= Stock_ValueChanged;
                            stock.ValueChanged += Stock_ValueChanged;
                        }
                    }
                }
            }
        }


        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            Panel productPanel = btn.Parent as Panel;

            if (productPanel == null)
                return;

            NumericUpDown stockControl = null;
            Label productCodeLabel = null;
            // Find the NumericUpDown inside this product row
            foreach (Control control in productPanel.Controls)
            {
                if (control is NumericUpDown)
                {
                    stockControl = (NumericUpDown)control;
                    
                }
                // Find product code label
                if (control is Label && control.Name.StartsWith("lblProductCode"))
                {
                    productCodeLabel = (Label)control;
                }
            }

            if (stockControl == null)
                return;
            string productCode = productCodeLabel.Text;

            // AVAILABLE -> UNAVAILABLE
            if (btn.Text.Contains("Available"))
            {
                // Remember old stock
                stockControl.Tag = stockControl.Value;

                // Set stock to 0
                stockControl.Value = 0;
                stockControl.Enabled = false;

                // Change button
                btn.Text = "✕ Unavailable";
                btn.BackColor = Color.FromArgb(90, 25, 35);
                btn.ForeColor = Color.FromArgb(255, 80, 90);

                // Change row background
                productPanel.BackColor = Color.FromArgb(28, 22, 40);

                // ADD IT HERE
                SaveProductAvailability(productCode, false);
            }

            // UNAVAILABLE -> AVAILABLE
            else
            {
                stockControl.Enabled = true;

                // Restore previous stock
                if (stockControl.Tag != null)
                {
                    stockControl.Value = (decimal)stockControl.Tag;
                }
                else
                {
                    stockControl.Value = 1;
                }

                // Change button back
                btn.Text = "✓ Available";
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;

                // Restore row colour
                productPanel.BackColor = Color.FromArgb(29, 46, 70);

                SaveProductAvailability(productCode, true);
            }

            UpdateProductSummary();
        }




        private void Stock_ValueChanged(object sender, EventArgs e)
        {
            if (isLoadingStock)
                return;

            NumericUpDown stockControl = sender as NumericUpDown;

            if (stockControl == null)
                return;

            string productCode = "";
            Button availabilityButton = null;

            if (stockControl == numStockP001)
            {
                productCode = "P001";
                availabilityButton = btnAvailability1;
            }
            else if (stockControl == numStockP002)
            {
                productCode = "P002";
                availabilityButton = btnAvailability2;
            }
            else if (stockControl == numStockP003)
            {
                productCode = "P003";
                availabilityButton = btnAvailability3;
            }
            else if (stockControl == numStockP004)
            {
                productCode = "P004";
                availabilityButton = btnAvailability4;
            }
            else if (stockControl == numStockP005)
            {
                productCode = "P005";
                availabilityButton = btnAvailability5;
            }
            else if (stockControl == numStockP006)
            {
                productCode = "P006";
                availabilityButton = btnAvailability6;
            }
            else if (stockControl == numStockP007)
            {
                productCode = "P007";
                availabilityButton = btnAvailability7;
            }
            else if (stockControl == numStockP008)
            {
                productCode = "P008";
                availabilityButton = btnAvailability8;
            }
            else if (stockControl == numStockP009)
            {
                productCode = "P009";
                availabilityButton = btnAvailability9;
            }
            else if (stockControl == numStockP010)
            {
                productCode = "P010";
                availabilityButton = btnAvailability10;
            }
            else if (stockControl == numStockP011)
            {
                productCode = "P011";
                availabilityButton = btnAvailability11;
            }
            else if (stockControl == numStockP012)
            {
                productCode = "P012";
                availabilityButton = btnAvailability12;
            }
            else if (stockControl == numStockP013)
            {
                productCode = "P013";
                availabilityButton = btnAvailability13;
            }
            else if (stockControl == numStockP014)
            {
                productCode = "P014";
                availabilityButton = btnAvailability14;
            }
            else if (stockControl == numStockP015)
            {
                productCode = "P015";
                availabilityButton = btnAvailability15;
            }
            else if (stockControl == numStockP016)
            {
                productCode = "P016";
                availabilityButton = btnAvailability16;
            }

            if (productCode == "" || availabilityButton == null)
                return;

            // Save the new stock amount
            SaveProductStock(productCode, (int)stockControl.Value);

            // Stock reached 0
            if (stockControl.Value == 0)
            {
                availabilityButton.Text = "✕ Unavailable";
                availabilityButton.BackColor = Color.FromArgb(90, 25, 35);
                availabilityButton.ForeColor = Color.FromArgb(255, 80, 90);

                SaveProductAvailability(productCode, false);
            }
            else
            {
                // Stock is greater than 0
                availabilityButton.Text = "✓ Available";
                availabilityButton.BackColor = Color.Green;
                availabilityButton.ForeColor = Color.White;

                SaveProductAvailability(productCode, true);
            }

            UpdateProductSummary();
        }
        private void SaveProductStock(string productCode, int stock)
        {

            string folder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "FreshMart");

            Directory.CreateDirectory(folder);

            string filePath = Path.Combine(folder, "stock.txt");

            List<string> lines = new List<string>();

            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath).ToList();
            }

            // Remove the old stock value
            lines.RemoveAll(line => line.StartsWith(productCode + "|"));

            // Add the new stock value
            lines.Add(productCode + "|" + stock);

            // ACTUALLY SAVE TO stock.txt
            File.WriteAllLines(filePath, lines);

        }

        private void SaveProductAvailability(string productCode, bool available)
        {
            string folder = Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
          "FreshMart");

            Directory.CreateDirectory(folder);

            string filePath = Path.Combine(folder, "availability.txt");

            List<string> lines = new List<string>();

            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath).ToList();
            }

            // Remove the previous status for this product
            lines.RemoveAll(line => line.StartsWith(productCode + "|"));

            // Add the latest status
            lines.Add(productCode + "|" + available);

            // Save it
            File.WriteAllLines(filePath, lines);
        }

        private void LoadProductStock()
        {
            isLoadingStock = true;
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "FreshMart");

            string filePath = Path.Combine(folder, "stock.txt");

            if (!File.Exists(filePath))
            {
                isLoadingStock = false;
                return;
            }
                

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('|');

                if (parts.Length == 2)
                {
                    string code = parts[0];
                    int stock;

                    if (int.TryParse(parts[1], out stock))
                    {
                        if (code == "P001") numStockP001.Value = stock;
                        else if (code == "P002") numStockP002.Value = stock;
                        else if (code == "P003") numStockP003.Value = stock;
                        else if (code == "P004") numStockP004.Value = stock;
                        else if (code == "P005") numStockP005.Value = stock;
                        else if (code == "P006") numStockP006.Value = stock;
                        else if (code == "P007") numStockP007.Value = stock;
                        else if (code == "P008") numStockP008.Value = stock;
                        else if (code == "P009") numStockP009.Value = stock;
                        else if (code == "P010") numStockP010.Value = stock;
                        else if (code == "P011") numStockP011.Value = stock;
                        else if (code == "P012") numStockP012.Value = stock;
                        else if (code == "P013") numStockP013.Value = stock;
                        else if (code == "P014") numStockP014.Value = stock;
                        else if (code == "P015") numStockP015.Value = stock;
                        else if (code == "P016") numStockP016.Value = stock;
                    }
                }
                isLoadingStock = false;
            }
        }


        private void UpdateProductSummary()
        {
            int productsListed = 0;
            int outOfStock = 0;

            foreach (Control control in flpProducts.Controls)
            {
                if (control is Panel productPanel)
                {
                    productsListed++;

                    foreach (Control item in productPanel.Controls)
                    {
                        if (item is Button btn)
                        {
                            if (btn.Text.Contains("Unavailable"))
                            {
                                outOfStock++;
                               
                            }

                            break;
                        }
                    }
                }
            }

            lblProductValue.Text = productsListed.ToString();
            lblOutStockValue.Text = outOfStock.ToString();
        }


        private void LoadAvailabilityButtons()
        {
            UpdateAvailabilityButton(btnAvailability1, "P001");
            UpdateAvailabilityButton(btnAvailability2, "P002");
            UpdateAvailabilityButton(btnAvailability3, "P003");
            UpdateAvailabilityButton(btnAvailability4, "P004");
            UpdateAvailabilityButton(btnAvailability5, "P005");
            UpdateAvailabilityButton(btnAvailability6, "P006");
            UpdateAvailabilityButton(btnAvailability7, "P007");
            UpdateAvailabilityButton(btnAvailability8, "P008");
            UpdateAvailabilityButton(btnAvailability9, "P009");
            UpdateAvailabilityButton(btnAvailability10, "P010");
            UpdateAvailabilityButton(btnAvailability11, "P011");
            UpdateAvailabilityButton(btnAvailability12, "P012");
            UpdateAvailabilityButton(btnAvailability13, "P013");
            UpdateAvailabilityButton(btnAvailability14, "P014");
            UpdateAvailabilityButton(btnAvailability15, "P015");
            UpdateAvailabilityButton(btnAvailability16, "P016");
        }
        private void UpdateAvailabilityButton(Button button, string productCode)
        {
            Product product = ProductData.Products
                .FirstOrDefault(p => p.ProductId == productCode);

            if (product == null)
                return;

            if (product.IsAvailable)
            {
                button.Text = "√ Available";
                button.BackColor = Color.Green;
                button.ForeColor = Color.White;
            }
            else
            {
                button.Text = "Unavailable";
                button.BackColor = Color.Gray;
                button.ForeColor = Color.White;
            }
        }


        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            TimeSpan uptime = DateTime.Now - startTime;

            lblUptime.Text = uptime.Hours + "h " + uptime.Minutes + "m";
        }

        private void btnRestartSystem_Click(object sender, EventArgs e)
        {
            frmRestart restart = new frmRestart(this);
            restart.Show();

            this.Hide();
        }


        private void btnStockMangement_Click(object sender, EventArgs e)
        {


            btnStockMangement.BackColor = Color.FromArgb(0, 180, 100);
            btnAnalytics.BackColor = Color.FromArgb(35, 53, 80);
            btnSystemControl.BackColor = Color.FromArgb(35, 53, 80);

            pnlSystemCtrl.Visible = false;
            pnlSystemControl.Visible = false;

            flpProducts.Visible = true;
            flpProducts.BringToFront();

            lblProductitem.Visible = true;
            lblCode.Visible = true;
            lblStock.Visible = true;
            lblPrice.Visible = true;
            lblStatus.Visible = true;
            pnlHeaderLine.Visible = true;


        }

        private void btnSystemControl_Click(object sender, EventArgs e)
        {


            // Hide Stock Management
            flpProducts.Visible = false;
            // Hide other sections
           
            lblProduct.Visible = false;
            lblProductCode.Visible = false;
            lblStock.Visible = false;
            lblPrice.Visible = false;
            lblStatus.Visible = false;

            // Hide Analytics
           

            // Show System Control
            pnlSystemControl.Visible = true;
            pnlSystemControl.BringToFront();

            // Navigation colours
            btnSystemControl.BackColor = Color.FromArgb(0, 192, 120);
            btnStockMangement.BackColor = Color.FromArgb(15, 30, 52);
            btnAnalytics.BackColor = Color.FromArgb(15, 30, 52);


        }

        private void btnShutdownSystem_Click(object sender, EventArgs e)
        {
            frmShutdown shutdown = new frmShutdown();
            shutdown.Show();
            this.Hide();
        }

        
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            // Button colours
            btnStockMangement.BackColor = Color.FromArgb(35, 53, 80);
            btnAnalytics.BackColor = Color.FromArgb(0, 180, 100);
            btnSystemControl.BackColor = Color.FromArgb(35, 53, 80);

            // Open Analytics form
            frmAnalytics analytics = new frmAnalytics();
            analytics.Show();

            // Hide Admin form
            this.Hide();
        }

        

        private void btnExitAdmin_Click(object sender, EventArgs e)
        {
            FormWelcome welcome = new FormWelcome();
            welcome.Show();

            this.Hide();

        }

        private void btnReturnKiosk_Click(object sender, EventArgs e)
        {
            FormWelcome welcome = new FormWelcome();
            welcome.Show();

            this.Hide();
        }
        private void LoadTransactionSummary()
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "FreshMart");

            string filePath = Path.Combine(folder, "transactions.txt");

            int totalTransactions = 0;
            decimal totalRevenue = 0;

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split('|');

                    if (parts.Length >= 4)
                    {
                        totalTransactions++;

                        decimal amount;

                        if (decimal.TryParse(parts[2], out amount))
                        {
                            totalRevenue += amount;
                        }
                    }
                }
            }

            lblTransactionValue.Text = totalTransactions.ToString();

            lblRevenueValue.Text = "R " + totalRevenue.ToString("0.00");
        }

       
    }
}

       
       
    



