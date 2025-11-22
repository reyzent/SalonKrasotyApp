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
        private string filePath = "";
        public Product prod { get; set; } = null;

        public AddEditProductFrm()
        {
            InitializeComponent();
        }

        private void AddEditProductFrm_Load(object sender, EventArgs e)
        {
            try
            {
                manufacturerBindingSource.DataSource = Program.db.Manufacturer.ToList();

                if (manufacturerIDComboBox.Items.Count > 0)
                    manufacturerIDComboBox.SelectedIndex = 0;

                if (prod == null)
                {
                    // Создаем новый товар
                    Product prod1 = new Product();
                    productBindingSource.Add(prod1);
                    this.Text = "Добавление нового товара";
                    TitleLbl.Text = "Ввод данных нового товара";
                    ProductPic.Image = Properties.Resources.beauty_logo;
                }
                else
                {
                    // Редактируем существующий товар
                    productBindingSource.Add(prod);
                    iDTextBox.ReadOnly = true;
                    this.Text = "Корректировка данных товара " + prod.ID.ToString();
                    TitleLbl.Text = "Изменение данных выбранного товара";

                    if (!string.IsNullOrEmpty(prod.MainImagePath))
                    {
                        try
                        {
                            if (File.Exists(prod.MainImagePath))
                            {
                                ProductPic.Image = Image.FromFile(prod.MainImagePath);
                                filePath = prod.MainImagePath;
                            }
                            else
                            {
                                ProductPic.Image = Properties.Resources.beauty_logo;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                            ProductPic.Image = Properties.Resources.beauty_logo;
                        }
                    }
                    else
                    {
                        ProductPic.Image = Properties.Resources.beauty_logo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке формы: {ex.Message}");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Введите название товара!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                titleTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(costTextBox.Text) ||
                !decimal.TryParse(costTextBox.Text, out decimal cost) ||
                cost < 0)
            {
                MessageBox.Show("Введите корректную стоимость (положительное число)!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                costTextBox.Focus();
                costTextBox.SelectAll();
                return;
            }

            if (manufacturerIDComboBox.SelectedValue == null ||
                !int.TryParse(manufacturerIDComboBox.SelectedValue.ToString(), out int manufacturerID) ||
                manufacturerID == 0)
            {
                MessageBox.Show("Выберите производителя!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                manufacturerIDComboBox.Focus();
                return;
            }

            try
            {
                if (prod == null)
                {
                    prod = (Product)productBindingSource.Current;
                    Program.db.Product.Add(prod);
                }

                if (!string.IsNullOrEmpty(filePath))
                {
                    prod.MainImagePath = filePath;
                }

                Program.db.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Close();
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
            this.Close();
        }

        private void SelectPictBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Файлы картинок|*.jpg;*.jpeg;*.png;|Все файлы|*.*";

                // Безопасная установка начальной директории
                string initialDir = Path.Combine(Environment.CurrentDirectory, @"..\Товары салона красоты\");
                if (Directory.Exists(initialDir))
                    ofd.InitialDirectory = initialDir;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fileInf = new FileInfo(ofd.FileName);
                        long size = fileInf.Length;

                        if (size > 2000000)
                        {
                            MessageBox.Show("Размер файла больше 2 МБ.");
                            return;
                        }

                        // Проверяем, находится ли файл в нужной папке
                        int n = ofd.FileName.IndexOf("Товары салона красоты");
                        if (n >= 0)
                        {
                            filePath = ofd.FileName.Substring(n);
                            mainImagePathTextBox.Text = filePath;
                            ProductPic.Image = Image.FromFile(ofd.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Файл должен находиться в папке 'Товары салона красоты'");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                    }
                }
            }
        }

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }
    }
}