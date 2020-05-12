/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				
**				ÖDEV NUMARASI..........:PROJE
**				ÖĞRENCİ ADI............:MAFTUN HASHIMLI
**				ÖĞRENCİ NUMARASI.......:G181210554
**                         DERSİN ALINDIĞI GRUP...:2C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPProje
{
    public partial class Form1 : Form
    {
        // atık kutularını oluşturuyoruz
        AtikKutusu organikAtikKutusu = new AtikKutusu(700, 0);
        AtikKutusu kagitKutusu = new AtikKutusu(1200, 1000);
        AtikKutusu camKutusu = new AtikKutusu(2200, 600);
        AtikKutusu metalKutusu = new AtikKutusu(2300, 800);

        // atıkları oluşturuyoruz
        Atik gazete = new Atik(250, Image.FromFile("gazete.jpg"));
        Atik dergi = new Atik(200, Image.FromFile("dergi.png"));
        Atik domates = new Atik(150, Image.FromFile("domates.png"));
        Atik salatalik = new Atik(120, Image.FromFile("salatalik.jpg"));
        Atik camSise = new Atik(600, Image.FromFile("camSise.jpg"));
        Atik bardak = new Atik(250, Image.FromFile("bardak.jpg"));
        Atik kolaKutusu = new Atik(350, Image.FromFile("kolaKutusu.jpg"));
        Atik salcaKutusu = new Atik(550, Image.FromFile("salcaKutusu.jpg"));

        // resmi rastgele şekilde değiştiren fonksiyon
        void ResmiDegistir()
        {
            // 1 ile 9 arasında rastgele değer alan değişken
            Random rastgele = new Random();
            int resimNo = rastgele.Next(1,9);

            // gelen sayıya göre resmi değiştiren sorgu
            if (resimNo == 1) PICBOX.Image = gazete.Image;
            else if (resimNo == 2) PICBOX.Image = dergi.Image;
            else if (resimNo == 3) PICBOX.Image = domates.Image;
            else if (resimNo == 4) PICBOX.Image = salatalik.Image;
            else if (resimNo == 5) PICBOX.Image = camSise.Image;
            else if (resimNo == 6) PICBOX.Image = bardak.Image;
            else if (resimNo == 7) PICBOX.Image = kolaKutusu.Image;
            else if (resimNo == 8) PICBOX.Image = salcaKutusu.Image;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void AtikToplama_Load(object sender, EventArgs e)
        {
            
        }

        // degerleri sifirlayan fonksiyon
        private void DegerleriSifirla() {
            LBOX_Organik.Items.Clear();
            LBOX_Cam.Items.Clear();
            LBOX_Kagit.Items.Clear();
            LBOX_Metal.Items.Clear();
            LBL_Sure.Text = "60";
            LBL_Puan.Text = "0";
            PBAR_Organik.Value = 0;
            PBAR_Metal.Value = 0;
            PBAR_Kagit.Value = 0;
            PBAR_Cam.Value = 0;
        }

        // oyun başlayınca veya bitince butonları ve timer'ı enable veya disable eden fonksiyon
        private void OyunuBaslatVeyaDurdur(bool baslayacakMi)
        {
            BTN_CamAt.Enabled = baslayacakMi;
            BTN_MetalAt.Enabled = baslayacakMi;
            BTN_KagitAt.Enabled = baslayacakMi;
            BTN_OrganikAtikAt.Enabled = baslayacakMi;
            BTN_CamBosalt.Enabled = baslayacakMi;
            BTN_KagitKutusuBosalt.Enabled = baslayacakMi;
            BTN_MetalBosalt.Enabled = baslayacakMi;
            BTN_OrganikAtikBosalt.Enabled = baslayacakMi;
            Timer.Enabled = baslayacakMi;
        }

        // yeni oyuna basınca değerleri sıfırlayıp resmi değiştirip oyunu başlatan fonksiyon
        private void BTN_YeniOyun_Click(object sender, EventArgs e)
        {
            DegerleriSifirla();   
            ResmiDegistir();
            OyunuBaslatVeyaDurdur(true);
        }

        // çıkış butonuna basınca kapatan fonksiyon
        private void BTN_Cikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        // kağıt kutusuna kağıt atık atan fonksiyon
        private void BTN_KagitAt_Click(object sender, EventArgs e)
        {
            // resim ile gazetenin resmi aynıysa gazeteyi kutuya atan sorgu
            if (PICBOX.Image == gazete.Image)
            {
                if (kagitKutusu.Ekle(gazete))
                {
                    PBAR_Kagit.Value = kagitKutusu.DolulukOrani;
                    LBOX_Kagit.Items.Add("Gazete (" + gazete.Hacim + ")");
                    ResmiDegistir();
                }
            }
            // resim ile derginin resmi aynıysa dergiyi kutuya atan sorgu
            else if (PICBOX.Image == dergi.Image)
            {
                if (kagitKutusu.Ekle(dergi))
                {
                    PBAR_Kagit.Value = kagitKutusu.DolulukOrani;
                    LBOX_Kagit.Items.Add("Dergi (" + dergi.Hacim + ")");
                    ResmiDegistir();
                }
            }
        }

        // organik atık kutusuna organik atık atan fonksiyon
        private void BTN_OrganikAtikAt_Click(object sender, EventArgs e)
        {
            // resim ile domatesin resmi aynıysa domatesi kutuya atan sorgu
            if (PICBOX.Image == domates.Image)
            {
                if (organikAtikKutusu.Ekle(domates))
                {
                    PBAR_Organik.Value = organikAtikKutusu.DolulukOrani;
                    LBOX_Organik.Items.Add("Domates (" + domates.Hacim + ")");
                    ResmiDegistir();
                }
            }
            // resim ile salatalığın resmi aynıysa salatalığı kutuya atan sorgu
            else if (PICBOX.Image == salatalik.Image)
            {
                if (organikAtikKutusu.Ekle(salatalik))
                {
                    PBAR_Organik.Value = organikAtikKutusu.DolulukOrani;
                    LBOX_Organik.Items.Add("Salatalık (" + salatalik.Hacim + ")");
                    ResmiDegistir();
                }
            }
        }

        // metal atık kutusuna metal atık atan fonksiyon
        private void BTN_MetalAt_Click(object sender, EventArgs e)
        {
            // resim ile kola kutusunun resmi aynıysa kola kutusunu kutuya atan sorgu
            if (PICBOX.Image == kolaKutusu.Image)
            {
                if (metalKutusu.Ekle(kolaKutusu))
                {
                    PBAR_Metal.Value = metalKutusu.DolulukOrani;
                    LBOX_Metal.Items.Add("Kola Kutusu (" + kolaKutusu.Hacim + ")");
                    ResmiDegistir();
                }
            }
            // resim ile salça kutusunun resmi aynıysa salça kutusunu kutuya atan sorgu
            else if (PICBOX.Image == salcaKutusu.Image)
            {
                if (metalKutusu.Ekle(salcaKutusu))
                {
                    PBAR_Metal.Value = metalKutusu.DolulukOrani;
                    LBOX_Metal.Items.Add("Salça Kutusu (" + salcaKutusu.Hacim + ")");
                    ResmiDegistir();
                }
            }
        }

        // cam atık kutusuna cam atık atan fonksiyon
        private void BTN_CamAt_Click(object sender, EventArgs e)
        {
            // resim ile bardağın resmi aynıysa bardağı kutuya atan sorgu
            if (PICBOX.Image == bardak.Image)
            {
                if (camKutusu.Ekle(bardak))
                {
                    PBAR_Cam.Value = camKutusu.DolulukOrani;
                    LBOX_Cam.Items.Add("Bardak (" + bardak.Hacim + ")");
                    ResmiDegistir();
                }
            }
            // resim ile cam şişenin resmi aynıysa cam şişeyi kutuya atan sorgu
            else if (PICBOX.Image == camSise.Image)
            {
                if (camKutusu.Ekle(camSise))
                {
                    PBAR_Cam.Value = camKutusu.DolulukOrani;
                    LBOX_Cam.Items.Add("Cam Şişe (" + camSise.Hacim + ")");
                    ResmiDegistir();
                }
            }
        }

        // boşalta basınca metal kutusunu boşaltan fonksiyon
        private void BTN_MetalBosalt_Click(object sender, EventArgs e)
        {
            // %75'ten fazla doluysa boşaltıp süreyi ve puanı arttıran sorgu
            if (metalKutusu.Bosalt())
            {
                PBAR_Metal.Value = metalKutusu.DolulukOrani;
                LBL_Puan.Text = (Convert.ToInt32(LBL_Puan.Text) + metalKutusu.BosaltmaPuani).ToString();
                LBL_Sure.Text = (Convert.ToInt32(LBL_Sure.Text) + 3).ToString();
                LBOX_Metal.Items.Clear();
            }
        }

        // boşalta basınca kağıt kutusunu boşaltan fonksiyon
        private void BTN_KagitKutusuBosalt_Click(object sender, EventArgs e)
        {
            // %75'ten fazla doluysa boşaltıp süreyi ve puanı arttıran sorgu
            if (kagitKutusu.Bosalt())
            {
                PBAR_Kagit.Value = kagitKutusu.DolulukOrani;
                LBL_Puan.Text = (Convert.ToInt32(LBL_Puan.Text) + kagitKutusu.BosaltmaPuani).ToString();
                LBL_Sure.Text = (Convert.ToInt32(LBL_Sure.Text) + 3).ToString();
                LBOX_Kagit.Items.Clear();
            }
        }

        // boşalta basınca organik atık kutusunu boşaltan fonksiyon
        private void BTN_OrganikAtikBosalt_Click(object sender, EventArgs e)
        {
            // %75'ten fazla doluysa boşaltıp süreyi ve puanı arttıran sorgu
            if (organikAtikKutusu.Bosalt())
            {
                PBAR_Organik.Value = organikAtikKutusu.DolulukOrani;
                LBL_Puan.Text = (Convert.ToInt32(LBL_Puan.Text) + organikAtikKutusu.BosaltmaPuani).ToString();
                LBL_Sure.Text = (Convert.ToInt32(LBL_Sure.Text) + 3).ToString();
                LBOX_Organik.Items.Clear();
            }
        }

        // boşalta basınca cam kutusunu boşaltan fonksiyon
        private void BTN_CamBosalt_Click(object sender, EventArgs e)
        {
            // %75'ten fazla doluysa boşaltıp süreyi ve puanı arttıran sorgu
            if (camKutusu.Bosalt())
            {
                PBAR_Cam.Value = camKutusu.DolulukOrani;
                LBL_Puan.Text = (Convert.ToInt32(LBL_Puan.Text) + camKutusu.BosaltmaPuani).ToString();
                LBL_Sure.Text = (Convert.ToInt32(LBL_Sure.Text) + 3).ToString();
                LBOX_Cam.Items.Clear();
            }
        }

        // Saniyede 1 dönen timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            // süre bitmediyse süreyi 1 azaltan, bittiyse oyunu durduran sorgu
            if (Convert.ToInt32(LBL_Sure.Text) > 0)
            {
                LBL_Sure.Text = (Convert.ToInt32(LBL_Sure.Text) - 1).ToString();
            }
            else
            {
                OyunuBaslatVeyaDurdur(false);
            }
        }
    }
}
