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
using System.Collections;

namespace TBSRO
{
    public partial class Form3 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Sefer();
            SeferBilgileri();
            


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 yeni5 = new Form5();

            yeni5.Show();
        }

        private void comboBoxNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNereye.Items.Clear();
            if (comboBoxNereden.SelectedItem.ToString() == "Adana")
            {

                string[] a = { "Pozantı", "Ulukışla", "Ereğli", "Konya" };

                comboBoxNereye.Items.AddRange(a);
            }
            if (comboBoxNereden.SelectedItem.ToString() == "Ankara")
            {
                string[] a = { "Kayseri", "Sivas", "Erzincan", "Erzurum", "Kars", "Malatya", "Tatvan", "Elazığ", "Diyar", "Kurtalan" };

                comboBoxNereye.Items.AddRange(a);
            }
            if (comboBoxNereden.SelectedItem.ToString() == "Elazığ")
            {
                string[] a = { "Ankara", "Kayseri", "Sivas", "Malatya", "Tatvan" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Ereğli")
            {
                string[] a = { "Adana", "Konya", "Pozantı", "Ulukışla" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Ereğli")
            {
                string[] a = { "Adana", "Konya", "Pozantı", "Ulukışla" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Erzincan")
            {
                string[] a = { "Ankara", "Kayseri", "Sivas", "Erzurum", "Kars" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Erzurum")
            {
                string[] a = { "Ankara", "Kayseri", "Sivas", "Erzincan", "Kars" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Diyarbakır")
            {
                string[] a = { "Ankara", "Kayseri", "Sivas", "Malatya", "Kurtalan" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Kars")
            {
                string[] a = { "Ankara", "Kayseri", "Sivas", "Erzincan", "Erzurum" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Kayseri")
            {
                string[] a = { "Ankara", "Diyarbakır", "Elazığ", "Erzincan", "Erzurum", "Kars", "Kurtalan", "Malatya", "Sivas", "Tatvan" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Kurtalan")
            {
                string[] a = { "Ankara", "Diyarbakır", "Malatya", "Kayseri", "Sivas" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Konya")
            {
                string[] a = { "Adana", "Ereğli", "Pozantı", "Ulukışla" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Malatya")
            {
                string[] a = { "Ankara", "Diyarbakır", "Elazığ", "Kurtalan", "Sivas", "Tatvan" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Pozantı")
            {
                string[] a = { "Adana", "Ereğli", "konya", "Ulukışla" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Ulukışla")
            {
                string[] a = { "Adana", "Ereğli", "Konya", "Pozantı" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Sivas")
            {
                string[] a = { "Ankara", "Diyarbakır", "Elazığ", "Erzincan", "Erzurum", "Kars", "Kayseri", "Kurtalan", "Malatya", "Tatvan" };

                comboBoxNereye.Items.AddRange(a);

            }
            if (comboBoxNereden.SelectedItem.ToString() == "Tatvan")
            {
                string[] a = { "Ankara",  "Elazığ", "Kayseri", "Sivas", "Malatya" };

                comboBoxNereye.Items.AddRange(a);

            }
        }
        private void comboBoxNereye_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBGidisDonus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {       

        }

        private void Sefer()
        {

            string nereden = comboBoxNereden.SelectedText;
            string nereye = comboBoxNereye.SelectedText;

            baglantı.Open();
            OleDbCommand da = new OleDbCommand("SELECT GidisTarihi FROM SeferBilgileri1 WHERE Nereden='"+comboBoxNereden.Text+"' and Nereye ='"+comboBoxNereye.Text+"' ", baglantı);
            OleDbDataReader oku1 = null;
            
            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku1["GidisTarihi"].ToString();
                listView1.Items.Add(ekle);
                
            }

            if (listView1.Items[0].Text==dateTimeGidis.Value.ToString("dddd"))
            {
                Form4 yeni4 = new Form4();

                yeni4.ShowDialog();
            }
            if (listView1.Items[1].Text == dateTimeGidis.Value.ToString("dddd"))
            {
                Form4 yeni4 = new Form4();

                yeni4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sefer bulunamadı.");
            }

            baglantı.Close();

        }
        private void SeferBilgileri()
        {
            baglantı.Open();
            Form4 nesne = new Form4();
            OleDbCommand da = new OleDbCommand("SELECT Cikis,Varis,Sure,TrenAdi,Ucret FROM SeferBilgileri1 WHERE Nereden='" + comboBoxNereden.Text + "' and Nereye ='" +comboBoxNereye.Text + "' and GidisTarihi ='" + dateTimeGidis.Value.ToString("dddd") + "' ", baglantı);
            OleDbDataReader oku1 = null;
            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {
                nesne.textBox5.Text = oku1["Cikis"].ToString();
                nesne.textBox4.Text = oku1["Varis"].ToString();
                nesne.textBox3.Text = oku1["Sure"].ToString();
                nesne.textBox2.Text = oku1["TrenAdi"].ToString();
                nesne.textBox1.Text = oku1["Ucret"].ToString();

            }
            baglantı.Close();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
