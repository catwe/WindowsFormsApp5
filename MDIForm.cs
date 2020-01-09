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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileForm f = new OpenFileForm();
            f.MdiParent = this;
            f.Show();
            
        }

        private void 关闭文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileForm d = new SaveFileForm();
            d.MdiParent = this;
            d.Show();
        }
    }
}
