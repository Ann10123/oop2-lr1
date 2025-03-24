using System;
using System.Windows.Forms;

namespace SuperMegaApp
{
    static class Program
    {
        /// <summary>
        /// Основна точка входу для програми.
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
