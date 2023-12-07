﻿using System;
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
        public static Form_QLPhim frmPhim = null;
        public static Form_QLLichChieu frmQLLC = null;
        public static Form_QLTaiKhoan frmQLTaiKhoan = null;
        public static Form_CreateTK frmCreateTK = null;
        public static Form_QLVe frmQLVe = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmDangNhap = new Form_DangNhap();
            //Application.Run(frmDangNhap);
            //frmDangNhap = new Form_DangNhap();
            //Application.Run(frmDangNhap);
            //frmQLLC = new Form_QLLichChieu();
            //Application.Run(frmQLLC);
            frmQLVe = new Form_QLVe();
            Application.Run(frmQLVe);
        }
    }
}
