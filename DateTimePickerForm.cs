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
    public partial class DateTimePickerForm : Form
    {
        public DateTimePickerForm()
        {
            InitializeComponent();
        }

        private void DateTimePickerForm_Load(object sender, EventArgs e)
        {
            //设置只显示时间
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            //设置每隔一秒用一次定时器Tick事件
            timer1.Interval = 1000;//1s
            //启动定时器
            timer1.Start();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //重新设置日期时间控件的文本
            dateTimePicker1.ResetText();
        }
    }
}
