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
    public partial class ContextMenuStripForm : Form
    {
        public ContextMenuStripForm()
        {
            InitializeComponent();
        }

        private void 打开窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStripForm meun1 = new ContextMenuStripForm();
            meun1.Show();
        }

        private void 关闭窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
