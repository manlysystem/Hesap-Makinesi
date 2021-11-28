using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int m = 0;

        public string veri = String.Empty;
        public double sayi1 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            daymode.Checked = true;
            groupBox3.Visible = false;
            listBox1.Visible = false;
        }

        private void log_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            listBox1.Visible = true;
            this.ClientSize = new System.Drawing.Size(599, 432);
        }

        private void daymode_CheckedChanged(object sender, EventArgs e)
        {
            // Gündüz Modu
            BackColor = Color.White;
            ForeColor = Color.Black;
            groupBox3.ForeColor = Color.Black;
            groupBox3.BackColor = Color.White;
            listBox1.BackColor = Color.White;
            number_0.BackColor = Color.White;
            number_1.BackColor = Color.White;
            number_2.BackColor = Color.White;
            number_3.BackColor = Color.White;
            number_4.BackColor = Color.White;
            number_5.BackColor = Color.White;
            number_6.BackColor = Color.White;
            number_7.BackColor = Color.White;
            number_8.BackColor = Color.White;
            number_9.BackColor = Color.White;
            virgul.BackColor = Color.White;
            log.BackColor = Color.White;
            clear.BackColor = Color.White;
            toplama.BackColor = Color.White;
            cikarma.BackColor = Color.White;
            carpma.BackColor = Color.White;
            bolme.BackColor = Color.White;
            hesapla.BackColor = Color.White;
            islem.BackColor = Color.White;
            islem.ForeColor = Color.Black;
            listBox1.ForeColor = Color.Green;
        }

        private void nightmode_CheckedChanged(object sender, EventArgs e)
        {
            // Gece Modu
            BackColor = Color.Black;
            ForeColor = Color.White;
            groupBox3.ForeColor = Color.White;
            groupBox3.BackColor = Color.Black;
            listBox1.BackColor = Color.Black;
            number_0.BackColor = Color.Black;
            number_1.BackColor = Color.Black;
            number_2.BackColor = Color.Black;
            number_3.BackColor = Color.Black;
            number_4.BackColor = Color.Black;
            number_5.BackColor = Color.Black;
            number_6.BackColor = Color.Black;
            number_7.BackColor = Color.Black;
            number_8.BackColor = Color.Black;
            number_9.BackColor = Color.Black;
            log.BackColor = Color.Black;
            clear.BackColor = Color.Black;
            toplama.BackColor = Color.Black;
            cikarma.BackColor = Color.Black;
            carpma.BackColor = Color.Black;
            bolme.BackColor = Color.Black;
            hesapla.BackColor = Color.Black;
            islem.BackColor = Color.Black;
            islem.ForeColor = Color.White;
            listBox1.ForeColor = Color.Green;
            virgul.BackColor = Color.Black;
            groupBox4.ForeColor = Color.White;
        }
        private void Ekle(object sender, EventArgs e)
        {
            try
            {
                islem.Text += (sender as Button).Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Islem(object sender, EventArgs e)
        {
            veri = (sender as Button).Text;
            sayi1 = Convert.ToDouble(islem.Text);
            islem.Text = " ";
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi2 = Convert.ToDouble(islem.Text);

                double sonuc = 0;

                if (veri == "+")
                {
                    sonuc = sayi1 + sayi2;
                }
                else if (veri == "-")
                {
                    sonuc = sayi1 - sayi2;
                }
                else if (veri == "×")
                {
                    sonuc = sayi1 * sayi2;
                }
                else if (veri == "÷")
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    MessageBox.Show("İşlem Seçmelisiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        
                islem.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (islem.Text == "" || islem.Text == null)
            {
                MessageBox.Show("Boş alan olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m++;
                listBox1.Items.Add("Toplam Yapılan İşlem Sayısı: " + m.ToString());
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            islem.ResetText();
        }
    }
}
