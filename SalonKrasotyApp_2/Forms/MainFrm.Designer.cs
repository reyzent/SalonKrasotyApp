namespace SalonKrasotyApp_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.newProductDataGridView = new System.Windows.Forms.DataGridView();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.AttachedProductBtn = new System.Windows.Forms.Button();
            this.CostChangeBtn = new System.Windows.Forms.Button();
            this.DelProductBtn = new System.Windows.Forms.Button();
            this.EditProductBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.FiltrCmb = new System.Windows.Forms.ComboBox();
            this.DownChk = new System.Windows.Forms.CheckBox();
            this.SortCmb = new System.Windows.Forms.ComboBox();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RangeLbl = new System.Windows.Forms.Label();
            this.newProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.newProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newProductDataGridView
            // 
            this.newProductDataGridView.AllowUserToAddRows = false;
            this.newProductDataGridView.AllowUserToDeleteRows = false;
            this.newProductDataGridView.AutoGenerateColumns = false;
            this.newProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.newProductDataGridView.DataSource = this.newProductBindingSource;
            this.newProductDataGridView.Location = new System.Drawing.Point(17, 86);
            this.newProductDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.newProductDataGridView.Name = "newProductDataGridView";
            this.newProductDataGridView.ReadOnly = true;
            this.newProductDataGridView.RowTemplate.Height = 60;
            this.newProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.newProductDataGridView.Size = new System.Drawing.Size(1040, 497);
            this.newProductDataGridView.TabIndex = 1;
            this.newProductDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.newProductDataGridView_CellFormatting);
            this.newProductDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.newProductDataGridView_DataError);
            // 
            // SalesBtn
            // 
            this.SalesBtn.Location = new System.Drawing.Point(1064, 273);
            this.SalesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(198, 23);
            this.SalesBtn.TabIndex = 23;
            this.SalesBtn.Text = "Продажи товара";
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // AttachedProductBtn
            // 
            this.AttachedProductBtn.Location = new System.Drawing.Point(1064, 244);
            this.AttachedProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AttachedProductBtn.Name = "AttachedProductBtn";
            this.AttachedProductBtn.Size = new System.Drawing.Size(198, 23);
            this.AttachedProductBtn.TabIndex = 22;
            this.AttachedProductBtn.Text = "Рекомендуемые товары";
            this.AttachedProductBtn.UseVisualStyleBackColor = true;
            this.AttachedProductBtn.Click += new System.EventHandler(this.AttachedProductBtn_Click);
            // 
            // CostChangeBtn
            // 
            this.CostChangeBtn.Location = new System.Drawing.Point(1064, 215);
            this.CostChangeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CostChangeBtn.Name = "CostChangeBtn";
            this.CostChangeBtn.Size = new System.Drawing.Size(198, 23);
            this.CostChangeBtn.TabIndex = 21;
            this.CostChangeBtn.Text = "Изменить стоимость";
            this.CostChangeBtn.UseVisualStyleBackColor = true;
            this.CostChangeBtn.Click += new System.EventHandler(this.CostChangeBtn_Click);
            // 
            // DelProductBtn
            // 
            this.DelProductBtn.Location = new System.Drawing.Point(1064, 144);
            this.DelProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelProductBtn.Name = "DelProductBtn";
            this.DelProductBtn.Size = new System.Drawing.Size(198, 23);
            this.DelProductBtn.TabIndex = 20;
            this.DelProductBtn.Text = "Удалить товар";
            this.DelProductBtn.UseVisualStyleBackColor = true;
            this.DelProductBtn.Click += new System.EventHandler(this.DelProductBtn_Click);
            // 
            // EditProductBtn
            // 
            this.EditProductBtn.Location = new System.Drawing.Point(1064, 115);
            this.EditProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditProductBtn.Name = "EditProductBtn";
            this.EditProductBtn.Size = new System.Drawing.Size(198, 23);
            this.EditProductBtn.TabIndex = 19;
            this.EditProductBtn.Text = "Изменить товар";
            this.EditProductBtn.UseVisualStyleBackColor = true;
            this.EditProductBtn.Click += new System.EventHandler(this.EditProductBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(1064, 86);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(198, 23);
            this.AddProductBtn.TabIndex = 18;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Товары салона красоты";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1201, 543);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 40);
            this.button4.TabIndex = 38;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1166, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 40);
            this.button3.TabIndex = 39;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1131, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 40);
            this.button2.TabIndex = 40;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1096, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 40);
            this.button1.TabIndex = 41;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBtn.Location = new System.Drawing.Point(1236, 543);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(26, 40);
            this.RightBtn.TabIndex = 36;
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
            this.LeftBtn.TabIndex = 37;
            this.LeftBtn.Text = "<";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // FiltrCmb
            // 
            this.FiltrCmb.FormattingEnabled = true;
            this.FiltrCmb.Location = new System.Drawing.Point(866, 57);
            this.FiltrCmb.Name = "FiltrCmb";
            this.FiltrCmb.Size = new System.Drawing.Size(188, 24);
            this.FiltrCmb.TabIndex = 48;
            this.FiltrCmb.SelectedIndexChanged += new System.EventHandler(this.FiltrCmb_SelectedIndexChanged);
            // 
            // DownChk
            // 
            this.DownChk.AutoSize = true;
            this.DownChk.Location = new System.Drawing.Point(479, 57);
            this.DownChk.Name = "DownChk";
            this.DownChk.Size = new System.Drawing.Size(115, 21);
            this.DownChk.TabIndex = 47;
            this.DownChk.Text = "По убыванию";
            this.DownChk.UseVisualStyleBackColor = true;
            this.DownChk.CheckedChanged += new System.EventHandler(this.DownChk_CheckedChanged);
            // 
            // SortCmb
            // 
            this.SortCmb.FormattingEnabled = true;
            this.SortCmb.Items.AddRange(new object[] {
            "Без сортировки",
            "Название",
            "Стоимость"});
            this.SortCmb.Location = new System.Drawing.Point(283, 55);
            this.SortCmb.Name = "SortCmb";
            this.SortCmb.Size = new System.Drawing.Size(188, 24);
            this.SortCmb.TabIndex = 46;
            this.SortCmb.SelectedIndexChanged += new System.EventHandler(this.SortCmb_SelectedIndexChanged);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(18, 56);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(188, 23);
            this.SearchTxt.TabIndex = 45;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(863, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Фильтрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Поиск";
            // 
            // RangeLbl
            // 
            this.RangeLbl.AutoSize = true;
            this.RangeLbl.Location = new System.Drawing.Point(447, 586);
            this.RangeLbl.Name = "RangeLbl";
            this.RangeLbl.Size = new System.Drawing.Size(120, 17);
            this.RangeLbl.TabIndex = 49;
            this.RangeLbl.Text = "////////////////////////////";
            // 
            // newProductBindingSource
            // 
            this.newProductBindingSource.DataSource = typeof(SalonKrasotyApp_2.NewProduct);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DopProducts";
            this.dataGridViewTextBoxColumn6.HeaderText = "Доп. товары";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn5.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 68;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SummaSale";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "Сумма продаж";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1272, 618);
            this.Controls.Add(this.RangeLbl);
            this.Controls.Add(this.FiltrCmb);
            this.Controls.Add(this.DownChk);
            this.Controls.Add(this.SortCmb);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesBtn);
            this.Controls.Add(this.AttachedProductBtn);
            this.Controls.Add(this.CostChangeBtn);
            this.Controls.Add(this.DelProductBtn);
            this.Controls.Add(this.EditProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.newProductDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.Text = "Информационная система \"Салон красоты\"";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource newProductBindingSource;
        private System.Windows.Forms.DataGridView newProductDataGridView;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button AttachedProductBtn;
        private System.Windows.Forms.Button CostChangeBtn;
        private System.Windows.Forms.Button DelProductBtn;
        private System.Windows.Forms.Button EditProductBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.ComboBox FiltrCmb;
        private System.Windows.Forms.CheckBox DownChk;
        private System.Windows.Forms.ComboBox SortCmb;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RangeLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}

