namespace SalonKrasotyApp_2.Forms
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EditCostBtn = new System.Windows.Forms.Button();
            this.AddCostTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(226, 43);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(97, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EditCostBtn
            // 
            this.EditCostBtn.Location = new System.Drawing.Point(101, 43);
            this.EditCostBtn.Name = "EditCostBtn";
            this.EditCostBtn.Size = new System.Drawing.Size(97, 23);
            this.EditCostBtn.TabIndex = 6;
            this.EditCostBtn.Text = "Изменить";
            this.EditCostBtn.UseVisualStyleBackColor = true;
            this.EditCostBtn.Click += new System.EventHandler(this.EditCostBtn_Click);
            // 
            // AddCostTxt
            // 
            this.AddCostTxt.Location = new System.Drawing.Point(277, 12);
            this.AddCostTxt.Name = "AddCostTxt";
            this.AddCostTxt.Size = new System.Drawing.Size(141, 20);
            this.AddCostTxt.TabIndex = 5;
            this.AddCostTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCostTxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "На сколько надо изменить стоимость:";
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
            this.Name = "CostChangeFrm";
            this.Text = "Изменение стоимости товаров";
            this.Load += new System.EventHandler(this.CostChangeFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EditCostBtn;
        private System.Windows.Forms.TextBox AddCostTxt;
        private System.Windows.Forms.Label label1;
    }
}