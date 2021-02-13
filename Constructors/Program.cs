using System;

namespace Constructors //Bir class ı new lediğimizde çalışan blok constructors.Yani; ekranı new lediğimizde, bir kere çalışır, bir daha çalışmaz.Türkçesi yapıcı blok demek(constructors)
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametresi olmayan constructere, default constructer denir
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" }; //bunlar parametre değil

            Customer customer3 = new Customer();
            customer3.Id = 3;
            

            Customer customer2 = new Customer ( 2, "Derin", "Demiroğ", "Ankara" );

            Console.WriteLine(customer2.FirstName);
        }

        static void Method(int Id,string FirstName,string LastName, string City ) //constructer ler method mantığıyla çalışırlar
        {

        }
    }

    class Customer // yukarda verilerin tiplerini yazmak istemez isek burada belirtmemiz gerekiyor parantez içinde
        //sınıfı new lediğimizde çalışmasını istediğimiz kodlar varsa onları oraya koyuyoruz.----- Bu özellik barındıran class türü
    {

        //default constructer---- biz yazarsak o çalışır,yazmazsak default olan çalışır
        public Customer() //bu yapı da constructor.. Constructor lar metot gibi çalışır. (ctor tab tab yazarsak bu yapı oluşur )
        {
            Console.WriteLine("yapıcı blok çalıştı ");
        }
        //2 tane custumer kullanmamızın sebebi yukarıda belirttiğimiz 2 şekilde de kullanmak.Bu yapıya overloading diyoruz
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;  //Biz bunları belirtmez isek, yukarıda ekrana yazdırmaz.okuyamaz
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
