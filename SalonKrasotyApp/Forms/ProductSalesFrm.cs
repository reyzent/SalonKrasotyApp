using SalonKrasotyApp.ModelEF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp
{
    public partial class ProductSalesFrm : Form
    {
        public Product prod { get; set; } = null;

        public ProductSalesFrm()
        {
            InitializeComponent();
        }

        private void ProductSalesFrm_Load(object sender, EventArgs e)
        {
            List<string> lstFiltr = Program.db.Product.Select(x => x.Title).OrderBy(s => s).ToList();
            FiltrCmb.DataSource = lstFiltr;
            FiltrCmb.SelectedIndex = lstFiltr.FindIndex(s => s == prod.Title);

            productBindingSource.DataSource = Program.db.Product.ToList();

            productSaleBindingSource.DataSource = Program.db.ProductSale
                                    .Where(s => s.ProductID == prod.ID)
                                    .OrderBy(s => s.SaleDate).ToList();
            ProductLbl.Text = prod.Title;
        }

        private void productSaleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEditSaleFrm form = new AddEditSaleFrm();
            form.prodSale = null;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productSaleBindingSource.DataSource = Program.db.ProductSale.Where(p => p.ProductID == prod.ID).OrderBy(s => s.SaleDate).ToList();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProductSale prdSale = (ProductSale)productSaleBindingSource.Current;
            AddEditSaleFrm form = new AddEditSaleFrm();
            form.prodSale = prdSale;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productSaleBindingSource.DataSource =
                    Program.db.ProductSale.Where(p => p.ProductID == prod.ID).ToList();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ProductSale prdSale = (ProductSale)productSaleBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить данные о продаже - " + prdSale.Product.Title,
                    "Удаление данных о продаже товара", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Program.db.ProductSale.Remove(prdSale);
                Program.db.SaveChanges();
            }
        }

        private void FiltrCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = FiltrCmb.Text;
            productSaleBindingSource.DataSource = Program.db.ProductSale.Where(p => p.Product.Title == title).ToList();
            ProductLbl.Text = title;
        }
    }
}
