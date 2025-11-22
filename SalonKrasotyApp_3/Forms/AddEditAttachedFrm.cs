using SalonKrasotyApp_3.ModelEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonKrasotyApp_3.Forms
{
    public partial class AddEditAttachedFrm : Form
    {
        public Product prd { get; set; }

        public AddEditAttachedFrm()
        {
            InitializeComponent();
        }

        private void AddEditAttachedFrm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = Program.db.Product.ToList();
            productBindingSource1.DataSource = prd.Product1.OrderBy(p => p.Title).ToList();
        }

        private void AddAttachedProductBtn_Click(object sender, EventArgs e)
        {
            Product newprod = (Product)productBindingSource.Current;
            if (newprod == prd)
            {
                MessageBox.Show("Нельзя рекоментовать товар самому себе!");
                return;
            }
            if (prd.Product1.Contains(newprod) == true) 
            {
                MessageBox.Show("Товар " + newprod.Title + " уже рекомендован!");
                return;
            }

            prd.Product1.Add(newprod);

            try
            {
                Program.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка - " + ex.Message);
            }
            productBindingSource1.DataSource = null;
            productBindingSource1.DataSource = prd.Product1.OrderBy(p => p.Title).ToList();
        }

        private void DelAttachedProductBtn_Click(object sender, EventArgs e)
        {
            Product oldprod = (Product)productBindingSource1.Current;
            prd.Product1.Remove(oldprod);

            try
            {
                Program.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка - " + ex.Message);
            }
            productBindingSource1.DataSource = null;
            productBindingSource1.DataSource = prd.Product1.OrderBy(p => p.Title).ToList();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
