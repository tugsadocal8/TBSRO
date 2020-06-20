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
    public partial class Form15 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");

        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            Kapatma80();
        }

        private void Kapatma80()
        {

            Form4 fm4 = new Form4();
            baglantı.Open();
            OleDbCommand da = new OleDbCommand("SELECT VagonTuru,Vagon,KoltukNo FROM KoltukNo WHERE VagonTuru='" + fm4.VagonTuru3.Text + "' and Vagon ='" + fm4.Vagon10.Text + "' ", baglantı);
            OleDbDataReader oku1 = null;

            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {
                if (oku1["KoltukNo"].ToString() == p31.TabIndex.ToString())
                {
                    p31.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p32.TabIndex.ToString())
                {
                    p32.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p33.TabIndex.ToString())
                {
                    p33.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p34.TabIndex.ToString())
                {
                    p34.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p35.TabIndex.ToString())
                {
                    p35.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p36.TabIndex.ToString())
                {
                    p36.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p37.TabIndex.ToString())
                {
                    p37.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p38.TabIndex.ToString())
                {
                    p38.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p39.TabIndex.ToString())
                {
                    p39.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p310.TabIndex.ToString())
                {
                    p310.Enabled = false;
                }

                if (oku1["KoltukNo"].ToString() == p313.TabIndex.ToString())
                {
                    p313.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p314.TabIndex.ToString())
                {
                    p314.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p315.TabIndex.ToString())
                {
                    p315.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p316.TabIndex.ToString())
                {
                    p316.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p317.TabIndex.ToString())
                {
                    p317.Enabled = false;
                }
                if (oku1["KoltukNo"].ToString() == p318.TabIndex.ToString())
                {
                    p318.Enabled = false;
                }




            }
            baglantı.Close();
        }

        private void btnOnayla_Click_1(object sender, EventArgs e)
        {

            RadioButton selectedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            baglantı.Open();
            Form4 nesne = new Form4();
            OleDbCommand da = new OleDbCommand("INSERT INTO KoltukNo(VagonTuru,Vagon,KoltukNo) VALUES('" + nesne.VagonTuru3.Text + "','" + nesne.Vagon10.Text + "','" + selectedButton.TabIndex + "')", baglantı);
            OleDbDataReader oku1 = null;
            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {

            }

            baglantı.Close();
            selectedButton.Enabled = false;
            this.Close();
        }
    }
}
