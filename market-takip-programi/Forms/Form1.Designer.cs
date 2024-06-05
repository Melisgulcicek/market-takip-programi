namespace market_takip_programi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.open_envanter_panel = new System.Windows.Forms.Button();
            this.open_product_panel = new System.Windows.Forms.Button();
            this.open_sales_form = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.prod_name_input = new System.Windows.Forms.TextBox();
            this.prodSavePanel = new System.Windows.Forms.Panel();
            this.prod_count_input = new System.Windows.Forms.TextBox();
            this.prod_price_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.prodSavePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.menuPanel.Controls.Add(this.open_envanter_panel);
            this.menuPanel.Controls.Add(this.open_product_panel);
            this.menuPanel.Controls.Add(this.open_sales_form);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(166, 721);
            this.menuPanel.TabIndex = 0;
            // 
            // open_envanter_panel
            // 
            this.open_envanter_panel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.open_envanter_panel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.open_envanter_panel.Location = new System.Drawing.Point(12, 170);
            this.open_envanter_panel.Name = "open_envanter_panel";
            this.open_envanter_panel.Size = new System.Drawing.Size(139, 92);
            this.open_envanter_panel.TabIndex = 2;
            this.open_envanter_panel.Text = "Envanter";
            this.open_envanter_panel.UseVisualStyleBackColor = true;
            this.open_envanter_panel.Click += new System.EventHandler(this.openEnvanterPanelBtn_Click);
            // 
            // open_product_panel
            // 
            this.open_product_panel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.open_product_panel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.open_product_panel.Location = new System.Drawing.Point(12, 72);
            this.open_product_panel.Name = "open_product_panel";
            this.open_product_panel.Size = new System.Drawing.Size(139, 92);
            this.open_product_panel.TabIndex = 1;
            this.open_product_panel.Text = "Ürünler";
            this.open_product_panel.UseVisualStyleBackColor = true;
            this.open_product_panel.Click += new System.EventHandler(this.openProductPanelBtn_Click);
            // 
            // open_sales_form
            // 
            this.open_sales_form.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.open_sales_form.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.open_sales_form.Location = new System.Drawing.Point(12, 268);
            this.open_sales_form.Name = "open_sales_form";
            this.open_sales_form.Size = new System.Drawing.Size(139, 92);
            this.open_sales_form.TabIndex = 0;
            this.open_sales_form.Text = "Satışlar";
            this.open_sales_form.UseVisualStyleBackColor = true;
            this.open_sales_form.Click += new System.EventHandler(this.salesPanel_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_btn.Location = new System.Drawing.Point(170, 381);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(183, 50);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Kaydet";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.saveProdBtn_Click);
            // 
            // prod_name_input
            // 
            this.prod_name_input.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_name_input.Location = new System.Drawing.Point(170, 148);
            this.prod_name_input.Multiline = true;
            this.prod_name_input.Name = "prod_name_input";
            this.prod_name_input.PlaceholderText = "Ürün İsmi";
            this.prod_name_input.Size = new System.Drawing.Size(183, 50);
            this.prod_name_input.TabIndex = 2;
            // 
            // prodSavePanel
            // 
            this.prodSavePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.prodSavePanel.Controls.Add(this.save_btn);
            this.prodSavePanel.Controls.Add(this.prod_count_input);
            this.prodSavePanel.Controls.Add(this.prod_price_input);
            this.prodSavePanel.Controls.Add(this.label1);
            this.prodSavePanel.Controls.Add(this.prod_name_input);
            this.prodSavePanel.Location = new System.Drawing.Point(340, 120);
            this.prodSavePanel.Name = "prodSavePanel";
            this.prodSavePanel.Size = new System.Drawing.Size(522, 461);
            this.prodSavePanel.TabIndex = 4;
            // 
            // prod_count_input
            // 
            this.prod_count_input.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_count_input.Location = new System.Drawing.Point(170, 301);
            this.prod_count_input.Multiline = true;
            this.prod_count_input.Name = "prod_count_input";
            this.prod_count_input.PlaceholderText = "Ürün Adedi";
            this.prod_count_input.Size = new System.Drawing.Size(183, 50);
            this.prod_count_input.TabIndex = 5;
            // 
            // prod_price_input
            // 
            this.prod_price_input.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prod_price_input.Location = new System.Drawing.Point(170, 220);
            this.prod_price_input.Multiline = true;
            this.prod_price_input.Name = "prod_price_input";
            this.prod_price_input.PlaceholderText = "Birim Fiyat";
            this.prod_price_input.Size = new System.Drawing.Size(183, 50);
            this.prod_price_input.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Kaydetme Alanı";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.mainPanel.Controls.Add(this.productPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(166, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1182, 721);
            this.mainPanel.TabIndex = 6;
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.productPanel.Controls.Add(this.prodSavePanel);
            this.productPanel.Location = new System.Drawing.Point(3, 3);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1176, 612);
            this.productPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.prodSavePanel.ResumeLayout(false);
            this.prodSavePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Button save_btn;
        private TextBox prod_name_input;
        private Panel prodSavePanel;
        private Label label1;
        private TextBox prod_count_input;
        private TextBox prod_price_input;
        private Button open_sales_form;
        private Panel mainPanel;
        private Button open_envanter_panel;
        private Button open_product_panel;
        private Panel productPanel;
    }
}