using System;
using System.Collections.Generic; //listeler koleksiyonlardır. Arka planda array yönetiyor.

namespace Generics
{
    //Generic ler array bazlı, yani; arkada bir array çalışıyor
    class Program
    {

        // Generics ler hangi tipi verirsek içindeki operasyonlar parametre olarak o tipte çalışıyor
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>(); // Bu öyle bir yapı ki ne verirsek tipi o oluyor
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); //Count praperty dir metot olsa count() böyle yazılırdı.
            //sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T>  //Bu generic bir class. Burdaki T bizim gönderdiğimiz tip hangi tipi verirsek ona dönüşüyor . T type dan geliyor
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];  //arraylerde eleman sayısını bir artırınca new lemek gerekiyor
        }

        public void Add (T item)
        {
            _tempArray = _array;   //tempArray array in referansını tutuyor
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length ; i++) //
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;       //arrayın son elemanı eşittir bizim gönderdiğimiz item
        }

        public int Count //mylist  in count unu çağırırsak burdaki array in eleman sayısını verir
        {
            get { return _array.Length; }
            
        }
          
    }
}
