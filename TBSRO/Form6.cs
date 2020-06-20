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
    public partial class Form6 : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=TBSROdata.mdb");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            Form3 fm3 = new Form3();
            OleDbCommand da = new OleDbCommand("SELECT Cikis,Sure,Varis,Ucret,TrenAdi FROM SeferBilgileri1 WHERE Nereden='" + fm3.comboBoxNereden + "' and Nereden='" + fm3.comboBoxNereye + "'  ", baglantı);
            OleDbDataReader oku1 = null;
            oku1 = da.ExecuteReader();
            while (oku1.Read())
            {
                label19.Text = oku1["Cikis"].ToString();
                label20.Text = oku1["Sure"].ToString();
                label21.Text = oku1["Varis"].ToString();
                label22.Text = oku1["TrenAdi"].ToString();
                label23.Text = oku1["Ucret"].ToString();
            }
            baglantı.Close();
        }

        private void btnTekrarBilet_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }


}
