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

namespace library
{
    public partial class Form1 : Form
    {
        string tür,aranerde,araney;

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb");
        public Form1()
        {
            InitializeComponent();
           
        }
        int say = 0;
        private void verigöster()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from kitaplar", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["kitap_ad"].ToString());
                ekle.SubItems.Add(oku["yazar_ad"].ToString());
                ekle.SubItems.Add(oku["yayinevi"].ToString());
                ekle.SubItems.Add(oku["kitap_kod"].ToString());
                ekle.SubItems.Add(oku["kitap_tür"].ToString());
                listView1.Items.Add(ekle);
                say++;
            }
            baglanti.Close();
            topkitap.Text = "Toplam kitap:" + say;
            say = 0;

        }
     
        private void veritür()
        {
            
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM kitaplar WHERE kitap_tür='"+tür+"'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
               
                ListViewItem ekle = new ListViewItem();
                
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["kitap_ad"].ToString());
                ekle.SubItems.Add(oku["yazar_ad"].ToString());
                ekle.SubItems.Add(oku["yayinevi"].ToString());
                ekle.SubItems.Add(oku["kitap_kod"].ToString());
                ekle.SubItems.Add(oku["kitap_tür"].ToString());
                say++;
                listView1.Items.Add(ekle);
                
            }
            baglanti.Close();
            topkitap.Text = "Toplam kitap:" + say;
            say = 0;
        }
        private void veriara()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM kitaplar WHERE "+aranerde+"='" + araney + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["kitap_ad"].ToString());
                ekle.SubItems.Add(oku["yazar_ad"].ToString());
                ekle.SubItems.Add(oku["yayinevi"].ToString());
                ekle.SubItems.Add(oku["kitap_kod"].ToString());
                ekle.SubItems.Add(oku["kitap_tür"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigöster();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            verigöster();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tür = "klasik";
            veritür();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tür = "tarih";
            veritür();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tür = "bilimkurgu";
            veritür();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tür = "tarih";
            veritür();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (kitapcheck.Checked = true && yazarcheck.Checked == false&& evcheck.Checked == false&& kodcheck.Checked == false)
            {

                listView1.Items.Clear();


                aranerde = "kitap_ad";
                araney = textBox1.Text;
                veriara();

            }
            else if (yazarcheck.Checked = true && kitapcheck.Checked == false &&  evcheck.Checked == false && kodcheck.Checked == false)
            {
                listView1.Items.Clear();
                aranerde = "yazar_ad";
                araney = textBox1.Text;
                veriara();
            }
            else if (evcheck.Checked = true && kitapcheck.Checked == false && yazarcheck.Checked == false &&  kodcheck.Checked == false)
            {
                listView1.Items.Clear();
                aranerde = "yazarevi";
                araney = textBox1.Text;
                veriara();
            }
            else if (kodcheck.Checked = true && kitapcheck.Checked == false && yazarcheck.Checked == false && evcheck.Checked == false )
            {
                listView1.Items.Clear();
                aranerde = "kitap_kod";
                araney = textBox1.Text;
                veriara();
            }
            else { textBox1.Text = "hattalı!!"; }
        }

        private void yazarcheck_CheckedChanged(object sender, EventArgs e)
        {
            kitapcheck.Enabled = false;
            evcheck.Enabled = false;
            kodcheck.Enabled = false;
        }

        private void evcheck_CheckedChanged(object sender, EventArgs e)
        {
            kitapcheck.Enabled = false;
            yazarcheck.Enabled = false;
            
            kodcheck.Enabled = false;
        }

        private void kodcheck_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void kodcheck_CheckedChanged(object sender, EventArgs e)
        {
            kitapcheck.Enabled = false;
            yazarcheck.Enabled = false;
            evcheck.Enabled = false;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eklemeyap.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kitapad, yazarad, kitapev, kod,yenitür;
            kitapad = yenikitapad.Text;
            yazarad = yeniyazarad.Text;
            kitapev = yenikitapevi.Text;
            kod = yenikod.Text;
            yenitür = yenitürbox.Text;
            if (yenikitapad.Text != ""&&yenikitapevi.Text!=""&&yeniyazarad.Text!=""&&yenikod.Text!=""&&yenitürbox.Text!="")
            { 
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText=("INSERT INTO kitaplar(kitap_ad,yazar_ad,yayinevi,kitap_kod,kitap_tür)"+ "VALUES('" + kitapad + "','" + yazarad + "','" +kitapev + "','" +kod + "','" + yenitür + "')");
            komut.ExecuteNonQuery();
                yeniuyari.Text = "Kayıt başarılı"; yeniuyari.Visible = true;


                baglanti.Close();
            }
            else { yeniuyari.Text = "Boş Bırakmayınız"; yeniuyari.Visible = true; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eklemeyap.Visible = false;
        }

      

       
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            yazar yaz = new yazar();
            yaz.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            yayinci yay = new yayinci();
            yay.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            excel ex = new excel();
            ex.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitapcheck.Checked = false;
            yazarcheck.Checked = false;
            evcheck.Checked = false;
            kodcheck.Checked = false;
            kitapcheck.Enabled = true;
            yazarcheck.Enabled = true;
            evcheck.Enabled = true;
            kodcheck.Enabled = true;
           

        }

        private void kitapcheck_CheckedChanged(object sender, EventArgs e)
        {
            yazarcheck.Enabled = false;
            evcheck.Enabled = false;
            kodcheck.Enabled = false;
        }
    }
}
