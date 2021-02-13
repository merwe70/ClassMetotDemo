using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> KitapEkle = new Dictionary<int,string>();

            KitapEkle.Add (254,"Yeraltından Notlar");
            KitapEkle.Add (255,"Çocukla İletişim");
            KitapEkle.Add (256,"Ana");

            foreach (var item in KitapEkle)
            {
                Console.WriteLine(item);
            }

            

            


        }
    }
}
