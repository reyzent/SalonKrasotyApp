using SalonKrasotyApp_2.Forms;
using SalonKrasotyApp_2.ModelEF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp_2
{
    public partial class MainFrm : Form
    {
        private const int nDataInPage = 20;
        private const int nButtons = 4;

        private int nPageAll = 0;
        private int nPageFirst = 1;
        private int nPageCurrent = 1;

        private string search = "";
        private string sort = "Без сортировки";
        private string filtr = "Все производители";
        private List<NewProduct> lstFormatData = new List<NewProduct>();

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
                SetupFilters();
                Podgotovka();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке формы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void newProductDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
            Console.WriteLine($"DataGridView error ignored: {e.Exception.Message}");
        }

        private void newProductDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= newProductDataGridView.Rows.Count)
                return;

            try
            {
                var row = newProductDataGridView.Rows[e.RowIndex];
                NewProduct productView = row.DataBoundItem as NewProduct;

                if (productView != null && !productView.IsActive)
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
            List<NewProduct> tempData = new List<NewProduct>();

            foreach (Product prd in Program.db.Product.ToList())
            {
                NewProduct newprd = new NewProduct(prd);
                tempData.Add(newprd);
            }

            try
            {
                tempData = ApplyFiltering(tempData);
                tempData = ApplySearch(tempData);
                tempData = ApplySorting(tempData);

                lstFormatData = tempData;

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
                newProductDataGridView.ResumeLayout();
            }
        }

        private List<NewProduct> ApplyFiltering(List<NewProduct> data)
        {
            if (filtr != "Все производители")
            {
                return data
                    .Where(p => p.Manufacturer == filtr)
                    .ToList();
            }
            return data;
        }

        private List<NewProduct> ApplySearch(List<NewProduct> data)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return data
                    .Where(p => p.Title != null && p.Title.Contains(search))
                    .ToList();
            }
            return data;
        }

        private List<NewProduct> ApplySorting(List<NewProduct> data)
        {
            if (sort != "Без сортировки")
            {
                switch (sort)
                {
                    case "Название":
                        return DownChk.Checked
                            ? data.OrderByDescending(p => p.Title ?? "").ToList()
                            : data.OrderBy(p => p.Title ?? "").ToList();
                    case "Стоимость":
                        return DownChk.Checked
                            ? data.OrderByDescending(p => p.Cost).ToList()
                            : data.OrderBy(p => p.Cost).ToList();
                }
            }
            return data;
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
                newProductBindingSource.DataSource = new List<NewProduct>();
                RangeLbl.Text = $"По запросу '{search}' ничего не найдено";
                return;
            }

            int beginProdNumber = (nPageCurrent - 1) * nDataInPage;
            int endProdNumber = Math.Min(beginProdNumber + nDataInPage, lstFormatData.Count);

            newProductBindingSource.List.Clear();
            for (int j = beginProdNumber; j < endProdNumber; j++)
            {
                newProductBindingSource.List.Add(lstFormatData[j]);
            }

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

            if (newProductBindingSource.Current is NewProduct newProduct)
            {
                Product prod = Program.db.Product.Find(newProduct.ID);

                if (prod != null)
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
            else
            {
                MessageBox.Show("Выберите товар для редактирования!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DelProductBtn_Click(object sender, EventArgs e)
        {
            if (!(newProductBindingSource.Current is NewProduct newProduct))
            {
                MessageBox.Show("Выберите товар для удаления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Product prd = Program.db.Product.Find(newProduct.ID);

            if (prd == null)
            {
                MessageBox.Show("Товар не найден в базе данных!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (newProductDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in newProductDataGridView.SelectedRows)
                {
                    if (row.DataBoundItem is NewProduct newProduct)
                    {
                        lstSelectedIdData.Add(newProduct.ID);
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
            if (newProductBindingSource.Current is NewProduct newProduct)
            {
                Product prod = Program.db.Product.Find(newProduct.ID);
                if (prod != null)
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
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            if (newProductBindingSource.Current is NewProduct newProduct)
            {
                Product prod = Program.db.Product.Find(newProduct.ID);
                if (prod != null)
                {
                    using (ProductSalesFrm form = new ProductSalesFrm { prod = prod })
                    {
                        form.ShowDialog();
                    }
                }
            }
        }
    }
}
