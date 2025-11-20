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
            sred = sred / MainFrm.lstSelectedIdData.Count;
            AddCostTxt.Text = $"{sred: ####.##}";
        }

        private void EditCostBtn_Click(object sender, EventArgs e)
        {
            if ((AddCostTxt.Text == ""))
            {
                MessageBox.Show("Не задана величина изменения цены.");
                return;
            }
            decimal delta = Convert.ToDecimal(AddCostTxt.Text);
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
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddCostTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-')) e.Handled = true;
        }
    }
}
