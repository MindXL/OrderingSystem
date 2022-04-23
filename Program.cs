using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ex3.forms.authentication;
using Ex3.forms.main;

namespace Ex3
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*Application.Run(new Login());

            if (Globals.character != null)
                Application.Run(new Main());*/
            //Application.Run(new Inventory());
            Application.Run(new Ex3.forms.main.OrderOperation.SelectMaterial());
        }
    }
}