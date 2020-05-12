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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    class AtikKutusu : IAtikKutusu
    {
        // Kutunun hacmini, getireceği puanı, doluluk oranını ve kapasitesini tutan değişkenler
        private int _bosaltmaPuani;
        private int _doluHacim;
        private int _dolulukOrani;
        private int _kapasite;

        // Başka sınıflardan Boşaltma puanı değeri almak için gerekli özellik
        public int BosaltmaPuani{
            get{return _bosaltmaPuani;}
        }

        // Başka sınıflardan Kapasite değeri almak için gerekli özellik
        public int Kapasite{
            get { return _kapasite; }
            set { _kapasite = value; }
        }

        // Başka sınıflardan dolu hacim değeri almak için gerekli özellik
        public int DoluHacim{
            get{return _doluHacim;}
        }

        // Başka sınıflardan doluluk oranı değeri almak için gerekli özellik
        public int DolulukOrani{
            get{ return _dolulukOrani; }
        }

        // Doluluk oranı hesaplayan fonksiyon
        public void OranHesapla()
        {
            _dolulukOrani = _doluHacim * 100 / _kapasite;
        }

        // Kutuyu bosaltan fonksiyon
        public bool Bosalt()
        {
            // doluluk oranı 75 veya daha fazlaysa hacmi ve oranı sıfır yapan sorgu
            if ( _dolulukOrani > 74)
            {
                _doluHacim = 0;
                OranHesapla();
                return true;
            }
            else 
                return false;
        }

        // kutuya atık ekleyen fonksiyon
        public bool Ekle(IAtik atik)
        {
            // atığı ekleyince kutuya sığıyorsa atığı ekleyip hacmi ve oranı hesaplayan sorgu
            if (_doluHacim + atik.Hacim <= _kapasite)
            {
                _doluHacim += atik.Hacim;
                OranHesapla();
                return true;
            }
            else 
                return false;
        }

        // bastan baslayınca değerleri sıfır yapan fonksiyon
        public void BastanBasla()
        {
            _doluHacim = 0;
            OranHesapla();
        }

        // nesne oluştururken kapasitesini ve bosaltma puanını atayarak oluşturan fonksiyon
        public AtikKutusu(int kapasite, int bosaltmaPuani)
        {
            _kapasite = kapasite;
            _bosaltmaPuani = bosaltmaPuani;
            BastanBasla();
        }
    }
}
