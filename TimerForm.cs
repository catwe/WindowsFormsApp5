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
    public partial class TimerForm : Form
    {
        //设置当前图片空间中显示的图片
        //如果是 Timer1.jpg   flag的值为FALSE
        //如果是 Timer2.jpg   flag的值为TRUE
        bool flag = false;
        int times = 10000;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"G:\\王者皮肤\\105-廉颇-地狱岩魂.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //设置每隔1秒调用一次定时器Tick事件
            timer1.Interval = times;
            //启动定时器
            timer1.Start();
        }
        //触发定时器的事件，在该事件中切换图片
        private void timer1_Tick(object sender, EventArgs e)
        {
            //当flag的值为TRUE时将图片控件的Image属性切换到Timer1.jpg
            //否则将图片的Image属性切换到Timer2.jpg
            if (flag)
            {
                pictureBox1.Image = Image.FromFile(@"G:\\王者皮肤\\105-廉颇-地狱岩魂.jpg");
                flag = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"G:\\王者皮肤\\106-小乔-缤纷独角兽.jpg");
                flag = true;
            }
        }
        //启动按钮
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show("开始计时.....大概" + times + "毫秒后切换图片");
        }
        //关闭按钮
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("停止计时成功！");
        }
    }
}
