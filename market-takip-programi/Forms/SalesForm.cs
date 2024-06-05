using market_takip_programi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace market_takip_programi.Forms
{
    public partial class SalesForm : Form
    {
        AppDbContext db = new();
        public SalesForm()
        {
            InitializeComponent();
            List<Product> prodList = db.Product.ToList();
            ListProducts(prodList);
        }


        public void ListProducts(List<Product> prodList)
        {
            List<string> colmnNames = new() { "Ürünün ID", "Ürünün İsmi", "Ürünün Adedi", "Ürünün Fiyatı" };
            foreach (string colmName in colmnNames)
            {
                DataGridViewTextBoxColumn newColmn = new DataGridViewTextBoxColumn();
                newColmn.HeaderText = colmName;
                prodListView.Columns.Add(newColmn);
            }
            //Sütunları tek tek tanımladığımız değerler ile doldurduk
            foreach (Product prod in prodList)
            {
                

                DataGridViewRow newRow = new DataGridViewRow();
                // Emlak bilgilerini ilgili hücrelere yerleştirdik
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.ProductId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.Name });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.StockQuantity });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = prod.Price });

                prodListView.Rows.Add(newRow);


            }


        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            List<Product> prodList = db.Product.ToList();
            List<Sale> saleList = db.Sale.ToList();
            if(int.TryParse(prod_count_sale_input.Text, out _) && prod_count_sale_input.Text.Length != 0 &&Convert.ToInt32( prod_count_sale_input.Text) != 0&& int.TryParse(prod_id_sale_input.Text, out _) && prod_id_sale_input.Text.Length != 0 && Convert.ToInt32(prod_id_sale_input.Text) != 0&& int.TryParse(prod_price_sale_input.Text, out _) && prod_price_sale_input.Text.Length != 0 && Convert.ToInt32(prod_price_sale_input.Text) != 0)
            {
                var product = prodList.FirstOrDefault(p => p.ProductId == Convert.ToInt32(prod_id_sale_input.Text));
                if (product != null)
                {
                    if (Convert.ToInt32(prod_count_sale_input.Text) > product.StockQuantity)
                    {
                        MessageBox.Show("Ürün adedinden fazla satış adedi girmeyiniz");
                    }
                    else
                    {
                        var sale = new Sale()
                        {
                            ProductId = Convert.ToInt32(prod_id_sale_input.Text),
                            ProductName = product.Name,
                            ProductPrice = product.Price,
                            Quantity = Convert.ToInt32(prod_count_sale_input.Text),
                            TotalPrice = Convert.ToInt32(prod_price_sale_input.Text),
                            SaleDate = DateTime.UtcNow,



                        };
                        product.StockQuantity -= sale.Quantity;

                        db.Sale.Add(sale);
                        if (product.StockQuantity == 0)
                        {
                            db.Product.Remove(product);
                        }
                        else
                        {
                            db.Product.Update(product);
                        }


                        db.SaveChanges();
                        prodListView.Rows.Clear();
                        prodListView.Columns.Clear();
                        ListProducts(db.Product.ToList());
                        MessageBox.Show("Satış kaydedildi.");
                        
                    }

                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Girdi kısımlarında hata var kontrol ediniz.");
            }
            
            
        }
    }
}
