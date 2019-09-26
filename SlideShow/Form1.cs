using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class Form1 : Form
    {
        int i = 0, j;
        public Form1()
        {
            InitializeComponent();
        }

        public void loadImage()
        {
            if (i > 9)
                i = 0;

            if (i + 1 < 10)
                pictureBox1.ImageLocation = @"images\pic0" + (i + 1) + ".jpg";
                else pictureBox1.ImageLocation = @"images\pic" + (i + 1) + ".jpg";

            if (i + 1 < 10)
                pictureBox4.ImageLocation = @"images\pic0" + (i + 1) + ".jpg";
            else pictureBox4.ImageLocation = @"images\pic" + (i + 1) + ".jpg";

            j = (i - 1) < 0 ? 9 - i : i;
            if (j + 1 - 1 < 10)
                pictureBox3.ImageLocation = @"images\pic0" + (j + 1 - 1) + ".jpg";
                else pictureBox3.ImageLocation = @"images\pic" + (j + 1 - 1) + ".jpg";

            j = (i - 2) < 0 ? 9 + i - 1 : i;
            if (j + 1 - 2 < 10)
                pictureBox2.ImageLocation = @"images\pic0" + (j + 1 - 2) + ".jpg";
                else pictureBox2.ImageLocation = @"images\pic" + (j + 1 - 2) + ".jpg";

            j = (i >= 9)? i % 9 : i;
            if (j + 2 < 10)
                pictureBox5.ImageLocation = @"images\pic0" + (j + 2) + ".jpg";
                else pictureBox5.ImageLocation = @"images\pic" + (j + 2) + ".jpg";

            j = (i >= 8) ? i % 8 : i;
            if (j + 3 < 10)
                pictureBox6.ImageLocation = @"images\pic0" + (j + 3) + ".jpg";
                else pictureBox6.ImageLocation = @"images\pic" + (j + 3) + ".jpg";

            i++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadImage();
        }
    }
}
