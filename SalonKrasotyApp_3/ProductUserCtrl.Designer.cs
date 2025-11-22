namespace SalonKrasotyApp_3
{
    partial class ProductUserCtrl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductPic = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.ManufacturerLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.SummaLbl = new System.Windows.Forms.Label();
            this.ActivePic = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivePic)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPic
            // 
            this.ProductPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPic.Image = global::SalonKrasotyApp_3.Properties.Resources.beauty_logo;
            this.ProductPic.Location = new System.Drawing.Point(5, 2);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(70, 70);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPic.TabIndex = 0;
            this.ProductPic.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(86, 4);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(136, 13);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "Наименование товара (n)";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTxt.Location = new System.Drawing.Point(89, 22);
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.ReadOnly = true;
            this.DescriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DescriptionTxt.Size = new System.Drawing.Size(439, 30);
            this.DescriptionTxt.TabIndex = 25;
            this.DescriptionTxt.Text = "Описание товара";
            // 
            // ManufacturerLbl
            // 
            this.ManufacturerLbl.AutoSize = true;
            this.ManufacturerLbl.Location = new System.Drawing.Point(86, 55);
            this.ManufacturerLbl.Name = "ManufacturerLbl";
            this.ManufacturerLbl.Size = new System.Drawing.Size(86, 13);
            this.ManufacturerLbl.TabIndex = 28;
            this.ManufacturerLbl.Text = "Производитель";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(623, 7);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(55, 13);
            this.CostLbl.TabIndex = 26;
            this.CostLbl.Text = "xxxxx руб.";
            // 
            // SummaLbl
            // 
            this.SummaLbl.AutoSize = true;
            this.SummaLbl.Location = new System.Drawing.Point(623, 29);
            this.SummaLbl.Name = "SummaLbl";
            this.SummaLbl.Size = new System.Drawing.Size(55, 13);
            this.SummaLbl.TabIndex = 27;
            this.SummaLbl.Text = "xxxxx руб.";
            // 
            // ActivePic
            // 
            this.ActivePic.Location = new System.Drawing.Point(697, 7);
            this.ActivePic.Name = "ActivePic";
            this.ActivePic.Size = new System.Drawing.Size(20, 20);
            this.ActivePic.TabIndex = 29;
            this.ActivePic.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(657, 49);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(70, 23);
            this.DeleteBtn.TabIndex = 31;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.Location = new System.Drawing.Point(564, 49);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(68, 23);
            this.SalesBtn.TabIndex = 30;
            this.SalesBtn.Text = "Продажи";
            this.SalesBtn.UseVisualStyleBackColor = true;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Продано:";
            // 
            // ProductUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SalesBtn);
            this.Controls.Add(this.ActivePic);
            this.Controls.Add(this.ManufacturerLbl);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.SummaLbl);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ProductPic);
            this.Name = "ProductUserCtrl";
            this.Size = new System.Drawing.Size(730, 75);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductUserCtrl_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPic;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label ManufacturerLbl;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label SummaLbl;
        private System.Windows.Forms.PictureBox ActivePic;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
