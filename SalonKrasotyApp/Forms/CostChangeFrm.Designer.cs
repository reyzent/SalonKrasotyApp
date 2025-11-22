namespace SalonKrasotyApp
{
    partial class CostChangeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostChangeFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.AddCostTxt = new System.Windows.Forms.TextBox();
            this.EditCostBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "На сколько надо изменить стоимость:";
            // 
            // AddCostTxt
            // 
            this.AddCostTxt.Location = new System.Drawing.Point(278, 12);
            this.AddCostTxt.Name = "AddCostTxt";
            this.AddCostTxt.Size = new System.Drawing.Size(141, 20);
            this.AddCostTxt.TabIndex = 1;
            this.AddCostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCostTxt_KeyPress);
            // 
            // EditCostBtn
            // 
            this.EditCostBtn.Location = new System.Drawing.Point(102, 43);
            this.EditCostBtn.Name = "EditCostBtn";
            this.EditCostBtn.Size = new System.Drawing.Size(97, 23);
            this.EditCostBtn.TabIndex = 2;
            this.EditCostBtn.Text = "Изменить";
            this.EditCostBtn.UseVisualStyleBackColor = true;
            this.EditCostBtn.Click += new System.EventHandler(this.EditCostBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(227, 43);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(97, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CostChangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 78);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditCostBtn);
            this.Controls.Add(this.AddCostTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CostChangeFrm";
            this.Text = "Изменение стоимости товаров";
            this.Load += new System.EventHandler(this.CostChangeFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddCostTxt;
        private System.Windows.Forms.Button EditCostBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}