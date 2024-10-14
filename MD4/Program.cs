using System;
using System.Windows.Forms;

namespace BookLibraryApp
{
    internal static class Program
    {
        // Метод Main - точка входа программы
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Запуск главной формы
        }
    }
}
