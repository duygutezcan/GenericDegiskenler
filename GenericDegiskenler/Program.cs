using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 100, 200, 300, 250, 75 };
            foreach (var item in sayilar)
            {
                Console.WriteLine("sayı : " + item);
            }
            ArrayList sayilar2 = new ArrayList();
            Console.WriteLine("Yeni sayı");
            int sayi=Convert.ToInt32(Console.ReadLine());
            sayilar2.Add(sayi);


            sayilar2.Add(100);
            sayilar2.Add(500);
            sayilar2.Remove(100);
            //sayilar2.RemoveAt(1);
            sayilar2.Add("elma");
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }


            List<object> sayilar3 = new List<object>();
            sayilar3.Add(100);
            sayilar3.Add(200);
            sayilar3.Remove(200);
            sayilar3.Add(1000);
            sayilar3.Add("elma");
            foreach (var item in sayilar3)
            {
                Console.WriteLine(item);
            }



            List<Personel> plist = new List<Personel>();

            Personel p1 = new Personel();
            p1.Ad = "Duygu";
            p1.SoyAd = "Tezcan Kantar";
            p1.Id = 1;
            plist.Add(p1);


            Personel p2 = new Personel();
            p2.Ad = "Serkan";
            p2.SoyAd = "Kantar";
            p2.Id = 2;
            plist.Add(p2);
            foreach(var item in plist)
            {
                Console.WriteLine(item.Ad + " " + item.SoyAd);
            }

            Console.ReadLine();

        }
    }
}
