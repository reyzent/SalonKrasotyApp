using SalonKrasotyApp.ModelEF;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp
{
    public partial class AddEditAttachedFrm : Form
    {
        public Product prod { get; set; }

        public AddEditAttachedFrm()
        {
            InitializeComponent();
        }

        private void AddEditAttachedFrm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = Program.db.Product.
                                                OrderBy(p => p.Title).ToList();
            productBindingSource1.DataSource = prod.Product1.
                                                OrderBy(p => p.Title).ToList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Product newprod = (Product)productBindingSource.Current;
            if (newprod == prod)
            {
                MessageBox.Show("Нельзя рекомендовать товар для самого себе!");
                return;
            }
            if (prod.Product1.Contains(newprod) == true)
            { 
                MessageBox.Show("Товар " + newprod.Title + " уже рекомендован!");
                return;
            }

            prod.Product1.Add(newprod);

            try
            {
                Program.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка - " + ex.Message);
            }
            productBindingSource1.DataSource = null;
            productBindingSource1.DataSource = prod.Product1.OrderBy(p => p.Title).ToList();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {   
            Product oldprod = (Product)productBindingSource1.Current;
            
            prod.Product1.Remove(oldprod);
            try
            {
                Program.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка - " + ex.Message);
            }
            productBindingSource1.DataSource = null;
            productBindingSource1.DataSource = prod.Product1.OrderBy(p => p.Title).ToList();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
