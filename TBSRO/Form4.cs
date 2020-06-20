using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TBSRO
{
    public partial class Form4 : Form
    {

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");
        
        public Form4()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox187_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox244_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            Form6 fm6 = new Form6();
            
            baglantı.Close();
            
            fm6.Show();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }




        private void button5_Click(object sender, EventArgs e)
        {
            Form7 fm7 = new Form7();
            fm7.Show();
        }

        private void Vagon3_Click(object sender, EventArgs e)
        {
            Form8 fm8 = new Form8();
            fm8.Show();
        }

        private void Vagon4_Click(object sender, EventArgs e)
        {
            Form9 fm9 = new Form9();
            fm9.Show();
        }

        private void Vagon5_Click(object sender, EventArgs e)
        {
            Form10 fm9 = new Form10();
            fm9.Show();
        }

        private void Vagon6_Click(object sender, EventArgs e)
        {
            Form11 fm9 = new Form11();
            fm9.Show();
        }

        private void Vagon7_Click(object sender, EventArgs e)
        {
            Form12 fm9 = new Form12();
            fm9.Show();
        }

        private void Vagon8_Click(object sender, EventArgs e)
        {
            Form13 fm9 = new Form13();
            fm9.Show();
        }

        private void Vagon9_Click(object sender, EventArgs e)
        {
            Form14 fm9 = new Form14();
            fm9.Show();
        }

        private void Vagon10_Click(object sender, EventArgs e)
        {
            Form15 fm9 = new Form15();
            fm9.Show();

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
