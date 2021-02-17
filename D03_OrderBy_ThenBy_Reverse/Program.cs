using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OrderBy_ThenBy_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenciler = OgrenciListesi();

            var sonuc1 = from s in ogrenciler
                         orderby s.Yas, s.Ad descending
                         select s;

            var sonuc2 = ogrenciler.OrderBy(x => x.Ad.Length & x.Yas);
            var sonuc3 = ogrenciler.OrderByDescending(x => x.Ad.Length);
            var sonuc4 = ogrenciler.OrderBy(x => x.Ad).ThenBy(s => s.Yas);
            var sonuc5 = ogrenciler.OrderByDescending(x => x.Ad).ThenByDescending(s => s.Yas);
            var sonuc6 = (from s in ogrenciler
                          orderby s.Yas
                          select s).Reverse();



            var sonuc7 = ogrenciler.OrderBy(x => x.Yas).Reverse();
            foreach (var product in sonuc7)
            {
                Console.WriteLine("Adı: " + product.Ad + " - Soyadı: " + product.Soyad + " - Yaşı: " + product.Yas);
            }

            Console.ReadLine();
        }

        private static IList<Ogrenci> OgrenciListesi()
        {
            IList<Ogrenci> ogrenciler = new List<Ogrenci>
            {
                new Ogrenci { Id = 1, Ad = "Kazım Miraç", Soyad = "DAĞTEKİN", Yas = 3 },
                new Ogrenci { Id = 2, Ad = "Ömer Faruk", Soyad = "METİN", Yas = 19 },
                new Ogrenci { Id = 2, Ad = "MERVE", Soyad = "DAĞTEKİN", Yas = 27 },
                new Ogrenci { Id = 2, Ad = "Bilal Osman", Soyad = "METİN", Yas = 22 }
            };
            return ogrenciler;
        }

        public class Ogrenci
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
        }
    }
}
