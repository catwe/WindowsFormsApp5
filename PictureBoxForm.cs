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
    public partial class PictureBoxForm : Form
    {
        public PictureBoxForm()
        {
            InitializeComponent();
        }

        private void PictureBoxForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"G:\\王者皮肤\\105-廉颇-地狱岩魂.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile(@"G:\\王者皮肤\\106-小乔-缤纷独角兽.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //定义中间变量存放图片空件地址
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox.Image;
        }
    }
}
