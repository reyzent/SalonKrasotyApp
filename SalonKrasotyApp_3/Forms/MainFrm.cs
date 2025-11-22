using SalonKrasotyApp_3.Forms;
using SalonKrasotyApp_3.ModelEF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp_3
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
        private List<ProductUserCtrl> lstFormatData = new List<ProductUserCtrl>();

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
                List<string> manufacturers = Program.db.Manufacturer.Select(m => m.Name).ToList();
                manufacturers.Insert(0, "Все производители");
                FiltrCmb.DataSource = manufacturers;
                FiltrCmb.SelectedIndex = 0;

                nPageCurrent = 1;
                SortCmb.SelectedIndex = 0;
                Podgotovka();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке формы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Podgotovka()
        {
            List<string> manufacturers = Program.db.Manufacturer.Select(m => m.Name).ToList();
            manufacturers.Insert(0, "Все производители");
            FiltrCmb.DataSource = manufacturers;

            lstFormatData.Clear();
            foreach (Product prd in Program.db.Product.ToList())
            {
                ProductUserCtrl puc = new ProductUserCtrl(prd);
                puc.Notify += ProductNotify;
                lstFormatData.Add(puc);
            }

            if (filtr != "Все производители")
            {
                lstFormatData = lstFormatData.Where(p => p.Manufacturer == filtr).ToList();
            }

            if (search != "")
            {
                lstFormatData = lstFormatData.Where(p => p.Title.Contains(search)).ToList();
                if (lstFormatData.Count == 0)
                {
                    MessageBox.Show("Cтрока " + search + " нигде не найдена!");
                }
            }

            if (sort != "Без сортировки")
            {
                if (sort == "Название")
                {
                    lstFormatData = DownChk.Checked == false
                        ? lstFormatData.OrderBy(p => p.Title).ToList()
                        : lstFormatData.
                                OrderByDescending(p => p.Title).ToList();
                }
                if (sort == "Стоимость")
                {
                    lstFormatData = !DownChk.Checked
                        ? lstFormatData.OrderBy(p => p.Cost).ToList()
                        : lstFormatData.
                                OrderByDescending(p => p.Cost).ToList();
                }
            }

            nPageCurrent = 1;
            nPageAll = lstFormatData.Count() / nDataInPage;
            if (nPageAll * nDataInPage < lstFormatData.Count())
                nPageAll++;

            ShowData();
            ShowButtons(nPageFirst, nPageCurrent);
        }

        private void ShowData()
        {
            int nDataMax = lstFormatData.Count();
            int beginProdNumber = (nPageCurrent - 1) * nDataInPage;
            int endProdNumber = beginProdNumber + nDataInPage;
            if (endProdNumber > nDataMax) endProdNumber = nDataMax;
            ProductFlowPnl.Controls.Clear();
            for (int j = beginProdNumber; j < endProdNumber; j++)
            {
                ProductFlowPnl.Controls.Add(lstFormatData[j]);
            }
            RangeLbl.Text =
                $"Товары с {beginProdNumber + 1} по {endProdNumber} (из всего {lstFormatData.Count()})";
        }

        private void ProductNotify(string message, int id)
        {
            if (message == "изменить")
            {
                Product prod = Program.db.Product.Find(id);
                AddEditProductFrm form = new AddEditProductFrm();
                form.prod = prod;
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Podgotovka();
                }
            }

            if (message == "удалить")
            {
                Product prod = Program.db.Product.Find(id);

                if (prod.ProductSale.Count > 0)
                {
                    MessageBox.Show("Данный товар удалить нельзя, так как есть данные о продажах!");
                    return;
                }

                if (prod.Product1.Count > 0)
                {
                    MessageBox.Show("Сначала удалите все рекомендуемые товары!");
                    return;
                }

                string str = $"Вы действительно хотите удалить - {prod.Title}";
                DialogResult dr = MessageBox.Show(str, "Удаление товара",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    Program.db.Product.Remove(prod);
                    try
                    {
                        Program.db.SaveChanges();
                        MessageBox.Show($"Товар - {prod.Title} успешно удален!");
                        Podgotovka();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка - " + ex.Message);
                    }
                }
            }

            if (message == "выбрать")
            {
                if (lstSelectedIdData.Count > 0)
                {
                    CostChangeBtn.Visible = true;
                    AttachedProductBtn.Visible = true;
                }
                else
                {
                    CostChangeBtn.Visible = false;
                    AttachedProductBtn.Visible = false;
                }
            }

            if (message == "продажи")
            {
                Product prod = Program.db.Product.Find(id);
                ProductSalesFrm form = new ProductSalesFrm();
                form.prd = prod;
                DialogResult dr = form.ShowDialog();
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

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddEditProductFrm form = new AddEditProductFrm();
            form.prod = null;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Podgotovka();
            }
        }

        private void CostChangeBtn_Click(object sender, EventArgs e)
        {
            CostChangeFrm form = new CostChangeFrm();
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Podgotovka();
            }
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            if (nPageCurrent > nPageFirst)
            {
                nPageCurrent--;
            }
            else if ((nPageCurrent == nPageFirst) && (nPageFirst > 1))
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
            Button btn = (Button)sender;
            nPageCurrent = Convert.ToInt32(btn.Text);
            ShowButtons(nPageFirst, nPageCurrent);
            ShowData();
        }

        private void ShowButtons(int nPageFirst, int nPageCurrent)
        {
            for (int i = 0; i < nButtons; i++)
            {
                int nPage = nPageFirst + i;
                btnsList[i].Text = nPage.ToString();
                btnsList[i].BackColor = Color.White;
                btnsList[i].Visible = true;

                if (nPage <= nPageAll)
                {
                    if (nPage == nPageCurrent)
                        btnsList[i].BackColor = Color.LightBlue;
                }
                else
                {
                    btnsList[i].Visible = false;
                }
            }

            if (nPageCurrent == 1)
            {
                LeftBtn.Enabled = false;
                LeftBtn.BackColor = Color.LightGray;
            }
            else
            {
                LeftBtn.Enabled = true;
                LeftBtn.BackColor = Color.White;
            }
            if (nPageCurrent == nPageAll)
            {
                RightBtn.Enabled = false;
                RightBtn.BackColor = Color.LightGray;
            }
            else
            {
                RightBtn.Enabled = true;
                RightBtn.BackColor = Color.White;
            }
        }

        private void AttachedProductBtn_Click(object sender, EventArgs e)
        {
            int id = lstSelectedIdData[0];
            Product prod = Program.db.Product.Find(id);
            AttachedProductFrm form = new AttachedProductFrm();
            form.prd = prod;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Podgotovka();
            }
        }
    }
}
