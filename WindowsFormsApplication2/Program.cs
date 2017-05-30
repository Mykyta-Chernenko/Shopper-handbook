using System;
using System.Windows.Forms;
using Shopper_handbok.Forms;
using System.Collections.Generic;

namespace Shopper_handbok
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyList<int> ls = new MyList<int>();
            var b = ls.AllZero;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    
}
