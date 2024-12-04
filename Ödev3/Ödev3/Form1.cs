using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //klavyeden kısa kenarı girilen dikdörtgenin alan ve cevresini hesapla
            int kisakenar, uzunkenar,alan,cevre;
            kisakenar = Convert.ToInt16(textBox1.Text);
            uzunkenar = Convert.ToInt16(textBox2.Text);
            alan = uzunkenar * kisakenar;
            cevre = (uzunkenar + kisakenar) * 2;
            listBox1.Items.Add("Alan:"+alan +" Çevre: "+ cevre);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //klavyeden yarıçapı girilen cemberin alan ve cevresini hesapla
            double yaricap, cevre, alan;
            double pi=3.14;
            yaricap = Convert.ToDouble(textBox3.Text);
            cevre = 2 * pi * yaricap;
            alan = pi * yaricap * yaricap;
            textBox4.Text = cevre.ToString();
            textBox5.Text = alan.ToString();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //klavyeden 3 tane sınav notu ortalamasını hesapla
            int s1, s2, s3;
            double ortalama;
            s1 = Convert.ToInt16(textBox6.Text);
            s2 = Convert.ToInt16(textBox7.Text);
            s3 = Convert.ToInt16(textBox8.Text);
            ortalama = (s1 + s2 + s3) / 3;
            textBox9.Text = ortalama.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //klavyeden 3 tane sayı girilen sayıya aritmetik işlemleri kullan
            int sayi1, sayi2, sayi3;
            int toplam, carpim;
            sayi1 = Convert.ToInt16(textBox10.Text);
            sayi2 = Convert.ToInt16(textBox11.Text);
            sayi3 = Convert.ToInt16(textBox12.Text);
            toplam = sayi3 + sayi2 + sayi1;
            carpim = sayi1 * sayi2 * sayi3;
            listBox2.Items.Add("Sayıların toplamı: " + toplam + "\n" + " Sayıların çarpımı:" +carpim);

        }
    }
}



