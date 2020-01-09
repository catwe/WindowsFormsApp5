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
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                msg = msg + " " + listBox1.SelectedItems[i].ToString();

            }
            if (msg != "")
            {
                MessageBox.Show("您喜欢的运动有" + msg, "提示");
            }
            else
            {
                MessageBox.Show("您没有选择运动", "警告");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //由于列表框控件中允许多选所以需要循环删除所有已选项
            int count = listBox1.SelectedItems.Count;
            List<string> itemValues = new List<string>();
            if (count != 0)
            {
                for(int i = 0; i < count; i++)
                {
                    itemValues.Add(listBox1.SelectedItems[i].ToString());
                }
                foreach(string item in itemValues)
                {
                    listBox1.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("请选择您要删除的选项！", "提示");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //将文本框中的内容添加到列表框
            if (textBox1.Text!= "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("请添加爱好！", "Tips");
            }

        }
    }
}
