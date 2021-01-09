using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SomeFeatures
{
    class Program
    {
        static int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            //.net 1.1
            var sonuc = Filtreleyici.Filtrele(sayilar, ciftSayilar);
           // goster(sonuc);
            //.net 2.0:
            var sonuc2 = Filtreleyici.Filtrele(sayilar, delegate (int x) { return x % 3 == 0; });
           // goster(sonuc2);
            //.net 3.5:
            var sonuc3 = Filtreleyici.Filtrele(sayilar, s => s % 5 == 0);
            goster(sonuc3);
            //samples();

        }

        private static void goster(int[] sonuc)
        {
            //foreach (var item in sonuc)
            //{
            //    Console.WriteLine(item);
            //}
            sonuc.ToList().ForEach(x => Console.WriteLine(x));
        }


        static bool ciftSayilar(int item)
        {
            return item % 2 == 0;
        }
        private static void samples()
        {
            Product product = new Product { Name = "Cips", Price = 5, Quantity = 1 };

            if (product != null)
            {
                string sample = product.Name;
            }
            string name = product?.Name;

            Console.WriteLine(product.ToString());
            Console.WriteLine(product.Quantity.ToString());

            object[] arr = { 225.2M, "çikolata", false, 20M };
            decimal toplam = 0;
            foreach (var item in arr)
            {
                if (item is decimal num)
                {
                    toplam += num;
                }
            }
            Console.WriteLine(toplam);
        }
    }

    public class Product
    {
        public string Name { get; set; } = "Örnek ad";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"{Name} isimli ürün, {Price} TL";
        }
    }
}
