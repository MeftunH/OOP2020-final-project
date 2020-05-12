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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    class Atik : IAtik
    {
        // Hacimi tutması için gerekli değişken
        private int _hacim;
        // Resmi tutması için gerekli değişken
        private Image _image;

        // Başka sınıflardan Hacim değeri almak için gerekli özellik
        public int Hacim{
            get{ return _hacim; }
        }

        // Başka sınıflardan resmi almak için gerekli özellik
        public System.Drawing.Image Image{
            get { return _image; }
        }

        // Nesne oluştururken hacmini ve resmini atayarak oluşturan kurucu fonksiyon
        public Atik(int hacim, Image image){
            _hacim = hacim;
            _image = image;
        }
    }
}
