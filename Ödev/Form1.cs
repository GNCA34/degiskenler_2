using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            double fiyat,kdv1,kdv2;
            ad = textBox1.Text;
            fiyat = Convert.ToDouble(textBox2.Text);
            kdv1 = fiyat+(fiyat * 0.8);
            kdv2 = fiyat+(fiyat * 1.8);
            listBox1.Items.Add(ad + ", "+fiyat + " yüzde 8 kdv'li fiyat:" + kdv1 + " yüzde 18 kdv'li fiyat:" + kdv2);

        }
    }
}
//ürünün adını fiyat yüzde 8 ve yüzde 18 vergili halini listboxa yazsın