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

                    if (!string.IsNullOrEmpty(prod.MainImagePath) && File.Exists(prod.MainImagePath))
                    {
                        ProductPic.Image = Image.FromFile(prod.MainImagePath);
                        filePath = prod.MainImagePath;
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
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Введите название товара!");
                titleTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(costTextBox.Text) || !decimal.TryParse(costTextBox.Text, out _))
            {
                MessageBox.Show("Введите корректную стоимость!");
                costTextBox.Focus();
                return;
            }

            try
            {
                if (prod == null)
                {
                    // СОЗДАЕМ новый товар
                    prod = (Product)productBindingSource.Current;
                    Program.db.Product.Add(prod);
                }

                // Обновляем путь к изображению
                if (!string.IsNullOrEmpty(filePath))
                {
                    prod.MainImagePath = filePath;
                }

                Program.db.SaveChanges();
                DialogResult = DialogResult.OK; // ВАЖНО: устанавливаем результат
                this.Close(); // Закрываем форму
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
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

        // Добавьте валидацию для числовых полей
        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}