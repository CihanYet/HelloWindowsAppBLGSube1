using System;

namespace OyunLib
{
    public enum Level
    {
        Kolay,
        Orta,
        Zor
    }
    public class GameInfo
    {
        public GameInfo()
        {

        }

        public GameInfo(string ad, string soyad, Level seviye)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Seviye = seviye;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Level Seviye { get; set; }
    }
}
