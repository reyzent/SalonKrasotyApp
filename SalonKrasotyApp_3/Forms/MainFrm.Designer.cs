namespace SalonKrasotyApp_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
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
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.AttachedProductBtn = new System.Windows.Forms.Button();
            this.CostChangeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(421, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Товары салона красоты";
            // 
            // ProductFlowPnl
            // 
            this.ProductFlowPnl.AutoScroll = true;
            this.ProductFlowPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductFlowPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ProductFlowPnl.Location = new System.Drawing.Point(17, 41);
            this.ProductFlowPnl.Name = "ProductFlowPnl";
            this.ProductFlowPnl.Size = new System.Drawing.Size(761, 497);
            this.ProductFlowPnl.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(922, 498);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 40);
            this.button4.TabIndex = 44;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(887, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 40);
            this.button3.TabIndex = 45;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(852, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 40);
            this.button2.TabIndex = 46;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(817, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 40);
            this.button1.TabIndex = 47;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightBtn.Location = new System.Drawing.Point(957, 498);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(26, 40);
            this.RightBtn.TabIndex = 42;
            this.RightBtn.Text = ">";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.Enabled = false;
            this.LeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftBtn.Location = new System.Drawing.Point(785, 498);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(26, 40);
            this.LeftBtn.TabIndex = 43;
            this.LeftBtn.Text = "<";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // FiltrCmb
            // 
            this.FiltrCmb.FormattingEnabled = true;
            this.FiltrCmb.Location = new System.Drawing.Point(785, 176);
            this.FiltrCmb.Name = "FiltrCmb";
            this.FiltrCmb.Size = new System.Drawing.Size(188, 24);
            this.FiltrCmb.TabIndex = 55;
            this.FiltrCmb.SelectedIndexChanged += new System.EventHandler(this.FiltrCmb_SelectedIndexChanged);
            // 
            // DownChk
            // 
            this.DownChk.AutoSize = true;
            this.DownChk.Location = new System.Drawing.Point(785, 134);
            this.DownChk.Name = "DownChk";
            this.DownChk.Size = new System.Drawing.Size(115, 21);
            this.DownChk.TabIndex = 54;
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
            this.SortCmb.Location = new System.Drawing.Point(785, 104);
            this.SortCmb.Name = "SortCmb";
            this.SortCmb.Size = new System.Drawing.Size(188, 24);
            this.SortCmb.TabIndex = 53;
            this.SortCmb.SelectedIndexChanged += new System.EventHandler(this.SortCmb_SelectedIndexChanged);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(785, 59);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(188, 23);
            this.SearchTxt.TabIndex = 52;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(782, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Фильтрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Поиск";
            // 
            // RangeLbl
            // 
            this.RangeLbl.AutoSize = true;
            this.RangeLbl.Location = new System.Drawing.Point(328, 541);
            this.RangeLbl.Name = "RangeLbl";
            this.RangeLbl.Size = new System.Drawing.Size(120, 17);
            this.RangeLbl.TabIndex = 56;
            this.RangeLbl.Text = "////////////////////////////";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(786, 230);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(187, 23);
            this.AddProductBtn.TabIndex = 59;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // AttachedProductBtn
            // 
            this.AttachedProductBtn.Location = new System.Drawing.Point(786, 288);
            this.AttachedProductBtn.Name = "AttachedProductBtn";
            this.AttachedProductBtn.Size = new System.Drawing.Size(187, 23);
            this.AttachedProductBtn.TabIndex = 57;
            this.AttachedProductBtn.Text = "Рекомендуемые товары";
            this.AttachedProductBtn.UseVisualStyleBackColor = true;
            this.AttachedProductBtn.Click += new System.EventHandler(this.AttachedProductBtn_Click);
            // 
            // CostChangeBtn
            // 
            this.CostChangeBtn.Location = new System.Drawing.Point(786, 259);
            this.CostChangeBtn.Name = "CostChangeBtn";
            this.CostChangeBtn.Size = new System.Drawing.Size(187, 23);
            this.CostChangeBtn.TabIndex = 58;
            this.CostChangeBtn.Text = "Изменить стоимость";
            this.CostChangeBtn.UseVisualStyleBackColor = true;
            this.CostChangeBtn.Click += new System.EventHandler(this.CostChangeBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(994, 570);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.AttachedProductBtn);
            this.Controls.Add(this.CostChangeBtn);
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
            this.Controls.Add(this.ProductFlowPnl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.Text = "Информационная система \"Салон красоты\"";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ProductFlowPnl;
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
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button AttachedProductBtn;
        private System.Windows.Forms.Button CostChangeBtn;
    }
}

