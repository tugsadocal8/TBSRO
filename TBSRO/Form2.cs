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
    public partial class Form2 : Form
    {
        
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void il_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string a = (String)txtEposta.Text.ToString();
            string c = (String)txtSifre.Text.ToString();
            string b = (String)txtSifreYeniden.Text.ToString();
            string d = (String)txtTC.Text.ToString();
            string ee = (String)txtAd.Text.ToString();
            string f = (String)txtSoyad.Text.ToString();
            string g = (String)txtCepTelefonu.Text.ToString();
            
            if (a.Length == 0|| c != b|| d.Length!=11 || ee.Length ==0 ||f.Length==0)
            {
                MessageBox.Show("* içeren alanları uygun bir şekilde doldurunuz","Hatalı Giriş",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form2 yeniden = new Form2();
                yeniden.Show();
            }
            Kaydet();
            
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCepTelefonu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCepTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sadece sayı
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
            if (txtCepTelefonu.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sadece sayı
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
            if (textBox9.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sadece sayı
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }

            if (txtTC.TextLength == 11)
            {
                e.Handled = true;
            }
        }
        private void temizle()
        {
            txtEposta.Clear(); txtSifre.Clear(); txtAd.Clear(); txtSoyad.Clear(); txtCepTelefonu.Clear(); txtTC.Clear(); txtAdres.Clear(); txtMeslek.Clear();
        }
        private void Kaydet()
        {
            OleDbCommand kaydet = new OleDbCommand("INSERT INTO kayitBilgileri ( Eposta,TC,Sifre, Ad, Soyad,Cinsiyet,DogumTarihi,CepTelefonu,Adres,Meslek,Egitim,İl,KanGrubu) VALUES ('" + txtEposta.Text + "','" + txtTC.Text + "','" + txtSifre.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + checkedListBoxCinsiyet.Text + "','" + dateTimePicker1.Value + "','" + txtCepTelefonu.Text + "','" + txtAdres.Text + "','" + txtMeslek.Text + "','" + listBoxEgitim.SelectedItem + "','" + listBoxIl.SelectedItem + "','" + listBoxKan.SelectedItem + "')", baglantı);
            baglantı.Open();
            kaydet.ExecuteNonQuery();
            baglantı.Close();
            temizle();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
                           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
