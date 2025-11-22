using SalonKrasotyApp_3.ModelEF;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp_3
{
    public partial class ProductUserCtrl : UserControl
    {
        public ProductUserCtrl()
        {
            InitializeComponent();
        }

        public int ID { get; set; }

        public string Title
        {
            get { return TitleLbl.Text; }
            set { TitleLbl.Text = value; }
        }

        public string Description
        {
            set { DescriptionTxt.Text = value; }
        }

        public decimal Cost
        {
            get { return Convert.ToDecimal(CostLbl.Text); }
            set { CostLbl.Text = value.ToString(); }
        }

        public string Manufacturer
        {
            get { return ManufacturerLbl.Text; }
            set { ManufacturerLbl.Text = value; }
        }

        public decimal SummaSale
        {
            set { SummaLbl.Text = value.ToString(); }
        }

        public Image Picture
        {
            set { ProductPic.Image = value; }
        }

        public ProductUserCtrl(Product prd)
        {
            InitializeComponent();
            ID = prd.ID;
            Title = $"{prd.Title} ({prd.Product1.Count})";
            Description = prd.Description;
            Manufacturer = prd.ManufacturerID.HasValue ? prd.Manufacturer.Name : "";
            Cost = prd.Cost;
            Picture = prd.MainImagePath != "" ? Image.FromFile(prd.MainImagePath.Trim()) : Properties.Resources.beauty_logo;
            DateTime today = DateTime.Today;
            DateTime date1 = today.AddDays(-30);
            int nSale = prd.ProductSale
                .Where(s => (s.SaleDate > date1 &&
                s.SaleDate < today))
                .Sum(x => x.Quantity);
            SummaSale = nSale * prd.Cost;
            if (!prd.IsActive)
            {
                ActivePic.BackColor = Color.Red;
            }
            BackColor = MainFrm.lstSelectedIdData.IndexOf(ID) != -1 ? Color.LightGray : Color.White;
        }

        public delegate void MyHandler(string message, int id);

        public event MyHandler Notify;

        private void ProductUserCtrl_MouseClick(object sender, MouseEventArgs e)
        {
            if (Notify != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (MainFrm.lstSelectedIdData.IndexOf(ID) != -1)
                    {
                        this.BackColor = Color.White;
                        MainFrm.lstSelectedIdData.Remove(ID);
                    }
                    else
                    {
                        this.BackColor = Color.LightGray;
                        MainFrm.lstSelectedIdData.Add(ID);
                    }

                    Notify("выбрать", ID);
                }
                if (e.Button == MouseButtons.Left)
                {
                    Notify("изменить", ID);
                }
            }
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            Notify("продажи", ID);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Notify("удалить", ID);
        }
    }
}
