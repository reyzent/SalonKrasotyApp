using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalonKrasotyApp.ModelEF;

namespace SalonKrasotyApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static BeautySalonDB db = new BeautySalonDB();
        [STAThread]
        static void Main()
        {
            if(db.Database.Exists() == false)
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
