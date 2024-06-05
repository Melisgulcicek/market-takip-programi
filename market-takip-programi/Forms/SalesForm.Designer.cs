namespace market_takip_programi.Forms
{
    partial class SalesForm
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
            this.salesMainPanel = new System.Windows.Forms.Panel();
            this.addSalesPanel = new System.Windows.Forms.Panel();
            this.add_sale_btn = new System.Windows.Forms.Button();
            this.prod_count_sale_input = new System.Windows.Forms.TextBox();
            this.prod_price_sale_input = new System.Windows.Forms.TextBox();
            this.prod_id_sale_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodListView = new System.Windows.Forms.DataGridView();
            this.salesMainPanel.SuspendLayout();
            this.addSalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodListView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesMainPanel
            // 
            this.salesMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.salesMainPanel.Controls.Add(this.addSalesPanel);
            this.salesMainPanel.Controls.Add(this.label1);
            this.salesMainPanel.Controls.Add(this.prodListView);
            this.salesMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesMainPanel.Location = new System.Drawing.Point(0, 0);
            this.salesMainPanel.Name = "salesMainPanel";
            this.salesMainPanel.Size = new System.Drawing.Size(1158, 565);
            this.salesMainPanel.TabIndex = 0;
            // 
            // addSalesPanel
            // 
            this.addSalesPanel.Controls.Add(this.add_sale_btn);
            this.addSalesPanel.Controls.Add(this.prod_count_sale_input);
            this.addSalesPanel.Controls.Add(this.prod_price_sale_input);
            this.addSalesPanel.Controls.Add(this.prod_id_sale_input);
            this.addSalesPanel.Location = new System.Drawing.Point(309, 373);
            this.addSalesPanel.Name = "addSalesPanel";
            this.addSalesPanel.Size = new System.Drawing.Size(534, 244);
            this.addSalesPanel.TabIndex = 15;
            // 
            // add_sale_btn
            // 
            this.add_sale_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_sale_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_sale_btn.Location = new System.Drawing.Point(189, 167);
            this.add_sale_btn.Name = "add_sale_btn";
            this.add_sale_btn.Size = new System.Drawing.Size(153, 64);
            this.add_sale_btn.TabIndex = 16;
            this.add_sale_btn.Text = "Satış Ekle";
            this.add_sale_btn.UseVisualStyleBackColor = true;
            this.add_sale_btn.Click += new System.EventHandler(this.addSaleBtn_Click);
            // 
            // prod_count_sale_input
            // 
            this.prod_count_sale_input.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prod_count_sale_input.Location = new System.Drawing.Point(189, 35);
            this.prod_count_sale_input.Multiline = true;
            this.prod_count_sale_input.Name = "prod_count_sale_input";
            this.prod_count_sale_input.PlaceholderText = "Satış Adedi";
            this.prod_count_sale_input.Size = new System.Drawing.Size(153, 50);
            this.prod_count_sale_input.TabIndex = 18;
            // 
            // prod_price_sale_input
            // 
            this.prod_price_sale_input.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prod_price_sale_input.Location = new System.Drawing.Point(348, 35);
            this.prod_price_sale_input.Multiline = true;
            this.prod_price_sale_input.Name = "prod_price_sale_input";
            this.prod_price_sale_input.PlaceholderText = "Satış Fiyatı";
            this.prod_price_sale_input.Size = new System.Drawing.Size(153, 50);
            this.prod_price_sale_input.TabIndex = 17;
            // 
            // prod_id_sale_input
            // 
            this.prod_id_sale_input.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prod_id_sale_input.Location = new System.Drawing.Point(30, 35);
            this.prod_id_sale_input.Multiline = true;
            this.prod_id_sale_input.Name = "prod_id_sale_input";
            this.prod_id_sale_input.PlaceholderText = "Ürün Id";
            this.prod_id_sale_input.Size = new System.Drawing.Size(153, 50);
            this.prod_id_sale_input.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(309, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Listesi";
            // 
            // prodListView
            // 
            this.prodListView.AllowUserToAddRows = false;
            this.prodListView.AllowUserToDeleteRows = false;
            this.prodListView.AllowUserToResizeColumns = false;
            this.prodListView.AllowUserToResizeRows = false;
            this.prodListView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.prodListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodListView.Location = new System.Drawing.Point(309, 113);
            this.prodListView.Name = "prodListView";
            this.prodListView.ReadOnly = true;
            this.prodListView.RowHeadersWidth = 10;
            this.prodListView.RowTemplate.Height = 29;
            this.prodListView.Size = new System.Drawing.Size(534, 244);
            this.prodListView.TabIndex = 13;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1158, 565);
            this.Controls.Add(this.salesMainPanel);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.salesMainPanel.ResumeLayout(false);
            this.salesMainPanel.PerformLayout();
            this.addSalesPanel.ResumeLayout(false);
            this.addSalesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel salesMainPanel;
        public DataGridView prodListView;
        private Label label1;
        private Panel addSalesPanel;
        private TextBox prod_id_sale_input;
        private TextBox prod_count_sale_input;
        private TextBox prod_price_sale_input;
        private Button add_sale_btn;
    }
}