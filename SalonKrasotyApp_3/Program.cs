using SalonKrasotyApp_3.ModelEF;
using System;
using System.Windows.Forms;

namespace SalonKrasotyApp_3
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static BeautySalonDB db = new BeautySalonDB();
        [STAThread]
        private static void Main()
        {
            if (db.Database.Exists() == false)
            {
                MessageBox.Show("Требуемая база данных не найдена!");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
    }
}
