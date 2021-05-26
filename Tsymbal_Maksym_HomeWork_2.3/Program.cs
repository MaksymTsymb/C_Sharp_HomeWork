using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
//3. Для UI інтерфейсу клієнта додати поле вводу імені корисувача.
//По натисканню на кнопку Send написане повідомлення має з"явитися в полі де виводяться усі повідомлення.
/// </summary>


namespace Tsymbal_Maksym_HomeWork_2._3
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
            Application.Run(new Form1());
        }
    }
}
