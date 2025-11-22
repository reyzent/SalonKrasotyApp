namespace SalonKrasotyApp_2.Forms
{
    partial class AddEditProductFrm
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
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label mainImagePathLabel;
            System.Windows.Forms.Label manufacturerIDLabel;
            System.Windows.Forms.Label titleLabel;
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectPictBtn = new System.Windows.Forms.Button();
            this.ProductPic = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.mainImagePathTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerIDComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            costLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            mainImagePathLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SalonKrasotyApp_2.ModelEF.Product);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(SalonKrasotyApp_2.ModelEF.Manufacturer);
            // 
            // SelectPictBtn
            // 
            this.SelectPictBtn.Location = new System.Drawing.Point(397, 180);
            this.SelectPictBtn.Name = "SelectPictBtn";
            this.SelectPictBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectPictBtn.TabIndex = 41;
            this.SelectPictBtn.Text = "Выбрать";
            this.SelectPictBtn.UseVisualStyleBackColor = true;
            this.SelectPictBtn.Click += new System.EventHandler(this.SelectPictBtn_Click);
            // 
            // ProductPic
            // 
            this.ProductPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPic.Location = new System.Drawing.Point(359, 14);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(160, 160);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPic.TabIndex = 42;
            this.ProductPic.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(283, 317);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(88, 23);
            this.ExitBtn.TabIndex = 40;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(165, 317);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(88, 23);
            this.SaveBtn.TabIndex = 39;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Location = new System.Drawing.Point(61, 11);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(227, 13);
            this.TitleLbl.TabIndex = 38;
            this.TitleLbl.Text = "////////////////////////////////////////////";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(19, 244);
            costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(65, 13);
            costLabel.TabIndex = 24;
            costLabel.Text = "Стоимость:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(131, 240);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(202, 20);
            this.costTextBox.TabIndex = 25;
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(19, 107);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(131, 103);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(202, 66);
            this.descriptionTextBox.TabIndex = 27;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(19, 45);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 28;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(131, 41);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(202, 20);
            this.iDTextBox.TabIndex = 29;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(19, 277);
            isActiveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(69, 13);
            isActiveLabel.TabIndex = 30;
            isActiveLabel.Text = "Активный ?:";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(131, 271);
            this.isActiveCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(141, 30);
            this.isActiveCheckBox.TabIndex = 31;
            this.isActiveCheckBox.Text = "Товар к продаже";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainImagePathLabel
            // 
            mainImagePathLabel.AutoSize = true;
            mainImagePathLabel.Location = new System.Drawing.Point(19, 180);
            mainImagePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainImagePathLabel.Name = "mainImagePathLabel";
            mainImagePathLabel.Size = new System.Drawing.Size(71, 13);
            mainImagePathLabel.TabIndex = 32;
            mainImagePathLabel.Text = "Путь к фото:";
            // 
            // mainImagePathTextBox
            // 
            this.mainImagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MainImagePath", true));
            this.mainImagePathTextBox.Location = new System.Drawing.Point(131, 177);
            this.mainImagePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainImagePathTextBox.Name = "mainImagePathTextBox";
            this.mainImagePathTextBox.Size = new System.Drawing.Size(202, 20);
            this.mainImagePathTextBox.TabIndex = 33;
            // 
            // manufacturerIDLabel
            // 
            manufacturerIDLabel.AutoSize = true;
            manufacturerIDLabel.Location = new System.Drawing.Point(19, 211);
            manufacturerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            manufacturerIDLabel.Name = "manufacturerIDLabel";
            manufacturerIDLabel.Size = new System.Drawing.Size(89, 13);
            manufacturerIDLabel.TabIndex = 34;
            manufacturerIDLabel.Text = "Производитель:";
            // 
            // manufacturerIDComboBox
            // 
            this.manufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerID", true));
            this.manufacturerIDComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIDComboBox.DisplayMember = "Name";
            this.manufacturerIDComboBox.FormattingEnabled = true;
            this.manufacturerIDComboBox.Location = new System.Drawing.Point(131, 208);
            this.manufacturerIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.manufacturerIDComboBox.Name = "manufacturerIDComboBox";
            this.manufacturerIDComboBox.Size = new System.Drawing.Size(202, 21);
            this.manufacturerIDComboBox.TabIndex = 35;
            this.manufacturerIDComboBox.ValueMember = "ID";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(19, 76);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(60, 13);
            titleLabel.TabIndex = 36;
            titleLabel.Text = "Название:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(131, 72);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(202, 20);
            this.titleTextBox.TabIndex = 37;
            // 
            // AddEditProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 350);
            this.Controls.Add(this.SelectPictBtn);
            this.Controls.Add(this.ProductPic);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(isActiveLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(mainImagePathLabel);
            this.Controls.Add(this.mainImagePathTextBox);
            this.Controls.Add(manufacturerIDLabel);
            this.Controls.Add(this.manufacturerIDComboBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "AddEditProductFrm";
            this.Text = "Добавление и редактирование товара";
            this.Load += new System.EventHandler(this.AddEditProductFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.Button SelectPictBtn;
        private System.Windows.Forms.PictureBox ProductPic;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox mainImagePathTextBox;
        private System.Windows.Forms.ComboBox manufacturerIDComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}