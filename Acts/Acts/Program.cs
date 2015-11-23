using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acts
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frm = new loginForm();
            if (frm.ShowDialog() != DialogResult.OK) return;
            switch (frm.Role)
            {
                case Roles.Admin:
                    Application.Run(new adminForm());
                    break;
                case Roles.User1:
                    Application.Run(new user1Form());
                    break;
                case Roles.User2:
                    Application.Run(new user2Form());
                    break;
                default:
                    MessageBox.Show("ошибка авторизации");
                    break;
            }
        }
    }
}
