using SalonKrasotyApp.ModelEF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp
{
    public partial class MainFrm : Form
    {
        // Данные
        private string search = "";
        private string sort = "Без сортировки";
        private string filtr = "Все производители";
        private List<Product> lstFormatData = new List<Product>();

        // Статические данные
        public static List<int> lstSelectedIdData = new List<int>();

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                // Инициализация UI
                SortCmb.SelectedIndex = 0;

                // Загрузка данных производителей ПЕРВОЙ
                LoadManufacturers();

                // Настройка фильтров
                SetupFilters();

                // Загрузка товаров
                Podgotovka();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке формы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadManufacturers()
        {
            manufacturerBindingSource.DataSource = Program.db.Manufacturer.ToList();

            // Принудительная настройка ComboBox столбца
            DataGridViewComboBoxColumn comboColumn = productDataGridView.Columns["dataGridViewTextBoxColumn6"] as DataGridViewComboBoxColumn;
            if (comboColumn != null)
            {
                comboColumn.DataSource = manufacturerBindingSource;
                comboColumn.ValueMember = "ID";
                comboColumn.DisplayMember = "Name";
                comboColumn.DataPropertyName = "ManufacturerID";
            }
        }

        private void SetupFilters()
        {
            List<string> lstFiltr = Program.db.Manufacturer
                .Select(a => a.Name)
                .OrderBy(s => s)
                .ToList();
            lstFiltr.Insert(0, "Все производители");

            FiltrCmb.DataSource = lstFiltr;
            FiltrCmb.SelectedIndex = 0;
        }

        // ОБРАБОТЧИК ОШИБОК
        private void productDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;

            // Минимальная обработка
            Console.WriteLine($"DataGridView error ignored: {e.Exception.Message}");
        }

        private void productDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= productDataGridView.Rows.Count)
                return;

            try
            {
                if (productDataGridView[5, e.RowIndex].Value == null)
                    return;

                bool isactive = (bool)productDataGridView[5, e.RowIndex].Value;
                if (!isactive)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
            }
            catch
            {
                // Игнорируем ошибки форматирования
            }
        }

        // ОБРАБОТЧИКИ СОБЫТИЙ ФИЛЬТРОВ
        private void FiltrCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtr = FiltrCmb.Text;
            Podgotovka();
        }

        private void SortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = SortCmb.Text;
            Podgotovka();
        }

        private void DownChk_CheckedChanged(object sender, EventArgs e)
        {
            Podgotovka();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            search = SearchTxt.Text;
            Podgotovka();
        }

        // ОСНОВНОЙ МЕТОД ПОДГОТОВКИ ДАННЫХ
        public void Podgotovka()
        {
            productDataGridView.SuspendLayout();

            try
            {
                // Получаем базовые данные
                lstFormatData = Program.db.Product.ToList();

                // Применяем фильтрацию
                ApplyFiltering();

                // Применяем поиск
                ApplySearch();

                // Применяем сортировку
                ApplySorting();

                // Привязка данных к DataGridView
                productBindingSource.DataSource = lstFormatData;

                RangeLbl.Text = $"Всего товаров: {lstFormatData.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подготовке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                productDataGridView.ResumeLayout();
            }
        }

        private void ApplyFiltering()
        {
            if (filtr != "Все производители")
            {
                lstFormatData = lstFormatData
                    .Where(p => p.Manufacturer != null && p.Manufacturer.Name == filtr)
                    .ToList();
            }
        }

        private void ApplySearch()
        {
            if (!string.IsNullOrEmpty(search))
            {
                lstFormatData = lstFormatData
                    .Where(p => p.Title != null && p.Title.Contains(search))
                    .ToList();

                if (lstFormatData.Count == 0)
                {
                    MessageBox.Show($"Строка '{search}' нигде не найдена!", "Результат поиска",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApplySorting()
        {
            if (sort != "Без сортировки")
            {
                switch (sort)
                {
                    case "Название":
                        lstFormatData = DownChk.Checked
                            ? lstFormatData.OrderByDescending(p => p.Title).ToList()
                            : lstFormatData.OrderBy(p => p.Title).ToList();
                        break;
                    case "Стоимость":
                        lstFormatData = DownChk.Checked
                            ? lstFormatData.OrderByDescending(p => p.Cost).ToList()
                            : lstFormatData.OrderBy(p => p.Cost).ToList();
                        break;
                }
            }
        }

        // ОБРАБОТЧИКИ ДЕЙСТВИЙ С ТОВАРАМИ
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            using (AddEditProductFrm frm = new AddEditProductFrm { prod = null })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Podgotovka();
                }
            }
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Current is Product prod)
            {
                using (AddEditProductFrm frm = new AddEditProductFrm { prod = prod })
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Podgotovka();
                    }
                }
            }
        }

        private void DelProductBtn_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Current is Product prd)
            {
                DialogResult result = MessageBox.Show($"Вы действительно хотите удалить товар - {prd.Title}?",
                    "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (prd.ProductSale.Count > 0)
                        {
                            MessageBox.Show("Данный товар удалить нельзя, так как есть данные о продажах!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Program.db.Product.Remove(prd);
                        Program.db.SaveChanges();
                        Podgotovka();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CostChangeBtn_Click(object sender, EventArgs e)
        {
            lstSelectedIdData.Clear();

            if (productDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        lstSelectedIdData.Add((int)row.Cells[0].Value);
                    }
                }

                using (CostChangeFrm form = new CostChangeFrm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Podgotovka();
                    }
                }
            }
        }

        private void AttachedProductBtn_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Current is Product prod)
            {
                using (AttachedProductFrm form = new AttachedProductFrm { prod = prod })
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Podgotovka();
                    }
                }
            }
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            if (productBindingSource.Current is Product prod)
            {
                using (ProductSalesFrm form = new ProductSalesFrm { prod = prod })
                {
                    form.ShowDialog();
                }
            }
        }
    }
}