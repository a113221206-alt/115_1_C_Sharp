using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Birth_Date_String
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows Forms 的視覺樣式。
            Application.EnableVisualStyles();

            // 使用預設的文字繪製設定，確保控制項文字正常顯示。
            Application.SetCompatibleTextRenderingDefault(false);

            // 建立並顯示主表單。
            Application.Run(new Form1());
        }
    }
}
