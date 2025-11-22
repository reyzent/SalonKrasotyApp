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
    public partial class ProductSalesFrm : Form
    {
        public Product prd { get; set; } = null;

        public ProductSalesFrm()
        {
            InitializeComponent();
        }

        private void ProductSalesFrm_Load(object sender, EventArgs e)
        {
            // загружаем список названий типов товаров
            List<string> lstFiltr = Program.db.Product.Select(x => x.Title).OrderBy(s => s).ToList();
            FiltrCombo.DataSource = lstFiltr;
            FiltrCombo.SelectedIndex = lstFiltr.FindIndex(s => s == prd.Title);

            productBindingSource.DataSource = Program.db.Product.ToList();

            productSaleBindingSource.DataSource = Program.db.ProductSale
                                    .Where(s => s.ProductID == prd.ID)
                                    .OrderBy(s => s.SaleDate).ToList();
            label2.Text = prd.Title;
        }

        private void productSaleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AddSaleBtn_Click(object sender, EventArgs e)
        {
            AddEditSaleFrm form = new AddEditSaleFrm();
            form.prdSale = null;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productSaleBindingSource.DataSource =
                        Program.db.ProductSale.Where(p => p.ProductID == prd.ID).
                        OrderBy(s => s.SaleDate).ToList();
            }
        }

        private void EditSaleBtn_Click(object sender, EventArgs e)
        {
            ProductSale prdSale = (ProductSale)productSaleBindingSource.Current;
            AddEditSaleFrm form = new AddEditSaleFrm();
            form.prdSale = prdSale;

            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productSaleBindingSource.DataSource =
                    Program.db.ProductSale.Where(p => p.ProductID == prd.ID).ToList();
            }
        }

        private void DeleteSaleBtn_Click(object sender, EventArgs e)
        {
            if (productSaleBindingSource.Current == null)
            {
                MessageBox.Show("Выберите продажу для удаления!");
                return;
            }

            ProductSale prdSale = (ProductSale)productSaleBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Удалить данные о продаже - {prdSale.Product.Title}?",
                    "Удаление данных о продаже товара",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    Program.db.ProductSale.Remove(prdSale);
                    Program.db.SaveChanges();

                    productSaleBindingSource.DataSource =
                        Program.db.ProductSale.Where(p => p.ProductID == prd.ID).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                }
            }
        }

        private void FiltrCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string title = FiltrCombo.Text;
            productSaleBindingSource.DataSource =
                    Program.db.ProductSale.Where(p => p.Product.Title == title).ToList();
            label2.Text = title;
        }
    }
}
