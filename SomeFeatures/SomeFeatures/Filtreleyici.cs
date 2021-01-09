using System;
using System.Collections.Generic;
using System.Text;

namespace SomeFeatures
{
    public static class Filtreleyici
    {
        //public delegate bool basvuranAday(int item);
        public static int[] Filtrele(int[] numbers, Func<int,bool> kosul)
        {
            List<int> sonuc = new List<int>();
            foreach (var item in numbers)
            {
                if (kosul(item))
                {
                    sonuc.Add(item);
                }
            }
            return sonuc.ToArray();
        }
    }
}
