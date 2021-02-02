using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Where_OfType
{
    class Program
    {
        static void Main(string[] args)
        {

            /************************************Where**********************************************************/

            //ÖRNEK DATA
            List<Kurs> kurslar1 = new List<Kurs>();
            kurslar1.Add(new Kurs { ID = 1, Konu = "LINQ Konuları5", Sira = 5 });
            kurslar1.Add(new Kurs { ID = 2, Konu = "LINQ Konuları4", Sira = 4 });
            kurslar1.Add(new Kurs { ID = 3, Konu = "LINQ Konuları2", Sira = 3 });

            //QUERY YÖNTEMİ
            var sonuc = from k in kurslar1
                        where k.Sira > 3
                        select k;

            foreach (var kurs in sonuc)
            {
                Console.WriteLine(kurs.Konu);
            }
            Console.ReadKey();

        }

        class Kurs
        {
            public int ID { get; set; }
            public string Konu { get; set; }
            public int Sira { get; set; }
        }
       
    }
}
