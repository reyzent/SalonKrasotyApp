namespace SalonKrasotyApp
{
    partial class AddEditSaleFrm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label saleDateLabel;
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.saleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            saleDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.ProductSale);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(87, 16);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 29;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(111, 12);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 23;
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(10, 66);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(98, 13);
            productIDLabel.TabIndex = 30;
            productIDLabel.Text = "Название товара:";
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productSaleBindingSource, "ProductID", true));
            this.productIDComboBox.DataSource = this.productBindingSource;
            this.productIDComboBox.DisplayMember = "Title";
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(111, 63);
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.productIDComboBox.TabIndex = 25;
            this.productIDComboBox.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.Product);
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(39, 93);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(69, 13);
            quantityLabel.TabIndex = 31;
            quantityLabel.Text = "Количество:";
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Location = new System.Drawing.Point(25, 43);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(83, 13);
            saleDateLabel.TabIndex = 32;
            saleDateLabel.Text = "Дата продажи:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(187, 133);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 28;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(46, 133);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSaleBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(111, 90);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 26;
            // 
            // saleDateDateTimePicker
            // 
            this.saleDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productSaleBindingSource, "SaleDate", true));
            this.saleDateDateTimePicker.Location = new System.Drawing.Point(111, 38);
            this.saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            this.saleDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.saleDateDateTimePicker.TabIndex = 24;
            // 
            // AddEditSaleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 170);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDComboBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(saleDateLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.saleDateDateTimePicker);
            this.Name = "AddEditSaleFrm";
            this.Text = "Продажа товара";
            this.Load += new System.EventHandler(this.AddEditSaleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DateTimePicker saleDateDateTimePicker;
    }
}