using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace BlackjackOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        


        private void Form1_Load(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL=@" GörselProglamaFinal/BlackjackOyunu/gamesound.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Visible = false;
        }
        int gamer = 0, npc = 0,sayac=0,bahis=0,butce=1000,gamerrank=0,npcrank=0,sayac2,sayac3,sans=0,tl=0;
        int sayac5 = 0;
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (comboBox2.SelectedItem == "30P")
            {
                if (MessageBox.Show("Puan bozdurmayı onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (butce >= 30)
                    {
                        tl += 5;
                        label12.Text = tl.ToString();
                        butce -= 30;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan bozdurma işlemi başarıyla gerçekleştirildi.", "Puan bozdur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Puanınız yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan bozdurma işlemi tarafınızca iptal edilmiştir.", "Puan bozdurma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox2.SelectedItem == "60P")
            {
                if (MessageBox.Show("Puan bozdurmayı onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (butce >= 60)
                    {
                        tl += 10;
                        label12.Text = tl.ToString();
                        butce -= 60;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan bozdurma işlemi başarıyla gerçekleştirildi.", "Puan bozdur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Puanınız yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan bozdurma işlemi tarafınızca iptal edilmiştir.", "Puan bozdurma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox2.SelectedItem == "150P")
            {
                if (MessageBox.Show("Puan bozdurma onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (butce >= 150)
                    {
                        tl += 25;
                        label12.Text = tl.ToString();
                        butce -= 150;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan bozdurma işlemi başarıyla gerçekleştirildi.", "Puan bozdur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Puanınız yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan bozdurma işlemi tarafınızca iptal edilmiştir.", "Puan bozdurma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox2.SelectedItem == "300P")
            {
                if (MessageBox.Show("Puan bozdurmayı onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (butce >= 300)
                    {
                        tl += 50;
                        label12.Text = tl.ToString();
                        butce -= 300;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan bozdurma işlemi başarıyla gerçekleştirildi.", "Puan bozdur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Puanınız yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan bozdurma işlemi tarafınızca iptal edilmiştir.", "Puan bozdurma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox2.SelectedItem == "600P")
            {
                if (MessageBox.Show("Puan bozdurmayı onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (butce >= 600)
                    {
                        tl += 100;
                        label12.Text = tl.ToString();
                        butce -= 600;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan bozdurma işlemi başarıyla gerçekleştirildi.", "Puan bozdur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Puanınız yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan bozdurma işlemi tarafınızca iptal edilmiştir.", "Puan bozdurma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Puan bozdurma işlemi  iptal edilmiştir.", "Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == "20P")
            {
                if (MessageBox.Show("Puan çevirmeyi onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tl >= 5)
                    {
                        tl -= 5;
                        label12.Text = tl.ToString();
                        butce += 20;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan çevirme işlemi başarıyla gerçekleştirildi.", "Puan Çevirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("TL'niz yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan çevrime işlemi tarafınızca iptal edilmiştir.", "Puan Çevirme İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox4.SelectedItem == "45P")
            {
                if (MessageBox.Show("Puan çevirmeyi onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tl >= 10)
                    {
                        tl -= 10;
                        label12.Text = tl.ToString();
                        butce += 45;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan çevirme işlemi başarıyla gerçekleştirildi.", "Puan Çevirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("TL'niz yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan çevrime işlemi tarafınızca iptal edilmiştir.", "Puan Çevirme İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox4.SelectedItem == "100P")
            {
                if (MessageBox.Show("Puan çevirmeyi onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tl >= 25)
                    {
                        tl -= 25;
                        label12.Text = tl.ToString();
                        butce += 100;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan çevirme işlemi başarıyla gerçekleştirildi.", "Puan Çevirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("TL'niz yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan çevrime işlemi tarafınızca iptal edilmiştir.", "Puan Çevirme İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox4.SelectedItem == "200P")
            {
                if (MessageBox.Show("Puan çevirmeyi onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tl >= 50)
                    {
                        tl -= 50;
                        label12.Text = tl.ToString();
                        butce += 200;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan çevirme işlemi başarıyla gerçekleştirildi.", "Puan Çevirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("TL'niz yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan çevrime işlemi tarafınızca iptal edilmiştir.", "Puan Çevirme İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox4.SelectedItem == "400P")
            {
                if (MessageBox.Show("Puan çevirmeyi onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tl >= 100)
                    {
                        tl -= 100;
                        label12.Text = tl.ToString();
                        butce += 400;
                        label1.Text = butce.ToString();
                        MessageBox.Show("Puan çevirme işlemi başarıyla gerçekleştirildi.", "Puan Çevirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("TL'niz yetersiz puan çevirme iptal edilmiştir.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Puan çevrime işlemi tarafınızca iptal edilmiştir.", "Puan Çevirme İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Puan çevirme işlemi  iptal edilmiştir.", "Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "5TL")
            {

                if (MessageBox.Show("Satın almayı onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tl += 5;
                    label12.Text = tl.ToString();
                    MessageBox.Show("Satın alma işlemi başarıyla gerçekleştirildi.", "Satın alma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Satın alma işlemi tarafınızca iptal edilmiştir.", "Satın alma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (comboBox3.SelectedItem == "10TL")
            {

                if (MessageBox.Show("Satın almayı onaylıyormusunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tl += 10;
                    label12.Text = tl.ToString();
                    MessageBox.Show("Satın alma işlemi başarıyla gerçekleştirildi.", "Satın alma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Satın alma işlemi tarafınızca iptal edilmiştir.", "Satın alma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (comboBox3.SelectedItem == "25TL")
            {

                if (MessageBox.Show("Satın almayı onaylıyormusunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tl += 25;
                    label12.Text = tl.ToString();
                    MessageBox.Show("Satın alma işlemi başarıyla gerçekleştirildi.", "Satın alma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Satın alma işlemi tarafınızca iptal edilmiştir.", "Satın alma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (comboBox3.SelectedItem == "50TL")
            {

                if (MessageBox.Show("Satın almayı onaylıyormusunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tl += 50;
                    label12.Text = tl.ToString();
                    MessageBox.Show("Satın alma işlemi başarıyla gerçekleştirildi.", "Satın alma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Satın alma işlemi tarafınızca iptal edilmiştir.", "Satın alma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (comboBox3.SelectedItem == "100TL")
            {

                if (MessageBox.Show("Satın almayı onaylıyormusunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tl += 100;
                    label12.Text = tl.ToString();
                }
                else
                {
                    MessageBox.Show("Satın alma işlemi tarafınızca iptal edilmiştir.", "Satın alma İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Satın alma işlemi  iptal edilmiştir.", "Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (butce >= 100&&sayac3==0)
            { 
            bahis += 100;
            butce -= 100;
            label1.Text = butce.ToString();
            label2.Text = bahis.ToString(); }
            else
                MessageBox.Show("Bütceniz yetersiz veya Oyun başladı");

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (butce >= 1000 && sayac3 == 0)
            {
                bahis += 1000;
                butce -= 1000;
                label1.Text = butce.ToString();
                label2.Text = bahis.ToString();
                    }
            else
                MessageBox.Show("Bütceniz yetersiz veya Oyun başladı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(sayac2==0)
          { 
            if (gamer > npc&&gamer!=21&& gamer <21) {
                MessageBox.Show("Tebrikler Kazandınız");
                butce += bahis * 2;
                bahis = 0;
                label1.Text = butce.ToString();
                gamerrank += 1;
                label7.Text = gamerrank.ToString();
                label2.Text = bahis.ToString();
                sayac2 += 1;
            }
            if (gamer == 21)
            {
                   
                butce +=bahis * 2;
                if (bahis >= 1000) { MessageBox.Show("Tebrikler 21 Tuturdunuz ekstra:" + "100" + " Puan Kazandınız"); butce += 100;sayac5 += 1; }
                if (bahis >= 10&&sayac5==0) { MessageBox.Show("Tebrikler 21 Tuturdunuz ekstra:" + "10" + " Puan Kazandınız"); butce += 10; }
                bahis = 0;
                label1.Text = butce.ToString();
                gamerrank += 1;
                label7.Text = gamerrank.ToString();
                label2.Text = bahis.ToString();
                sayac2 += 1;
            }

            if (npc>21 && gamer <= 21)
            {

                butce += bahis * 2;
                MessageBox.Show("Tebrikler Kazandınız");
                bahis = 0;
                label1.Text = butce.ToString();
                gamerrank += 1;
                label7.Text = gamerrank.ToString();
                label2.Text = bahis.ToString();
                sayac2 += 1;
            }
            if (npc>gamer&&npc<=21)
            {
                bahis = 0;
                MessageBox.Show("Kaybetin!!!! Bilgisayar KAZANDI ");
                npcrank += 1;
                label10.Text = npcrank.ToString();
                label2.Text = bahis.ToString();
                sayac2 += 1;
            }
            if (gamer>21 && npc <= 21)
            {
                bahis = 0;
                MessageBox.Show("Kaybetin!!!! Bilgisayar KAZANDI ");
                npcrank += 1;
                label10.Text = npcrank.ToString();
                label2.Text = bahis.ToString();
                sayac2 += 1;
            }

            if (gamer > 21&& npc > 21) {
                    if (sans >= 2) { MessageBox.Show("Büyük Talihsizlik!!!"); }
                MessageBox.Show("Berabere!!!");
                butce += bahis;
                bahis = 0;
                    label1.Text = butce.ToString();
                    label2.Text = bahis.ToString();
                sayac2 += 1;
            }

                if (gamer ==  npc&&gamer<=21&&npc<=21 )
                {
                    if (gamer == npc && gamer == 21) { MessageBox.Show("Büyük Beraberlik Tesadüf ödülünüz 1000 Puan!!!");butce += 1000; label1.Text = butce.ToString(); }
                    else { 
                    MessageBox.Show("Berabere!!!");
                    }
                    butce += bahis;
                    bahis = 0;
                    label1.Text = butce.ToString();
                    label2.Text = bahis.ToString();
                    sayac2 += 1;
                    
                }

            }
            else
                MessageBox.Show("Yeni oyun için Yenile tuşuna basın");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (Convert.ToInt16( label2.Text)>0&&gamer==0&&npc==0)
            {
                sayac3 += 1;
                
                Random rastgele = new Random();
                int kart1 = rastgele.Next(1, 13);
                int kart2 = rastgele.Next(1, 13);
                int Npckart1 = rastgele.Next(1, 13);
                int Npckart2 = rastgele.Next(1, 13);
                if(kart1==1) { pictureBox1.Image = global::BlackjackOyunu.Resource1._1; ; sayac += 1;sans += 1; }
                if (kart1 == 2) { pictureBox1.Image = global::BlackjackOyunu.Resource1._2; sayac += 1; }
                if (kart1 == 3) { pictureBox1.Image = global::BlackjackOyunu.Resource1._3; sayac += 1; }
                if (kart1 == 4) { pictureBox1.Image = global::BlackjackOyunu.Resource1._4; sayac += 1; }
                if (kart1 == 5) { pictureBox1.Image = global::BlackjackOyunu.Resource1._5; sayac += 1; }
                if (kart1 == 6) { pictureBox1.Image = global::BlackjackOyunu.Resource1._6; sayac += 1; }
                if (kart1 == 7) { pictureBox1.Image = global::BlackjackOyunu.Resource1._7; sayac += 1; }
                if (kart1 == 8) { pictureBox1.Image = global::BlackjackOyunu.Resource1._8; sayac += 1; }
                if (kart1 == 9) { pictureBox1.Image = global::BlackjackOyunu.Resource1._9; sayac += 1; }
                if (kart1 == 10) { pictureBox1.Image = global::BlackjackOyunu.Resource1._10; sayac += 1; }
                if (kart1 == 11) { pictureBox1.Image = global::BlackjackOyunu.Resource1._11; sayac += 1; }
                if (kart1 == 12) { pictureBox1.Image = global::BlackjackOyunu.Resource1._12; sayac += 1; }
                if (kart1 == 13) { pictureBox1.Image = global::BlackjackOyunu.Resource1._13; sayac += 1; }
                if (kart2 == 1) { pictureBox2.Image = global::BlackjackOyunu.Resource1._27; sayac += 1; sans += 1; }
                if (kart2 == 2) { pictureBox2.Image = global::BlackjackOyunu.Resource1._28; sayac += 1; }
                if (kart2 == 3) { pictureBox2.Image = global::BlackjackOyunu.Resource1._29; sayac += 1; }
                if (kart2 == 4) { pictureBox2.Image = global::BlackjackOyunu.Resource1._30; sayac += 1; }
                if (kart2 == 5) { pictureBox2.Image = global::BlackjackOyunu.Resource1._31; sayac += 1; }
                if (kart2 == 6) { pictureBox2.Image = global::BlackjackOyunu.Resource1._32; sayac += 1; }
                if (kart2 == 7) { pictureBox2.Image = global::BlackjackOyunu.Resource1._33; sayac += 1; }
                if (kart2 == 8) { pictureBox2.Image = global::BlackjackOyunu.Resource1._34; sayac += 1; }
                if (kart2 == 9) { pictureBox2.Image = global::BlackjackOyunu.Resource1._35; sayac += 1; }
                if (kart2 == 10) { pictureBox2.Image = global::BlackjackOyunu.Resource1._36; sayac += 1; }
                if (kart2 == 11) { pictureBox2.Image = global::BlackjackOyunu.Resource1._37; sayac += 1; }
                if (kart2 == 12) { pictureBox2.Image = global::BlackjackOyunu.Resource1._38; sayac += 1; }
                if (kart2 == 13) { pictureBox2.Image = global::BlackjackOyunu.Resource1._39; sayac += 1; }
                if (kart1 == 1) { gamer += 11; }
                if (kart1 >= 2 && kart1 <= 10) { gamer += kart1; }
                if (kart1 >= 11) { gamer += 10; }
                if (kart2 == 1) { gamer += 11; }
                if (kart2 >= 2 && kart2 <= 10) { gamer += kart2; }
                if (kart2 >= 11) { gamer += 10; }
                label6.Text = gamer.ToString();


                if (Npckart1 == 1) { pictureBox5.Image = global::BlackjackOyunu.Resource1._14; }
                if (Npckart1 == 2) { pictureBox5.Image = global::BlackjackOyunu.Resource1._15; }
                if (Npckart1 == 3) { pictureBox5.Image = global::BlackjackOyunu.Resource1._16; }
                if (Npckart1 == 4) { pictureBox5.Image = global::BlackjackOyunu.Resource1._17; }
                if (Npckart1 == 5) { pictureBox5.Image = global::BlackjackOyunu.Resource1._18; }
                if (Npckart1 == 6) { pictureBox5.Image = global::BlackjackOyunu.Resource1._19; }
                if (Npckart1 == 7) { pictureBox5.Image = global::BlackjackOyunu.Resource1._20; }
                if (Npckart1 == 8) { pictureBox5.Image = global::BlackjackOyunu.Resource1._21; }
                if (Npckart1 == 9) { pictureBox5.Image = global::BlackjackOyunu.Resource1._22; }
                if (Npckart1 == 10) { pictureBox5.Image = global::BlackjackOyunu.Resource1._23; }
                if (Npckart1 == 11) { pictureBox5.Image = global::BlackjackOyunu.Resource1._24; }
                if (Npckart1 == 12) { pictureBox5.Image = global::BlackjackOyunu.Resource1._25; }
                if (Npckart1 == 13) { pictureBox5.Image = global::BlackjackOyunu.Resource1._26; }
                if (Npckart2 == 1) { pictureBox7.Image = global::BlackjackOyunu.Resource1._40; }
                if (Npckart2 == 2) { pictureBox7.Image = global::BlackjackOyunu.Resource1._41; }
                if (Npckart2 == 3) { pictureBox7.Image = global::BlackjackOyunu.Resource1._42; }
                if (Npckart2 == 4) { pictureBox7.Image = global::BlackjackOyunu.Resource1._43; }
                if (Npckart2 == 5) { pictureBox7.Image = global::BlackjackOyunu.Resource1._44; }
                if (Npckart2 == 6) { pictureBox7.Image = global::BlackjackOyunu.Resource1._45; }
                if (Npckart2 == 7) { pictureBox7.Image = global::BlackjackOyunu.Resource1._46; }
                if (Npckart2 == 8) { pictureBox7.Image = global::BlackjackOyunu.Resource1._47; }
                if (Npckart2 == 9) { pictureBox7.Image = global::BlackjackOyunu.Resource1._48; }
                if (Npckart2 == 10) { pictureBox7.Image = global::BlackjackOyunu.Resource1._49; }
                if (Npckart2 == 11) { pictureBox7.Image = global::BlackjackOyunu.Resource1._50; }
                if (Npckart2 == 12) { pictureBox7.Image = global::BlackjackOyunu.Resource1._51; }
                if (Npckart2 == 13) { pictureBox7.Image = global::BlackjackOyunu.Resource1._52; }
                if (Npckart1 == 1) { npc += 11; }
                if (Npckart1 >= 2 && Npckart1 <= 10) { npc += Npckart1; }
                if (Npckart1 >= 11) { npc += 10; }
                if (Npckart2 == 1) { npc += 11; }
                if (Npckart2 >= 2 && Npckart2 <= 10) { npc += Npckart2; }
                if (Npckart2 >= 11) { npc += 10; }
                label5.Text = npc.ToString(); if (npc <= 16)
                {

                    if (Npckart1 == 1) { pictureBox8.Image = global::BlackjackOyunu.Resource1._14; }
                    if (Npckart1 == 2) { pictureBox8.Image = global::BlackjackOyunu.Resource1._15; }
                    if (Npckart1 == 3) { pictureBox8.Image = global::BlackjackOyunu.Resource1._16; }
                    if (Npckart1 == 4) { pictureBox8.Image = global::BlackjackOyunu.Resource1._17; }
                    if (Npckart1 == 5) { pictureBox8.Image = global::BlackjackOyunu.Resource1._18; }
                    if (Npckart1 == 6) { pictureBox8.Image = global::BlackjackOyunu.Resource1._19; }
                    if (Npckart1 == 7) { pictureBox8.Image = global::BlackjackOyunu.Resource1._20; }
                    if (Npckart1 == 8) { pictureBox8.Image = global::BlackjackOyunu.Resource1._21; }
                    if (Npckart1 == 9) { pictureBox8.Image = global::BlackjackOyunu.Resource1._22; }
                    if (Npckart1 == 10) { pictureBox8.Image = global::BlackjackOyunu.Resource1._23; }
                    if (Npckart1 == 11) { pictureBox8.Image = global::BlackjackOyunu.Resource1._24; }
                    if (Npckart1 == 12) { pictureBox8.Image = global::BlackjackOyunu.Resource1._25; }
                    if (Npckart1 == 13) { pictureBox8.Image = global::BlackjackOyunu.Resource1._26; }
                    if (Npckart1 == 1) { npc += 11; }
                    if (Npckart1 >= 2 && Npckart1 <= 10) { npc += Npckart1; }
                    if (Npckart1 >= 11) { npc += 10; }
                    label5.Text = npc.ToString();
                }








                }
            else { MessageBox.Show("Oyun Resetlemediniz yada Bahis koymadınız"); }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (butce >= 10&& sayac3==0)
            {
                bahis += 10;
                butce -= 10;
                label1.Text = butce.ToString();
                label2.Text = bahis.ToString();
            }
            else
                MessageBox.Show("Bütceniz yetersiz veya Oyun başladı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac5 = 0;
            sayac3 = 0;
            sayac2 = 0;
            gamer = 0;
            label6.Text = gamer.ToString();
            npc = 0;
            label5.Text = npc.ToString();
            sayac = 0;
            pictureBox1.Image = global::BlackjackOyunu.Resource1._ters;
            pictureBox2.Image = global::BlackjackOyunu.Resource1._ters;
            pictureBox3.Image = global::BlackjackOyunu.Resource1._ters;
            pictureBox4.Image = global::BlackjackOyunu.Resource1._ters;
            pictureBox5.Image = global::BlackjackOyunu.Resource1._ters;
            pictureBox6.Image = global::BlackjackOyunu.Resource1._ters;
            pictureBox7.Image = global::BlackjackOyunu.Resource1._ters;
            pictureBox8.Image = global::BlackjackOyunu.Resource1._ters;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int kart1 = rastgele.Next(1, 13);
            int kart2 = rastgele.Next(1, 13);
            int Npckart1 = rastgele.Next(1, 13);
            int Npckart2 = rastgele.Next(1, 13);
            if (gamer < 21 && sayac == 3)
            {
                if (kart2 == 1) { pictureBox4.Image = global::BlackjackOyunu.Resource1._27; sayac += 1; sans += 1; }
                if (kart2 == 2) { pictureBox4.Image = global::BlackjackOyunu.Resource1._28; sayac += 1; }
                if (kart2 == 3) { pictureBox4.Image = global::BlackjackOyunu.Resource1._29; sayac += 1; }
                if (kart2 == 4) { pictureBox4.Image = global::BlackjackOyunu.Resource1._30; sayac += 1; }
                if (kart2 == 5) { pictureBox4.Image = global::BlackjackOyunu.Resource1._31; sayac += 1; }
                if (kart2 == 6) { pictureBox4.Image = global::BlackjackOyunu.Resource1._32; sayac += 1; }
                if (kart2 == 7) { pictureBox4.Image = global::BlackjackOyunu.Resource1._33; sayac += 1; }
                if (kart2 == 8) { pictureBox4.Image = global::BlackjackOyunu.Resource1._34; sayac += 1; }
                if (kart2 == 9) { pictureBox4.Image = global::BlackjackOyunu.Resource1._35; sayac += 1; }               if (kart2 == 10) { pictureBox4.Image = global::BlackjackOyunu.Resource1._36; sayac += 1; }
                if (kart2 == 11) { pictureBox4.Image = global::BlackjackOyunu.Resource1._37; sayac += 1; }
                if (kart2 == 12) { pictureBox4.Image = global::BlackjackOyunu.Resource1._38; sayac += 1; }
                if (kart2 == 13) { pictureBox4.Image = global::BlackjackOyunu.Resource1._39; sayac += 1; }

                if (kart2 == 1) { gamer += 11; }
                if (kart2 >= 2 && kart2 <= 10) { gamer += kart2; }
                if (kart2 >= 11) { gamer += 10; }
                label6.Text = gamer.ToString();



            }

            if (gamer < 21&&sayac==2) {

                if (kart1 == 1) { pictureBox3.Image = global::BlackjackOyunu.Resource1._1; sayac += 1; sans += 1; }
                if (kart1 == 2) { pictureBox3.Image = global::BlackjackOyunu.Resource1._2; sayac += 1; }
                if (kart1 == 3) { pictureBox3.Image = global::BlackjackOyunu.Resource1._3; sayac += 1; }
                if (kart1 == 4) { pictureBox3.Image = global::BlackjackOyunu.Resource1._4; sayac += 1; }
                if (kart1 == 5) { pictureBox3.Image = global::BlackjackOyunu.Resource1._5; sayac += 1; }
                if (kart1 == 6) { pictureBox3.Image = global::BlackjackOyunu.Resource1._6; sayac += 1; }
                if (kart1 == 7) { pictureBox3.Image = global::BlackjackOyunu.Resource1._7; sayac += 1; }
                if (kart1 == 8) { pictureBox3.Image = global::BlackjackOyunu.Resource1._8; sayac += 1; }
                if (kart1 == 9) { pictureBox3.Image = global::BlackjackOyunu.Resource1._9; sayac += 1; }
                if (kart1 == 10) { pictureBox3.Image = global::BlackjackOyunu.Resource1._10; sayac += 1; }
                if (kart1 == 11) { pictureBox3.Image = global::BlackjackOyunu.Resource1._11; sayac += 1; }
                if (kart1 == 12) { pictureBox3.Image = global::BlackjackOyunu.Resource1._12; sayac += 1; }
                if (kart1 == 13) { pictureBox3.Image = global::BlackjackOyunu.Resource1._13; sayac += 1; }
                if (kart1 == 1) { gamer += 11; }
                if (kart1 >= 2 && kart1 <= 10) { gamer += kart1; }
                if (kart1 >= 11) { gamer += 10; }
                label6.Text = gamer.ToString();
            }
            else { MessageBox.Show("Daha Fazla kart istiyemesiniz"); }
            if (npc < 16)
            {
                if (Npckart2 == 1) { pictureBox6.Image = global::BlackjackOyunu.Resource1._40; }
                if (Npckart2 == 2) { pictureBox6.Image = global::BlackjackOyunu.Resource1._41; }
                if (Npckart2 == 3) { pictureBox6.Image = global::BlackjackOyunu.Resource1._42; }
                if (Npckart2 == 4) { pictureBox6.Image = global::BlackjackOyunu.Resource1._43; }
                if (Npckart2 == 5) { pictureBox6.Image = global::BlackjackOyunu.Resource1._44; }
                if (Npckart2 == 6) { pictureBox6.Image = global::BlackjackOyunu.Resource1._45; }
                if (Npckart2 == 7) { pictureBox6.Image = global::BlackjackOyunu.Resource1._46; }
                if (Npckart2 == 8) { pictureBox6.Image = global::BlackjackOyunu.Resource1._47; }
                if (Npckart2 == 9) { pictureBox6.Image = global::BlackjackOyunu.Resource1._48; }
                if (Npckart2 == 10) { pictureBox6.Image = global::BlackjackOyunu.Resource1._49; }
                if (Npckart2 == 11) { pictureBox6.Image = global::BlackjackOyunu.Resource1._50; }
                if (Npckart2 == 12) { pictureBox6.Image = global::BlackjackOyunu.Resource1._51; }
                if (Npckart2 == 13) { pictureBox6.Image = global::BlackjackOyunu.Resource1._52; }
          
                if (Npckart2 == 1) { npc += 11; }
                if (Npckart2 >= 2 && Npckart2 <= 10) { npc += Npckart2; }
                if (Npckart2 >= 11) { npc += 10; }
                label5.Text = npc.ToString(); 

            }
           




            }
    }
}
