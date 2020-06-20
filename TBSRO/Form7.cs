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
    public partial class Form7 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");

        public Form7()
        {
            
            InitializeComponent();
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            Kapatma();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            RadioButton selectedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            baglantı.Open();
            Form4 nesne = new Form4();
            OleDbCommand da = new OleDbCommand("INSERT INTO KoltukNo(VagonTuru,Vagon,KoltukNo) VALUES('" + nesne.VagonTuru1.Text + "','" + nesne.Vagon2.Text + "','" + selectedButton.TabIndex + "')", baglantı);
            OleDbDataReader oku1 = null;
            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {
                
            }

            baglantı.Close();
            selectedButton.Enabled = false;
            this.Close();
        }
        private void Kapatma()
        {

            Form4 fm4 = new Form4();
            baglantı.Open();
            OleDbCommand da = new OleDbCommand("SELECT VagonTuru,Vagon,KoltukNo FROM KoltukNo WHERE VagonTuru='" + fm4.VagonTuru1.Text + "' and Vagon ='" + fm4.Vagon2.Text + "' ", baglantı);
            OleDbDataReader oku1 = null;

            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {
                if (oku1["KoltukNo"].ToString() == p21.TabIndex.ToString())
                {
                    p21.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p22.TabIndex.ToString())
                {
                    p22.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p23.TabIndex.ToString())
                {
                    p23.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p24.TabIndex.ToString())
                {
                    p24.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p25.TabIndex.ToString())
                {
                    p25.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p26.TabIndex.ToString())
                {
                    p26.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p27.TabIndex.ToString())
                {
                    p27.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p28.TabIndex.ToString())
                {
                    p28.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p29.TabIndex.ToString())
                {
                    p29.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p210.TabIndex.ToString())
                {
                    p210.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p211.TabIndex.ToString())
                {
                    p211.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p212.TabIndex.ToString())
                {
                    p212.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p213.TabIndex.ToString())
                {
                    p213.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p214.TabIndex.ToString())
                {
                    p214.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p215.TabIndex.ToString())
                {
                    p215.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p216.TabIndex.ToString())
                {
                    p216.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p217.TabIndex.ToString())
                {
                    p217.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p218.TabIndex.ToString())
                {
                    p218.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p219.TabIndex.ToString())
                {
                    p219.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p220.TabIndex.ToString())
                {
                    p220.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p221.TabIndex.ToString())
                {
                    p221.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p222.TabIndex.ToString())
                {
                    p222.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p223.TabIndex.ToString())
                {
                    p223.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p224.TabIndex.ToString())
                {
                    p224.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p225.TabIndex.ToString())
                {
                    p225.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p226.TabIndex.ToString())
                {
                    p226.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p227.TabIndex.ToString())
                {
                    p227.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p228.TabIndex.ToString())
                {
                    p228.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p229.TabIndex.ToString())
                {
                    p229.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p230.TabIndex.ToString())
                {
                    p230.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p231.TabIndex.ToString())
                {
                    p231.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p232.TabIndex.ToString())
                {
                    p232.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p233.TabIndex.ToString())
                {
                    p233.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p234.TabIndex.ToString())
                {
                    p234.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p235.TabIndex.ToString())
                {
                    p235.Enabled = false;
                }           
                if (oku1["KoltukNo"].ToString() == p236.TabIndex.ToString())
                {
                    p236.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p237.TabIndex.ToString())
                {
                    p237.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p238.TabIndex.ToString())
                {
                    p238.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p239.TabIndex.ToString())
                {
                    p239.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p240.TabIndex.ToString())
                {
                    p240.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p241.TabIndex.ToString())
                {
                    p241.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p242.TabIndex.ToString())
                {
                    p242.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p243.TabIndex.ToString())
                {
                    p243.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p244.TabIndex.ToString())
                {
                    p244.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p245.TabIndex.ToString())
                {
                    p245.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p246.TabIndex.ToString())
                {
                    p246.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p247.TabIndex.ToString())
                {
                    p247.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p248.TabIndex.ToString())
                {
                    p248.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p249.TabIndex.ToString())
                {
                    p249.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p250.TabIndex.ToString())
                {
                    p250.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p251.TabIndex.ToString())
                {
                    p251.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p252.TabIndex.ToString())
                {
                    p252.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p253.TabIndex.ToString())
                {
                    p252.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p254.TabIndex.ToString())
                {
                    p253.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p255.TabIndex.ToString())
                {
                    p254.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p256.TabIndex.ToString())
                {
                    p255.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p257.TabIndex.ToString())
                {
                    p257.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p258.TabIndex.ToString())
                {
                    p258.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p259.TabIndex.ToString())
                {
                    p259.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p260.TabIndex.ToString())
                {
                    p260.Enabled = false;
                }

            }
            baglantı.Close();
        }

        private void p21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
