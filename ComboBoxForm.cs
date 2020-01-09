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
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的专业是：" + comboBox1.Text, "提示");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("该专业已经存在！");
                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                    MessageBox.Show("添加成功！","Tips");
                }
                
            }
            else
            {
                MessageBox.Show("请输入专业！", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.Contains(comboBox1.Text))
                {
                    comboBox1.Items.Remove(textBox1.Text);
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("你输入的专业不存在！", "提示");
                }
            }
            else
            {
                MessageBox.Show("请输入您要删除的专业！","提示");
            }
        }
    }
}
