using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzin_Istasyonu_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int m = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
           progressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciadi = textBox1.Text;
                string sifre = textBox2.Text;
                if (kullaniciadi == "" || kullaniciadi == null || sifre == "" || sifre == null)
                {
                    MessageBox.Show("Boş Alan Olamaz!");
                }
                else if (kullaniciadi == "admin" && sifre == "1234")
                {
                    MessageBox.Show("Oturum Açıldı");
                    progressBar1.Visible = true;
                    timer1.Enabled = true;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifreniz Yalnış");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Interval = 25;
                progressBar1.Value = m++;
                if (progressBar1.Value == 25)
                {
                    timer1.Stop();
                    this.Hide();
                    menu menu = new menu();
                    menu.Show();
                }
            }
        }
    }
}
