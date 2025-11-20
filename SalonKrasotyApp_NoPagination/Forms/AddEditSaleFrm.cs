using SalonKrasotyApp.ModelEF;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp
{
    public partial class AddEditSaleFrm : Form
    {
        public ProductSale prodSale { get; set; } = null;

        public AddEditSaleFrm()
        {
            InitializeComponent();
        }

        private void AddEditSaleFrm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = Program.db.Product.ToList();

            if (prodSale != null)
            {
                productSaleBindingSource.Add(prodSale);
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
            if (prodSale == null)
            {
                prodSale = (ProductSale)productSaleBindingSource.Current;
                if (prodSale.ProductID == 0 || prodSale.Quantity == 0)
                {
                    MessageBox.Show("Не все данные заданы!");
                    prodSale = null;
                    return;
                }
                Program.db.ProductSale.Add(prodSale);
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
