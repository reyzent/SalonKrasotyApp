namespace SalonKrasotyApp_2.Forms
{
    partial class ProductSalesFrm
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
            this.components = new System.ComponentModel.Container();
            this.productSaleDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrCmb = new System.Windows.Forms.ComboBox();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productSaleDataGridView
            // 
            this.productSaleDataGridView.AllowUserToAddRows = false;
            this.productSaleDataGridView.AllowUserToDeleteRows = false;
            this.productSaleDataGridView.AutoGenerateColumns = false;
            this.productSaleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSaleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.SaleDate,
            this.Product,
            this.Quantity});
            this.productSaleDataGridView.DataSource = this.productSaleBindingSource;
            this.productSaleDataGridView.Location = new System.Drawing.Point(17, 94);
            this.productSaleDataGridView.Name = "productSaleDataGridView";
            this.productSaleDataGridView.ReadOnly = true;
            this.productSaleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productSaleDataGridView.Size = new System.Drawing.Size(554, 231);
            this.productSaleDataGridView.TabIndex = 44;
            this.productSaleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.productSaleDataGridView_DataError);
            // 
            // FiltrCmb
            // 
            this.FiltrCmb.FormattingEnabled = true;
            this.FiltrCmb.Location = new System.Drawing.Point(329, 67);
            this.FiltrCmb.Name = "FiltrCmb";
            this.FiltrCmb.Size = new System.Drawing.Size(239, 21);
            this.FiltrCmb.TabIndex = 43;
            this.FiltrCmb.SelectedIndexChanged += new System.EventHandler(this.FiltrCmb_SelectedIndexChanged);
            // 
            // ProductLbl
            // 
            this.ProductLbl.AutoSize = true;
            this.ProductLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductLbl.Location = new System.Drawing.Point(62, 40);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(252, 20);
            this.ProductLbl.TabIndex = 42;
            this.ProductLbl.Text = "название продаваемого товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(207, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Продажи товара";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(310, 341);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 32);
            this.DeleteBtn.TabIndex = 37;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(166, 341);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(113, 32);
            this.EditBtn.TabIndex = 39;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(17, 341);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(118, 32);
            this.AddBtn.TabIndex = 40;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(454, 341);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(113, 32);
            this.ExitBtn.TabIndex = 38;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataSource = typeof(SalonKrasotyApp_2.ModelEF.ProductSale);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SalonKrasotyApp_2.ModelEF.Product);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Дата продажи";
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "ProductID";
            this.Product.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Product.HeaderText = "Товар";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ProductSalesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 385);
            this.Controls.Add(this.productSaleDataGridView);
            this.Controls.Add(this.FiltrCmb);
            this.Controls.Add(this.ProductLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "ProductSalesFrm";
            this.Text = "Данные о продажах товара";
            this.Load += new System.EventHandler(this.ProductSalesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSaleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productSaleDataGridView;
        private System.Windows.Forms.ComboBox FiltrCmb;
        private System.Windows.Forms.Label ProductLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}