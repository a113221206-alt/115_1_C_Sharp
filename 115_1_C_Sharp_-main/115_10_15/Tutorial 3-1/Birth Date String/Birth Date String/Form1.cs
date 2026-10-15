using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有視覺元件。
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 依照星期、月份、日期與年份輸入內容組合完整日期字串。
            string output;

            output = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", " + yearTextBox.Text;

            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除所有輸入欄位以及畫面上的日期結果。
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = ""; 
            dayOfMonthTextBox.Text = "";    
            yearTextBox.Text = "";  

            dateOutputLabel.Text = "";  
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單並結束應用程式。
            this.Close();
        }
    }
}
