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
            // ПРОВЕРКА ВАЛИДНОСТИ ДАННЫХ
            if (productIDComboBox.SelectedValue == null || (int)productIDComboBox.SelectedValue == 0)
            {
                MessageBox.Show("Выберите товар!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(quantityTextBox.Text) ||
                !int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество (целое положительное число)!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantityTextBox.Focus();
                return;
            }

            if (prodSale == null)
            {
                prodSale = (ProductSale)productSaleBindingSource.Current;
                Program.db.ProductSale.Add(prodSale);
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
    }
}
