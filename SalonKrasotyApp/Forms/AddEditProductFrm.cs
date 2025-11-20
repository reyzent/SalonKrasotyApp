using SalonKrasotyApp.ModelEF;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SalonKrasotyApp
{
    public partial class AddEditProductFrm : Form
    {
        string filePath = "";

        public Product prod { get; set; } = null;

        public AddEditProductFrm()
        {
            InitializeComponent();
        }

        private void AddEditProductFrm_Load(object sender, EventArgs e)
        {
            manufacturerBindingSource.DataSource = Program.db.Manufacturer.ToList();
            manufacturerIDComboBox.SelectedIndex = 0;

            if(prod == null)
            {
                Product prod1 = new Product();
                productBindingSource.Add(prod1);
                this.Text = "Добавление нового товара";
                TitleLbl.Text = "Ввод данных нового товара";
                ProductPic.Image = Properties.Resources.beauty_logo;
            }
            else
            {
                productBindingSource.Add(prod);
                iDTextBox.ReadOnly = true;
                this.Text = "Корректировка данных товара " + prod.ID.ToString();
                TitleLbl.Text = "Изменение данных выбранного товара";
                if (prod.MainImagePath != "")
                {
                    ProductPic.Image = Image.FromFile(prod.MainImagePath);
                    filePath = prod.MainImagePath;
                }
                else ProductPic.Image = Properties.Resources.beauty_logo;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(prod == null)
            {
                prod = (Product)productBindingSource.Current;
                Program.db.Product.Add(prod);
            }

            if(filePath != "")
            {
                prod.MainImagePath = filePath;
            }

            try
            {
                Program.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SelectPictBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы картинок|*.jpg;*.jpeg;*.png;";
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.InitialDirectory += @"..\Товары салона красоты\";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileInfo fileInf = new FileInfo(ofd.FileName);
                long size = fileInf.Length;
                if(size > 2000000)
                {
                    MessageBox.Show("Размер файла больше 2 МБ.");
                    return;
                }
                int n = ofd.FileName.IndexOf("Товары салона красоты");
                if (n < 0) return;
                filePath = ofd.FileName.Substring(n);
                mainImagePathTextBox.Text = filePath;
                ProductPic.Image = Image.FromFile(filePath);
            }
        }
    }
}
