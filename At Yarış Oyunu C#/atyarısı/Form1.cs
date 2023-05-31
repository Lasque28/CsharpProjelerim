using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarısı
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            this.Show();
            MessageBox.Show("At Yarışı oyununa hoşgeldiniz ilk girişi hediyesi olan 50puan hesabınıza eklendi eğlenmeye başalyabilirsiniz", "Hoşgeldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);


            InitializeComponent();
        }
        int sayi = 0,sayac=0;
        int birat=0,ikiat=0,ucat=0;
        int dgr1 = 4, dgr2 = 4, dgr3 = 4, puan = 50,tl=0;
        int birK,ikiK,ucK;
        int biratsına, ikiatsına, ucatsına;

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "30P")
            {
                if (MessageBox.Show("Puan bozdurmayı onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (puan >= 30)
                    {
                        tl += 5;
                        label13.Text = tl.ToString();
                        puan -= 30;
                        label11.Text = puan.ToString();
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
                    if (puan >= 60)
                    {
                        tl += 10;
                        label13.Text = tl.ToString();
                        puan -= 60;
                        label11.Text = puan.ToString();
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
                    if (puan >= 150)
                    {
                        tl += 25;
                        label13.Text = tl.ToString();
                        puan -= 150;
                        label11.Text = puan.ToString();
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
                    if (puan >= 300)
                    {
                        tl += 50;
                        label13.Text = tl.ToString();
                        puan -= 300;
                        label11.Text = puan.ToString();
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
                    if (puan >= 600)
                    {
                        tl += 100;
                        label13.Text = tl.ToString();
                        puan -= 600;
                        label11.Text = puan.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == "20P")
            {
                if (MessageBox.Show("Puan çevirmeyi onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(tl>=5)
                    { 
                    tl -= 5;
                    label13.Text = tl.ToString();
                    puan += 20;
                    label11.Text = puan.ToString();
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
                        label13.Text = tl.ToString();
                        puan += 45;
                        label11.Text = puan.ToString();
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
                        label13.Text = tl.ToString();
                        puan += 100;
                        label11.Text = puan.ToString();
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
                        label13.Text = tl.ToString();
                        puan += 200;
                        label11.Text = puan.ToString();
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
                        label13.Text = tl.ToString();
                        puan += 400;
                        label11.Text = puan.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "5TL")
            {

                if (MessageBox.Show("Satın almayı onaylıyormusunuz ?", "Onay verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tl += 5;
                    label13.Text = tl.ToString();
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
                    label13.Text = tl.ToString();
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
                    label13.Text = tl.ToString();
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
                    label13.Text = tl.ToString();
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
                    label13.Text = tl.ToString();
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            birat = pictureBox1.Left;
            ikiat = pictureBox2.Left;
            ucat = pictureBox3.Left;
             biratsına = birat;
            ikiatsına = ikiat;
            ucatsına = ucat;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = puan.ToString();
          
            
            sayi++;
            label6.Text = sayi.ToString();

            int biratgns=0,ikiatgns = 0, ucatgns = 0,btsuzk;
            btsuzk = label4.Left;
            biratgns = pictureBox1.Width;
            ikiatgns = pictureBox2.Width;
            ucatgns = pictureBox3.Width;
            
            pictureBox1.Left += rsgl.Next(5,16);
            pictureBox2.Left += rsgl.Next(5, 16);
            pictureBox3.Left += rsgl.Next(5, 16);
            birK = biratgns + pictureBox1.Left;
            ikiK =ikiatgns + pictureBox2.Left;
                ucK= ucatgns + pictureBox3.Left;
           
                if (birK > ikiK+5 && birK > ucK+5) { label5.Text = "Çakırali  adının hakkını veriyor"; }
                else if ( ikiK>birK + 5 && ikiK>ucK + 5) { label5.Text = "Şahbatur Gücünü Gösteriyor"; }
                else if (ucK>birK + 5 && ucK>ikiK + 5) { label5.Text = "Ağakızı  öne geçti"; }


            birat = pictureBox1.Left - birat;
            ikiat = pictureBox2.Left - ikiat;
            ucat = pictureBox2.Left - ucat;

            if ( birK>= btsuzk&&birK>ikiK&&birK>ucK)
            { timer1.Enabled = false; MessageBox.Show("Tebrikler Çakırali hızıyla kazandı", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information); dgr1--;
                sayac++;dgr2++;dgr3++;
                listBox1.Items.Add(sayac + " ." + "süre:" +sayi+" Kazanan: Çakırali");
                
                if(comboBox1.SelectedItem=="1.Çakırali")
                {
                    puan += dgr1 * 4;
                    label11.Text = puan.ToString();
                }
                else
                {
                    puan -= dgr1 * 4;
                    label11.Text = puan.ToString();
                    dgr1++;
                }


            }
           else if (ikiK>= btsuzk && ikiK> birK && ikiK > ucK) 
            { timer1.Enabled = false; MessageBox.Show("Tebrikler Şahbatur hızıyla kazandı", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information); dgr2--;
                sayac++;dgr1++;dgr3++;
                listBox1.Items.Add(sayac+" ."+"süre:" + sayi + " Kazanan: Şahbatur");

                if (comboBox1.SelectedItem == "2.Şahbatur")
                {
                    puan += dgr2 * 4;
                    label11.Text = puan.ToString();
                }
                else
                {
                    puan -= dgr2 * 4;
                    label11.Text = puan.ToString();
                    dgr2++;

                }

            }
            else if (ikiK>= btsuzk&&ucK>birK&&ucK>ikiK)
            { timer1.Enabled = false; MessageBox.Show("Tebrikler Ağakızı hızıyla kazandı", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information); dgr3--;
                sayac++;dgr2++;dgr1++;
                listBox1.Items.Add(sayac + " ." + "süre:" + sayi + " Kazanan: Ağakızı");
                if (comboBox1.SelectedItem == "3.Ağakızı")
                {
                    puan += dgr3 * 4;
                    label11.Text = (puan).ToString();

                }
                else
                {
                    puan -= dgr3 * 4;
                    label11.Text = (puan).ToString();
                    dgr3++;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "0";
            sayi = 0;
            
            pictureBox1.Location = new Point(0,12);
            pictureBox2.Location = new Point(0, 134);
            pictureBox3.Location = new Point(0, 263);
            
            timer1.Enabled = false;

        }

        Random rsgl = new Random();
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex ==-1)
            {
                MessageBox.Show("Tutuğunuz atı seçmediniz lütfen bir seçim yapın","Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(puan>=20)
            {
               if(pictureBox1.Left==biratsına&&pictureBox2.Left==ikiatsına&&pictureBox3.Left==ucatsına)
                { 
                timer1.Enabled = true;
                }
                else { MessageBox.Show("Tekrar başlamak için Tekrar oyna tuşuna basın.", "Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Puanınız düşük eğlenmeye devam etmek için puan satın al", "Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            
        }
    }
}
