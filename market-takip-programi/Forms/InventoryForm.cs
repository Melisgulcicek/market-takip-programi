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

namespace market_takip_programi.Forms
{
    public partial class InventoryForm : Form
    {
        AppDbContext db = new();
        public InventoryForm()
        {
            InitializeComponent();
            List<Product> prodList = db.Product.ToList();
            ListProducts(prodList);
            List<Sale> saleList = db.Sale.ToList();
            ListSales(saleList);

        }

        public void ListProducts(List<Product> prodList)
        {
            List<string> colmnNames = new() { "Ürünün ID", "Ürünün İsmi", "Ürünün Adedi", "Ürünün Birim Fiyatı" };
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

        public void ListSales(List<Sale> saleList)
        {
            List<string> colmnNames = new() { "Satışın ID", "Ürünün ID", "Ürünün İsmi", "Ürünün Birim Fiyatı", "Satılan Adet", "Satış Fiyatı", "Satış Tarihi" };
            foreach (string colmName in colmnNames)
            {
                DataGridViewTextBoxColumn newColmn = new DataGridViewTextBoxColumn();
                newColmn.HeaderText = colmName;
                salesListView.Columns.Add(newColmn);
            }
            //Sütunları tek tek tanımladığımız değerler ile doldurduk
            foreach (Sale sale in saleList)
            {


                DataGridViewRow newRow = new DataGridViewRow();
                // Emlak bilgilerini ilgili hücrelere yerleştirdik
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.SaleId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.ProductId });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.ProductName });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.ProductPrice });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.Quantity });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.TotalPrice });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = sale.SaleDate }).ToString("yyyy-MM-dd HH:mm:ss");

                salesListView.Rows.Add(newRow);


            }


        }

        
    }
}
