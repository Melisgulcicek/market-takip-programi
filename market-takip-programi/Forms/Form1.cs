using market_takip_programi.Forms;
using market_takip_programi.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace market_takip_programi
{
    public partial class Form1 : Form
    {
        AppDbContext db = new();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void saveProdBtn_Click(object sender, EventArgs e)
        {
            if(prod_count_input.Text.Length!=0&& int.TryParse(prod_count_input.Text, out _)&& prod_name_input.Text.Length != 0 && prod_price_input.Text.Length != 0 && int.TryParse(prod_price_input.Text, out _))
            {
                var prod = new Product()
                {

                    Name = prod_name_input.Text,
                    StockQuantity = Convert.ToInt32(prod_count_input.Text),
                    Price = Convert.ToInt32(prod_price_input.Text),



                };
                db.Product.Add(prod);
                
                var item = new Account()
                {

                    ItemName = prod_name_input.Text,
                    ItemStock = Convert.ToInt32(prod_count_input.Text),
                    ItemPrice = Convert.ToInt32(prod_price_input.Text),
                    ProductId = prod.ProductId,




                };
                db.Account.Add(item);
                db.SaveChanges();
                MessageBox.Show("Ürün kaydedildi.");
            }
            else
            {
                MessageBox.Show("Girdi kýsýmlarýnda hata var kontrol ediniz.");
            }
            
        }

        private void salesPanel_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();

            mainPanel.Controls.Clear();
            salesForm.TopLevel = false;
            mainPanel.Controls.Add(salesForm);
            salesForm.WindowState = FormWindowState.Maximized;
            salesForm.FormBorderStyle = FormBorderStyle.None;
            salesForm.Show();

        }

        private void openProductPanelBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(productPanel);
        }

        private void openEnvanterPanelBtn_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            mainPanel.Controls.Clear();
            inventoryForm.TopLevel = false;
            mainPanel.Controls.Add(inventoryForm);
            inventoryForm.WindowState = FormWindowState.Maximized;
            inventoryForm.FormBorderStyle = FormBorderStyle.None;
            inventoryForm.Show();
        }

        
    }
}