using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static Form_DangNhap frmDangNhap = null;
        public static Form_Main frmMain = null;
        public static Form_Config frmConfig = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap = new Form_DangNhap();
            Application.Run(frmDangNhap);
        }
    }
}
