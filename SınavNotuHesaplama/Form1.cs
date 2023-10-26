using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavNotuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string isim, soyisim;
            int vize, final,ogrencino;
            double ortalama;
            isim = textBox1.Text;
            soyisim = textBox2.Text;   
            vize = Convert.ToInt16(textBox3.Text);
            final = Convert.ToInt16(textBox4.Text);
            ortalama = vize * 0.4 + final * 0.6;
            listBox1.Items.Add(isim + " " + soyisim + " " +maskedTextBox1.Text + " Ortalama : " + ortalama );
        }
    }
}
