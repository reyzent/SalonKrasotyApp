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
        private const int nDataInPage = 20;
        private const int nButtons = 4;
        private const int IsActiveColumnIndex = 5;

        private int nPageAll = 0;
        private int nPageFirst = 1;
        private int nPageCurrent = 1;

        private string search = "";
        private string sort = "Без сортировки";
        private string filtr = "Все производители";
        private List<Product> lstFormatData = new List<Product>();

        private Button[] btnsList = new Button[nButtons];

        public static List<int> lstSelectedIdData = new List<int>();

        public MainFrm()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            btnsList[0] = button1;
            btnsList[1] = button2;
            btnsList[2] = button3;
            btnsList[3] = button4;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                nPageCurrent = 1;
                SortCmb.SelectedIndex = 0;

                LoadManufacturers();

                SetupFilters();

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

        private void productDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
            Console.WriteLine($"DataGridView error ignored: {e.Exception.Message}");
        }

        private void productDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= productDataGridView.Rows.Count)
                return;

            try
            {
                if (productDataGridView[IsActiveColumnIndex, e.RowIndex].Value == null)
                    return;

                bool isactive = (bool)productDataGridView[IsActiveColumnIndex, e.RowIndex].Value;
                if (!isactive)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
            }
            catch
            {

            }
        }

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

        public void Podgotovka()
        {
            productDataGridView.SuspendLayout();

            try
            {
                lstFormatData = Program.db.Product.ToList();
                ApplyFiltering();
                ApplySearch();
                ApplySorting();
                UpdatePagination();
                ShowData();

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
                            ? lstFormatData.OrderByDescending(p => p.Title ?? "").ToList()
                            : lstFormatData.OrderBy(p => p.Title ?? "").ToList();
                        break;
                    case "Стоимость":
                        lstFormatData = DownChk.Checked
                            ? lstFormatData.OrderByDescending(p => p.Cost).ToList()
                            : lstFormatData.OrderBy(p => p.Cost).ToList();
                        break;
                }
            }
        }

        private void UpdatePagination()
        {
            nPageCurrent = 1;
            nPageAll = (int)Math.Ceiling((double)lstFormatData.Count / nDataInPage);
            ShowButtons(nPageFirst, nPageCurrent);
        }

        private void ShowData()
        {
            if (lstFormatData == null || !lstFormatData.Any())
            {
                productBindingSource.DataSource = new List<Product>();
                RangeLbl.Text = $"По запросу '{search}' ничего не найдено";
                return;
            }

            int beginProdNumber = (nPageCurrent - 1) * nDataInPage;
            int endProdNumber = Math.Min(beginProdNumber + nDataInPage, lstFormatData.Count);

            List<Product> pageData = lstFormatData
                .Skip(beginProdNumber)
                .Take(nDataInPage)
                .ToList();

            productBindingSource.DataSource = pageData;

            RangeLbl.Text = $"Товары с {beginProdNumber + 1} по {endProdNumber} (всего {lstFormatData.Count})";
        }

        private void ShowButtons(int nPageFirst, int nPageCurrent)
        {
            for (int i = 0; i < nButtons; i++)
            {
                int nPage = nPageFirst + i;
                btnsList[i].Text = nPage.ToString();
                btnsList[i].Visible = nPage <= nPageAll;
                btnsList[i].BackColor = nPage == nPageCurrent ? Color.LightBlue : Color.White;
            }

            LeftBtn.Enabled = nPageCurrent > 1;
            LeftBtn.BackColor = LeftBtn.Enabled ? Color.White : Color.LightGray;

            RightBtn.Enabled = nPageCurrent < nPageAll;
            RightBtn.BackColor = RightBtn.Enabled ? Color.White : Color.LightGray;
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            if (nPageCurrent > nPageFirst)
            {
                nPageCurrent--;
            }
            else if (nPageCurrent == nPageFirst && nPageFirst > 1)
            {
                nPageFirst--;
                nPageCurrent = nPageFirst;
            }
            ShowButtons(nPageFirst, nPageCurrent);
            ShowData();
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            if (nPageCurrent < nPageFirst + nButtons - 1)
            {
                nPageCurrent++;
            }
            else if (nPageCurrent < nPageAll)
            {
                nPageFirst++;
                nPageCurrent++;
            }
            ShowButtons(nPageFirst, nPageCurrent);
            ShowData();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.Text, out int pageNum))
            {
                nPageCurrent = pageNum;
                ShowButtons(nPageFirst, nPageCurrent);
                ShowData();
            }
        }

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

        private static bool isEditFormOpen = false;

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            if (isEditFormOpen)
            {
                MessageBox.Show("Форма редактирования уже открыта!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productBindingSource.Current is Product prod)
            {
                isEditFormOpen = true;
                using (AddEditProductFrm frm = new AddEditProductFrm { prod = prod })
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Podgotovka();
                    }
                }
                isEditFormOpen = false;
            }
        }

        private void DelProductBtn_Click(object sender, EventArgs e)
        {
            if (!(productBindingSource.Current is Product prd))
            {
                MessageBox.Show("Выберите товар для удаления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить товар - {prd.Title}?",
                "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (prd.ProductSale.Any())
                    {
                        MessageBox.Show("Данный товар удалить нельзя, так как есть данные о продажах!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (prd.Product1.Any())
                    {
                        prd.Product1.Clear();
                    }

                    Program.db.Product.Remove(prd);
                    Program.db.SaveChanges();
                    Podgotovka();

                    MessageBox.Show("Товар успешно удален!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show($"Ошибка базы данных при удалении: {ex.InnerException?.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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