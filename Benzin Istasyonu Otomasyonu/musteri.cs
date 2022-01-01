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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string yas = textBox3.Text;
                string tc = textBox1.Text;
                string adsoyad = textBox2.Text;
                string no = textBox4.Text;
                string email = textBox5.Text;
                string plaka = textBox6.Text;

                if (tc == "" || tc == null || yas == "" || yas == null || adsoyad == "" || adsoyad == null || no == "" || no == null || email == "" || email == null || plaka == "" || plaka == null)
                {
                    MessageBox.Show("Boş Alan Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tc.Length > 11)
                { 
                    MessageBox.Show("Tc Kimlik 11 Hanenin Üzerinde Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (no.Length > 11)
                {
                    MessageBox.Show("Telefon Numarası 11 Hanenin Üzerine Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] bilgiler = { tc, adsoyad, yas, no, email, plaka };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem bilgi in listView1.SelectedItems)
            {
                bilgi.Remove();
            }
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("TC", 150);
            listView1.Columns.Add("Ad Soyad", 150);
            listView1.Columns.Add("Yaş", 150);
            listView1.Columns.Add("Tel No", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Plaka", 150);
        }
    }
}
