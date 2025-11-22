using SalonKrasotyApp.ModelEF;
using System;
using System.Windows.Forms;

namespace SalonKrasotyApp
{
    public partial class CostChangeFrm : Form
    {
        public CostChangeFrm()
        {
            InitializeComponent();
        }

        private void CostChangeFrm_Load(object sender, EventArgs e)
        {
            decimal sred = 0;
            foreach (int id in MainFrm.lstSelectedIdData)
            {
                Product prd = Program.db.Product.Find(id);
                sred += prd.Cost;
            }
            sred /= MainFrm.lstSelectedIdData.Count;
            AddCostTxt.Text = $"{sred: ####.##}";
        }

        private void EditCostBtn_Click(object sender, EventArgs e)
        {
            if ((AddCostTxt.Text == ""))
            {
                MessageBox.Show("Не задана величина изменения цены.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(AddCostTxt.Text, out decimal delta))
            {
                MessageBox.Show("Введите корректное числовое значение!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (int id in MainFrm.lstSelectedIdData)
            {
                Product prd = Program.db.Product.Find(id);
                if (prd.Cost + delta < 0)
                {
                    MessageBox.Show($"Стоимость товара '{prd.Title}' не может быть отрицательной!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (int id in MainFrm.lstSelectedIdData)
            {
                Product prd = Program.db.Product.Find(id);
                prd.Cost += delta;
            }

            try
            {
                Program.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddCostTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',') && (e.KeyChar != 8)) 
                e.Handled = true;
        }
    }
}
