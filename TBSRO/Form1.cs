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
    public partial class Form1 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");


        public Form1()
        {
            InitializeComponent();
        }
        private void txtSifreGir_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglantı.Open();
            OleDbCommand kaydetcmd = new OleDbCommand("SELECT * From kayitBilgileri WHERE TC = '" + txtTCGir.Text + "' AND Sifre = '" + txtSifreGir.Text + "'", baglantı);
            OleDbDataReader oku = kaydetcmd.ExecuteReader();
            
            if (oku.Read())
            {
                // Eğer bağlantı başarı ile sağlanıp kullanıcı adı ve şifre doğru olması durumunda yapılacak işlemler.
                Form3 fm3 = new Form3();
                fm3.ShowDialog();
                

            } 
            else if (txtTCGir.Text == " ")
            {

                MessageBox.Show("Kullanıcı Adı Alanı Boş Bırakılamaz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantı.Close();
            }
            // Parola kısmının boş bırakıldığı durumda yapılacaklar
            else if (txtSifreGir.Text == " ")
            {

                MessageBox.Show("Parola Alanı Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantı.Close();
            }
            // Yanlış şifre girildiğinde
            else
            {

                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantı.Close();
            }
            

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void txtTCGir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
