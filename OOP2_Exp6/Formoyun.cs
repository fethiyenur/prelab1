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

        private List<Image> imageHangman;

        public Formoyun(List<string> wordListToFind, List<string> hintsList)
        {
            InitializeComponent();

            // Asma adam resimlerini yükle
            imageHangman = new List<Image>()
    {
        Properties.Resources.man_01,
        Properties.Resources.man_02,
        Properties.Resources.man_03,
        Properties.Resources.man_04,
        Properties.Resources.man_05,
        Properties.Resources.man_06,
        Properties.Resources.man_07,
        Properties.Resources.man_08,
        Properties.Resources.man_09,
        Properties.Resources.man_10__1_,
    };

           
        }


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
            lblyanlıstahminler.Text = "Yanlıs Tahminler :";
            yanlisTahminler.Clear();
            pictureBoxAdamAsmaca.Image = Properties.Resources.man_01;
            pictureBoxAdamAsmaca.SizeMode = PictureBoxSizeMode.StretchImage;
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
                lblyanlıstahminler.Text += harf.ToString() + ",";
                lblPuan.Text = "Puan: " + puan;
                adamıas();
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
            Image[] imageHangman =
       {
        
        Properties.Resources.man_02,
        Properties.Resources.man_03,
        Properties.Resources.man_04,
        Properties.Resources.man_05,
        Properties.Resources.man_06,
        Properties.Resources.man_07,
        Properties.Resources.man_08,
        Properties.Resources.man_09,
        Properties.Resources.man_10__1_,

    };

            int resimIndex = (10 - puan / 10) - 1; // Resim dizisindeki index'i belirle
            if (resimIndex < 0)
                resimIndex = 0;
            if (resimIndex >= imageHangman.Length)
                resimIndex = imageHangman.Length - 1;

            pictureBoxAdamAsmaca.Image = imageHangman[resimIndex];
            pictureBoxAdamAsmaca.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblPuan_Click(object sender, EventArgs e)
        {

        }

        private void lblTahminEdilenKelime_Click(object sender, EventArgs e)
        {

        }

        public Button ıpucubutton
        {
            get { return button1; }
        }
        private void OyunAyarları_IpucuGorunurlukDegisti(object sender, bool gorunurluk)
        {
            //ıpucuButton.Visible = gorunurluk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Evet seçildiğinde
           
            // Rastgele bir doğru harf seç
            Random random = new Random();
            int index = random.Next(gizliKelime.Length);
            char ipucuHarf = gizliKelime[index];

            // Seçilen harfi kullanıcıya göster
            MessageBox.Show("İpucu: Gizli kelimenin içinde '" + ipucuHarf + "' harfi var.", "İpucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

