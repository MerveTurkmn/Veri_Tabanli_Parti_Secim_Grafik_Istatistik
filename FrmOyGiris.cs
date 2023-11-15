using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veri_Tabanlı_Parti_Seçim_Grafik_İstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-HLMQ9PKG;Initial Catalog=DBSECIMPROJE;Integrated Security=True");
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("P1", TxtilceAd.Text);
            komut.Parameters.AddWithValue("P2", TxtA.Text);
            komut.Parameters.AddWithValue("P3", TxtB.Text);
            komut.Parameters.AddWithValue("P4", TxtC.Text);
            komut.Parameters.AddWithValue("P5", TxtD.Text);
            komut.Parameters.AddWithValue("P6", TxtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti.");

        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
