using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emlak.Models
{
    public class Repository
    {
        private static List<Musteri> musteriBilgisi = new List<Musteri>();

        public static IEnumerable<Musteri> MusteriBilgisi => musteriBilgisi;

        public static void MusteriEkle(Musteri musteri)
        {
            musteriBilgisi.Add(musteri);
        }
    }
}
