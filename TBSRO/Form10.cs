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
    public partial class Form10 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Kapatma5();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            RadioButton selectedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            baglantı.Open();
            Form4 nesne = new Form4();
            OleDbCommand da = new OleDbCommand("INSERT INTO KoltukNo(VagonTuru,Vagon,KoltukNo) VALUES('" + nesne.VagonTuru2.Text + "','" + nesne.Vagon5.Text + "','" + selectedButton.TabIndex + "')", baglantı);
            OleDbDataReader oku1 = null;
            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {

            }

            baglantı.Close();
            selectedButton.Enabled = false;
            this.Close();
        }

        private void Kapatma5()
        {

            Form4 fm4 = new Form4();
            baglantı.Open();
            OleDbCommand da = new OleDbCommand("SELECT VagonTuru,Vagon,KoltukNo FROM KoltukNo WHERE VagonTuru='" + fm4.VagonTuru2.Text + "' and Vagon ='" + fm4.Vagon5.Text + "' ", baglantı);
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



            }
            baglantı.Close();
        }
    }
}
