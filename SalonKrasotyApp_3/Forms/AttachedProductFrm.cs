using SalonKrasotyApp_3.ModelEF;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp_3.Forms
{
    public partial class AttachedProductFrm : Form
    {
        public Product prd { get; set; }

        public AttachedProductFrm()
        {
            InitializeComponent();
        }

        private void AttachedProductFrm_Load(object sender, EventArgs e)
        {
            NameLbl.Text = prd.Title;
            productBindingSource.DataSource = prd.Product1.OrderBy(p => p.Title).ToList();
        }

        private void EditDopListBtn_Click(object sender, EventArgs e)
        {
            AddEditAttachedFrm form = new AddEditAttachedFrm();
            form.prd = prd;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productBindingSource.DataSource = prd.Product1.OrderBy(p => p.Title).ToList();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
