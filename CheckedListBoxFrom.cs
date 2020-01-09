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
    public partial class CheckedListBoxFrom : Form
    {
        public CheckedListBoxFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            for(int i =0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                msg = msg + " " + checkedListBox1.CheckedItems[i].ToString();
                
            }
            if (msg != "")
            {
                MessageBox.Show("您喜欢的水果有" + msg, "提示");
            }
            else
            {
                MessageBox.Show("您没有选择水果", "警告");
            }
        }
    }
}
