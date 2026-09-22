using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FreshMartKiosk
{
    public class FormKiosk : Form
    {
        private ShoppingCart cart = new ShoppingCart();
        private TextBox txtSearch;
        private FlowLayoutPanel productsFlow, cartFlow, catPanel;
        private Label lblSubtotal, lblTax, lblTotal, lblCount, lblTime;

        public FormKiosk()
        {
            Text = "FreshMart Kiosk"; WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(13, 19, 38);
            BuildUI(); LoadProducts("All"); RenderCart();
            var t = new Timer(); t.Interval = 1000; t.Tick += (s, e) => { if (lblTime != null) lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); }; t.Start();
        }

        void BuildUI()
        {
            var header = new Panel { Dock = DockStyle.Top, Height = 45, BackColor = Color.FromArgb(13, 19, 38) };
            var circleF = new Panel { Width = 28, Height = 28, Left = 14, Top = 8, BackColor = Color.FromArgb(13, 19, 38) };
            circleF.Paint += (s, e) => { e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(46, 204, 113)), 0, 0, 28, 28); e.Graphics.DrawString("F", new Font("Segoe UI", 10, FontStyle.Bold), Brushes.White, 7, 3); };
            var lblBrand = new Label { Text = "FreshMart", ForeColor = Color.White, Font = new Font("Segoe UI", 11, FontStyle.Bold), Left = 50, Top = 11, AutoSize = true };
            lblTime = new Label { Text = DateTime.Now.ToString("hh:mm:ss tt"), ForeColor = Color.White, Font = new Font("Consolas", 10), AutoSize = true, Left = 550, Top = 13, Anchor = AnchorStyles.Top };
            var lblCancel = new Label { Text = "X Cancel Transaction", ForeColor = Color.FromArgb(255, 100, 100), Font = new Font("Segoe UI", 9), AutoSize = true, Cursor = Cursors.Hand, Anchor = AnchorStyles.Top | AnchorStyles.Right, Left = 1120, Top = 14 };
            lblCancel.Click += (s, e) => { cart.ClearCart(); RenderCart(); };
            header.Controls.Add(lblCancel); header.Controls.Add(lblTime); header.Controls.Add(lblBrand); header.Controls.Add(circleF);

            var secondBar = new Panel { Dock = DockStyle.Top, Height = 52, BackColor = Color.FromArgb(13, 19, 38) };
            var cartHeader = new Panel { Dock = DockStyle.Right, Width = 380, BackColor = Color.FromArgb(20, 28, 58) };
            cartHeader.Controls.Add(new Label { Text = "Your Cart", ForeColor = Color.White, Font = new Font("Segoe UI", 11, FontStyle.Bold), Left = 12, Top = 15, AutoSize = true });
            lblCount = new Label { Text = "0/10 items", ForeColor = Color.Gray, Left = 280, Top = 18, AutoSize = true, Font = new Font("Segoe UI", 8) }; cartHeader.Controls.Add(lblCount);
            var leftSearch = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(13, 19, 38), Padding = new Padding(14, 8, 8, 8) };
            var btnScan = new Button { Text = "Scan", Width = 85, Height = 32, Dock = DockStyle.Right, BackColor = Color.FromArgb(0, 140, 255), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Margin = new Padding(6, 0, 0, 0), Font = new Font("Segoe UI", 8, FontStyle.Bold) }; btnScan.FlatAppearance.BorderSize = 0;
            var btnAdd = new Button { Text = "Add Item", Width = 85, Height = 32, Dock = DockStyle.Right, BackColor = Color.FromArgb(46, 204, 113), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Margin = new Padding(6, 0, 0, 0), Font = new Font("Segoe UI", 8, FontStyle.Bold) }; btnAdd.FlatAppearance.BorderSize = 0;
            txtSearch = new TextBox { Dock = DockStyle.Fill, BackColor = Color.FromArgb(45, 60, 85), ForeColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Font = new Font("Consolas", 10) };
            txtSearch.Text = "Enter item code (e.g. P001) and press Enter...";
            txtSearch.GotFocus += (s, e) => { if (txtSearch.Text.Contains("Enter")) txtSearch.Text = ""; };
            txtSearch.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearch.Text)) txtSearch.Text = "Enter item code (e.g. P001) and press Enter..."; };
            txtSearch.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { HandleScan(txtSearch.Text); e.SuppressKeyPress = true; } };
            btnAdd.Click += (s, e) => HandleScan(txtSearch.Text); btnScan.Click += (s, e) => HandleScan(txtSearch.Text);
            leftSearch.Controls.Add(txtSearch); leftSearch.Controls.Add(btnAdd); leftSearch.Controls.Add(btnScan);
            secondBar.Controls.Add(leftSearch); secondBar.Controls.Add(cartHeader);

            var catBar = new Panel { Dock = DockStyle.Top, Height = 38, BackColor = Color.FromArgb(13, 19, 38), Padding = new Padding(14, 4, 0, 4) };
            catPanel = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.LeftToRight, WrapContents = false, BackColor = Color.FromArgb(13, 19, 38) };
            string[] cats = new[] { "All", "Dairy", "Bakery", "Produce", "Meat", "Seafood", "Beverages", "Pantry", "Snacks" };
            foreach (var c in cats)
            {
                var b = new Button { Text = c, Height = 28, AutoSize = true, BackColor = c == "All" ? Color.FromArgb(46, 204, 113) : Color.FromArgb(30, 42, 74), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 8), Margin = new Padding(0, 0, 6, 0), Padding = new Padding(10, 0, 10, 0) };
                b.FlatAppearance.BorderSize = 0; string cat = c;
                b.Click += (s, e) => { foreach (Button x in catPanel.Controls) x.BackColor = Color.FromArgb(30, 42, 74); ((Button)s).BackColor = Color.FromArgb(46, 204, 113); LoadProducts(cat); };
                catPanel.Controls.Add(b);
            }
            catBar.Controls.Add(catPanel);

            var main = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(13, 19, 38) };
            var cartPanel = new Panel { Dock = DockStyle.Right, Width = 380, BackColor = Color.FromArgb(20, 28, 58) };
            var summary = new Panel { Dock = DockStyle.Bottom, Height = 150, BackColor = Color.FromArgb(20, 28, 58), Padding = new Padding(12, 8, 12, 12) };
            lblSubtotal = new Label { Dock = DockStyle.Top, Height = 22, ForeColor = Color.Gray, Font = new Font("Segoe UI", 8) };
            lblTax = new Label { Dock = DockStyle.Top, Height = 22, ForeColor = Color.Gray, Font = new Font("Segoe UI", 8) };
            var sep = new Panel { Dock = DockStyle.Top, Height = 1, BackColor = Color.FromArgb(40, 50, 80), Margin = new Padding(0, 6, 0, 6) };
            lblTotal = new Label { Dock = DockStyle.Top, Height = 30, ForeColor = Color.White, Font = new Font("Segoe UI", 11, FontStyle.Bold) };
            var btnCheckout = new Button { Text = "Proceed to Checkout", Dock = DockStyle.Bottom, Height = 38, BackColor = Color.FromArgb(46, 204, 113), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 9, FontStyle.Bold) }; btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.Click += (s, e) => { if (cart.Items.Count == 0) MessageBox.Show("Cart empty"); else MessageBox.Show($"Pay R {cart.CalculateSubtotal() * 1.15m:0.00}"); };
            summary.Controls.Add(btnCheckout); summary.Controls.Add(lblTotal); summary.Controls.Add(sep); summary.Controls.Add(lblTax); summary.Controls.Add(lblSubtotal);
            cartFlow = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true, BackColor = Color.FromArgb(20, 28, 58), Padding = new Padding(8) };
            cartPanel.Controls.Add(cartFlow); cartPanel.Controls.Add(summary);
            productsFlow = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = Color.FromArgb(13, 19, 38), Padding = new Padding(10) };
            main.Controls.Add(productsFlow); main.Controls.Add(cartPanel);
            Controls.Add(main); Controls.Add(catBar); Controls.Add(secondBar); Controls.Add(header);
        }

        void LoadProducts(string cat) { productsFlow.Controls.Clear(); var list = cat == "All" ? cart.Catalog : cart.Catalog.Where(p => p.Category == cat).ToList(); foreach (var p in list) productsFlow.Controls.Add(CreateCard(p)); }

        void HandleScan(string c)
        {
            if (string.IsNullOrWhiteSpace(c) || c.Contains("Enter")) return;
            var prod = cart.FindProductByBarcode(c.Trim());
            if (prod != null)
            {
                if (!cart.AddProduct(prod, 1)) { MessageBox.Show("Cart limit reached! Max 10 items only.", "Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                RenderCart(); txtSearch.Clear(); txtSearch.Focus();
            }
            else MessageBox.Show($"Not found: {c}");
        }

        void RenderCart()
        {
            cartFlow.Controls.Clear(); int count = cart.Items.Sum(i => i.Quantity); decimal sub = cart.CalculateSubtotal(); decimal tax = sub * 0.15m; decimal tot = sub + tax;
            if (cart.Items.Count == 0)
            {
                var empty = new Panel { Width = 350, Height = 250, BackColor = Color.FromArgb(20, 28, 58) };
                empty.Controls.Add(new Label { Text = "🛒", Font = new Font("Segoe UI", 28), ForeColor = Color.FromArgb(80, 90, 110), Width = 350, Height = 50, Top = 30, TextAlign = ContentAlignment.MiddleCenter });
                empty.Controls.Add(new Label { Text = "Your cart is empty", ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), Width = 350, Top = 85, Height = 24, TextAlign = ContentAlignment.MiddleCenter });
                cartFlow.Controls.Add(empty);
            }
            else foreach (var it in cart.Items) { var r = new Panel { Width = 345, Height = 45, BackColor = Color.FromArgb(30, 42, 74), Margin = new Padding(0, 0, 0, 5) }; r.Controls.Add(new Label { Text = $"{it.Product.ProductName} x{it.Quantity} = R {it.TotalPrice:0.00}", ForeColor = Color.White, Dock = DockStyle.Fill, Padding = new Padding(6, 6, 0, 0), Font = new Font("Segoe UI", 8) }); var bx = new Button { Text = "X", Width = 30, Dock = DockStyle.Right, FlatStyle = FlatStyle.Flat, ForeColor = Color.FromArgb(255, 80, 80) }; bx.FlatAppearance.BorderSize = 0; bx.Click += (s, e) => { cart.RemoveProduct(it.Product.ProductId); RenderCart(); }; r.Controls.Add(bx); cartFlow.Controls.Add(r); }
            lblCount.Text = $"{count}/10 items"; lblSubtotal.Text = $"Subtotal ({count} items)".PadRight(25) + $"R {sub:0.00}"; lblTax.Text = $"Tax (15% VAT)".PadRight(28) + $"R {tax:0.00}"; lblTotal.Text = $"Total".PadRight(32) + $"R {tot:0.00}";
        }

        Panel CreateCard(Product p)
        {
            var card = new Panel { Width = 235, Height = 270, BackColor = Color.White, Margin = new Padding(10) };
            var pic = new PictureBox { Dock = DockStyle.Top, Height = 180, BackColor = Color.White, SizeMode = PictureBoxSizeMode.Zoom };

            string folder = Path.Combine(Application.StartupPath, "Images");
            foreach (var ext in new[] { ".jpg", ".jpeg", ".png" })
            {
                var fp = Path.Combine(folder, p.ProductId + ext);
                if (File.Exists(fp))
                {
                    try { using (var b = new Bitmap(fp)) pic.Image = new Bitmap(b); break; } catch { }
                }
            }

            // Bottom info panel (name + price), taller now to make room for the qty stepper below it
            var bottom = new Panel { Dock = DockStyle.Bottom, Height = 85, BackColor = Color.FromArgb(15, 30, 65) };
            var name = new Label { Text = p.ProductName, Dock = DockStyle.Top, Height = 22, ForeColor = Color.White, Font = new Font("Segoe UI", 8, FontStyle.Bold), Padding = new Padding(6, 4, 0, 0) };
            var price = new Label { Text = $"R {p.Price:0.00}", Dock = DockStyle.Top, Height = 20, ForeColor = Color.FromArgb(90, 230, 90), Font = new Font("Segoe UI", 9, FontStyle.Bold), Padding = new Padding(6, 0, 0, 0) };

            // Quantity stepper: [-] [qty] [+]
            var qtyPanel = new Panel { Dock = DockStyle.Bottom, Height = 34, BackColor = Color.FromArgb(15, 30, 65), Padding = new Padding(6, 2, 6, 4) };
            var btnMinus = new Button { Text = "-", Width = 34, Height = 26, Left = 0, Top = 2, BackColor = Color.FromArgb(45, 60, 85), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnMinus.FlatAppearance.BorderSize = 0;
            var lblQty = new Label { Text = "1", Width = 40, Height = 26, Left = 40, Top = 2, TextAlign = ContentAlignment.MiddleCenter, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            var btnPlus = new Button { Text = "+", Width = 34, Height = 26, Left = 86, Top = 2, BackColor = Color.FromArgb(0, 140, 255), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnPlus.FlatAppearance.BorderSize = 0;

            btnMinus.Click += (s, e) =>
            {
                int q = int.Parse(lblQty.Text);
                if (q > 1) { q--; lblQty.Text = q.ToString(); }
            };

            btnPlus.Click += (s, e) =>
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to add {p.ProductName} to the cart?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    if (!cart.AddProduct(p, 1))
                    {
                        MessageBox.Show("Cart limit reached! Max 10 items only.", "Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int q = int.Parse(lblQty.Text);
                    q++; lblQty.Text = q.ToString();
                    RenderCart();
                }
            };

            qtyPanel.Controls.Add(btnMinus);
            qtyPanel.Controls.Add(lblQty);
            qtyPanel.Controls.Add(btnPlus);

            bottom.Controls.Add(qtyPanel);
            bottom.Controls.Add(price);
            bottom.Controls.Add(name);
            card.Controls.Add(bottom);
            card.Controls.Add(pic);

            return card;
        }
    }
}