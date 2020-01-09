using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class MonthCalendarForm : Form
    {
        public MonthCalendarForm()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void MonthCalendarForm_Load(object sender, EventArgs e)
        {
            monthCalendar1.Hide();//隐藏日历
        }
        //“选择”按钮单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //显示日历控件
            monthCalendar1.Show();
        }
        //日历控件的日期改变事件
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //将选择的日期显示在文本框中
            textBox1.Text = monthCalendar1.SelectionStart.ToLongDateString();
            monthCalendar1.Hide();
        }
    }
}
