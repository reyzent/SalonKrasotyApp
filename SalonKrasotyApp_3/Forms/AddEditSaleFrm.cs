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
    public partial class AddEditSaleFrm : Form
    {
        public ProductSale prdSale { get; set; } = null;

        public AddEditSaleFrm()
        {
            InitializeComponent();
        }

        private void AddEditSaleFrm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = Program.db.Product.ToList();

            if (prdSale != null)
            {
                productSaleBindingSource.Add(prdSale);
                Text = "Изменение данных о продаже товаров";
            }
            else
            {
                ProductSale prdSale = new ProductSale();
                prdSale.SaleDate = DateTime.Now;
                prdSale.Quantity = 1;

                productSaleBindingSource.Add(prdSale);
                Text = "Добавление данных о продаже товаров";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (prdSale == null)
            {
                prdSale = (ProductSale)productSaleBindingSource.Current;
                if (prdSale.ProductID == 0 || prdSale.Quantity == 0)
                {
                    MessageBox.Show("Не все данные заданы!");
                    prdSale = null;
                    return;
                }
                Program.db.ProductSale.Add(prdSale);
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
    }
}
