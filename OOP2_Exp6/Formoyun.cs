using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Exp6
{
    public partial class Formoyun : Form
    {
        private string[] kelimeListesi =
            {
            "elma",
            "üniversite",
            "kedi",
            "vatan",
            "mücadele",
            "gelişim",
            "programlama",
            "başarı",
            "erik",
            "üzüm"
        };
        private string gizliKelime;
        private string tahminEdilenKelime;
        private List<char> yanlisTahminler = new List<char>();
        private int puan = 100;
        public Formoyun()
        {
            InitializeComponent();
        }

        private void Formoyun_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            Random rastgele = new Random();
            int indeks = rastgele.Next(kelimeListesi.Length);
            gizliKelime = kelimeListesi[indeks];

            tahminEdilenKelime = "";
            for (int i = 0; i < gizliKelime.Length; i++)
            {
                tahminEdilenKelime += "_ ";
            }

            lblTahminEdilenKelime.Text = tahminEdilenKelime;
            lblPuan.Text = "Puan: " + puan;
            lblKelimeUzunlugu.Text = "Kelime Uzunluğu: " + gizliKelime.Length;
            yanlisTahminler.Clear();
            pictureBoxAdamAsmaca.Image = Properties.Resources.hangman_0;
            this.BackColor = SystemColors.Control;
        }

        private void TahminEt(char harf)
        {
            bool dogruTahmin = false;
            for (int i = 0; i < gizliKelime.Length; i++)
            {
                if (gizliKelime[i] == harf)
                {
                    tahminEdilenKelime = tahminEdilenKelime.Remove(i * 2, 1).Insert(i * 2, harf.ToString());
                    dogruTahmin = true;
                }
            }

            if (!dogruTahmin)
            {
                yanlisTahminler.Add(harf);
                puan -= 10;
                lblPuan.Text = "Puan: " + puan;
                pictureBoxAdamAsmaca.Image = (Image)Properties.Resources.ResourceManager.GetObject("hangman_" + (yanlisTahminler.Count - 1));
            }

            lblTahminEdilenKelime.Text = tahminEdilenKelime;

            if (tahminEdilenKelime.Replace(" ", "") == gizliKelime)
            {
                MessageBox.Show("Tebrikler! Kelimeyi doğru tahmin ettiniz.", "Kazandınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.LightGreen;
            }
            else if (yanlisTahminler.Count == 6)
            {
                MessageBox.Show("Üzgünüm, kaybettiniz. Doğru kelime: " + gizliKelime, "Kaybettiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BackColor = Color.LightCoral;
            }
        }

        private void buttontahminet_Click(object sender, EventArgs e)
        {
            if (txtTahmin.TextLength == 1 && char.IsLetter(txtTahmin.Text[0]))
            {
                char tahminHarfi = char.ToLower(txtTahmin.Text[0]);
                if (!yanlisTahminler.Contains(tahminHarfi) && !tahminEdilenKelime.Contains(tahminHarfi.ToString()))
                {
                    TahminEt(tahminHarfi);
                }
                else
                {
                    MessageBox.Show("Bu harfi zaten tahmin ettiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir harf giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtTahmin.Clear();
        }

        private void buttonoyunubitir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyundan çıkmak istediğinizden emin misiniz?", "Oyundan Çık", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Oyundan çıkılıyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Formu kapatır, bu durumda oyun ekranı kapanır.
            }
        }
        private void adamıas()
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);
            if (puan == -1)
            {
                g.Clear(this.BackColor);
                hata = 0;
            }
            if (hata == 1) g.DrawLine(p, 500, 400, 650, 400);
            else if (hata == 2) g.DrawLine(p, 525, 400, 525, 200);
            else if (hata == 3) g.DrawLine(p, 525, 200, 575, 200);
            else if (hata == 4) g.DrawLine(p, 575, 200, 575, 220);
            else if (hata == 5) g.DrawEllipse(p, 560, 220, 30, 30);
            else if (hata == 6) g.DrawLine(p, 575, 250, 575, 330);
            else if (hata == 7) g.DrawLine(p, 575, 250, 545, 280);
            else if (hata == 8) g.DrawLine(p, 575, 250, 605, 280);
            else if (hata == 9) g.DrawLine(p, 575, 325, 545, 355);
            else if (hata == 10) g.DrawLine(p, 575, 325, 605, 355);
        }
    }
}
