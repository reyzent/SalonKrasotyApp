namespace SalonKrasotyApp
{
    partial class MainFrm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SortCmb = new System.Windows.Forms.ComboBox();
            this.DownChk = new System.Windows.Forms.CheckBox();
            this.FiltrCmb = new System.Windows.Forms.ComboBox();
            this.RangeLbl = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.DelProductBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.AttachedProductBtn = new System.Windows.Forms.Button();
            this.CostChangeBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товары салона красоты";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(17, 86);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.RowTemplate.Height = 35;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(1040, 497);
            this.productDataGridView.TabIndex = 2;
            this.productDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.productDataGridView_CellFormatting);
            this.productDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.productDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ManufacturerID";
            this.dataGridViewTextBoxColumn6.DataSource = this.manufacturerBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID";
            this.dataGridViewTextBoxColumn6.Width = 135;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.Manufacturer);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cost";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 103;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SalonKrasotyApp.ModelEF.Product);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сортировка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Фильтрация";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(17, 55);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(188, 23);
            this.SearchTxt.TabIndex = 7;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // SortCmb
            // 
            this.SortCmb.FormattingEnabled = true;
            this.SortCmb.Items.AddRange(new object[] {
            "Без сортировки",
            "Название",
            "Стоимость"});
            this.SortCmb.Location = new System.Drawing.Point(282, 54);
            this.SortCmb.Name = "SortCmb";
            this.SortCmb.Size = new System.Drawing.Size(188, 24);
            this.SortCmb.TabIndex = 8;
            this.SortCmb.SelectedIndexChanged += new System.EventHandler(this.SortCmb_SelectedIndexChanged);
            // 
            // DownChk
            // 
            this.DownChk.AutoSize = true;
            this.DownChk.Location = new System.Drawing.Point(478, 56);
            this.DownChk.Name = "DownChk";
            this.DownChk.Size = new System.Drawing.Size(115, 21);
            this.DownChk.TabIndex = 9;
            this.DownChk.Text = "По убыванию";
            this.DownChk.UseVisualStyleBackColor = true;
            this.DownChk.CheckedChanged += new System.EventHandler(this.DownChk_CheckedChanged);
            // 
            // FiltrCmb
            // 
            this.FiltrCmb.FormattingEnabled = true;
            this.FiltrCmb.Location = new System.Drawing.Point(865, 56);
            this.FiltrCmb.Name = "FiltrCmb";
            this.FiltrCmb.Size = new System.Drawing.Size(188, 24);
            this.FiltrCmb.TabIndex = 10;
            this.FiltrCmb.SelectedIndexChanged += new System.EventHandler(this.FiltrCmb_SelectedIndexChanged);
            // 
            // RangeLbl
            // 
            this.RangeLbl.AutoSize = true;
            this.RangeLbl.Location = new System.Drawing.Point(447, 586);
            this.RangeLbl.Name = "RangeLbl";
            this.RangeLbl.Size = new System.Drawing.Size(120, 17);
            this.RangeLbl.TabIndex = 11;
            this.RangeLbl.Text = "////////////////////////////";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(1064, 86);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(198, 23);
            this.AddProductBtn.TabIndex = 12;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(1064, 115);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(198, 23);
            this.EditProductBtn.TabIndex = 13;
            this.EditProductBtn.Text = "Изменить товар";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // DelProductBtn
            // 
            this.DelProductBtn.Location = new System.Drawing.Point(1064, 144);
            this.DelProductBtn.Name = "DelProductBtn";
            this.DelProductBtn.Size = new System.Drawing.Size(198, 23);
            this.DelProductBtn.TabIndex = 14;
            this.DelProductBtn.Text = "Удалить товар";
            this.DelProductBtn.UseVisualStyleBackColor = true;
            this.DelProductBtn.Click += new System.EventHandler(this.DelProductBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.Location = new System.Drawing.Point(1064, 273);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(198, 23);
            this.SalesBtn.TabIndex = 17;
            this.SalesBtn.Text = "Продажи товара";
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // AttachedProductBtn
            // 
            this.AttachedProductBtn.Location = new System.Drawing.Point(1064, 244);
            this.AttachedProductBtn.Name = "AttachedProductBtn";
            this.AttachedProductBtn.Size = new System.Drawing.Size(198, 23);
            this.AttachedProductBtn.TabIndex = 16;
            this.AttachedProductBtn.Text = "Рекомендуемые товары";
            this.AttachedProductBtn.UseVisualStyleBackColor = true;
            this.AttachedProductBtn.Click += new System.EventHandler(this.AttachedProductBtn_Click);
            // 
            // CostChangeBtn
            // 
            this.CostChangeBtn.Location = new System.Drawing.Point(1064, 215);
            this.CostChangeBtn.Name = "CostChangeBtn";
            this.CostChangeBtn.Size = new System.Drawing.Size(198, 23);
            this.CostChangeBtn.TabIndex = 15;
            this.CostChangeBtn.Text = "Изменить стоимость";
            this.CostChangeBtn.UseVisualStyleBackColor = true;
            this.CostChangeBtn.Click += new System.EventHandler(this.CostChangeBtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1195, 543);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 40);
            this.button4.TabIndex = 32;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1162, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 40);
            this.button3.TabIndex = 33;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1127, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 40);
            this.button2.TabIndex = 34;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1097, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 40);
            this.button1.TabIndex = 35;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RightBtn
            // 
            this.RightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBtn.Location = new System.Drawing.Point(1231, 543);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(26, 40);
            this.RightBtn.TabIndex = 30;
            this.RightBtn.Text = ">";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.Enabled = false;
            this.LeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBtn.Location = new System.Drawing.Point(1064, 543);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(26, 40);
            this.LeftBtn.TabIndex = 31;
            this.LeftBtn.Text = "<";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 618);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.SalesBtn);
            this.Controls.Add(this.AttachedProductBtn);
            this.Controls.Add(this.CostChangeBtn);
            this.Controls.Add(this.DelProductBtn);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.RangeLbl);
            this.Controls.Add(this.FiltrCmb);
            this.Controls.Add(this.DownChk);
            this.Controls.Add(this.SortCmb);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainFrm";
            this.Text = "Информационная система \"Салон красоты\"";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox SortCmb;
        private System.Windows.Forms.CheckBox DownChk;
        private System.Windows.Forms.ComboBox FiltrCmb;
        private System.Windows.Forms.Label RangeLbl;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button DelProductBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button AttachedProductBtn;
        private System.Windows.Forms.Button CostChangeBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}

