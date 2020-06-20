using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSRO
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll_2(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value<=25 && vScrollBar1.Value>=0)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                
            }
            if (vScrollBar1.Value>25 && vScrollBar1.Value <=50 )
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
