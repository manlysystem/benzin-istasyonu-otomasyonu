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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem bilgi in listView1.SelectedItems)
            {
                bilgi.Remove();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string tc = textBox1.Text;
                string plaka = textBox2.Text;
                string tutar = textBox3.Text;
                string ad = textBox4.Text;

                if (tc == "" || tc == null || plaka == "" || plaka == null || tutar == "" || tutar == null || ad == "" || ad == null)
                {
                    MessageBox.Show("Boş Alan Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tc.Length > 11)
                {
                    MessageBox.Show("Tc Kimlik 11 Hanenin Üzerinde Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (plaka.Length > 11)
                {
                    MessageBox.Show("Plaka 11 Hanenin Üzerine Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] bilgiler = { tc, ad, plaka, tutar };
                    listView1.Items.Add(new ListViewItem(bilgiler));
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void satis_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Müşteri TC", 170);
            listView1.Columns.Add("Müşteri İsim", 170);
            listView1.Columns.Add("Plaka", 250);
            listView1.Columns.Add("Tutar", 150);
        }
    }
}
