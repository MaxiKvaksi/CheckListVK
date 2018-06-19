using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList
{
    public partial class BigImage : Form
    {
        public BigImage(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            ToolTip tip = new ToolTip();
            tip.SetToolTip(pictureBox1, "Нажми на изображение, чтобы закрыть");
        }

        private void BigImage_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
