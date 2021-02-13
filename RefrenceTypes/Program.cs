using System;

namespace RefrenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int,decimal,float,enum,boolen= value types
            //değer tiplerde atama yaptıktan sonra yaptığımız değer başka bir değerse orayla hiçbir bağlantısı yok, onun sadece o anki değeriyle ilgileniyoruz

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2; //sayi1 20 oldu.-------Burda sadece değer atadık başka hiçbir bağlantımız yok
            sayi2 = 100;

            Console.WriteLine("sayi 1 :"+ sayi1); //20 kalır 



            //array,class,interface= Reference types
            int[] sayilar1 = new int[] {1,2,3 };
            int[] sayilar2 = new int[] {10,20,30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayılar1 in 0 ı :"+sayilar1[0]); //1000

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;      //biz burada değer eşitlemesi değil adres eşitlemesi yapıyoruz
            person1.FirstName = "Derin";


            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCartNumber = "123456";

            Emploee emploee = new Emploee();
            emploee.FirstName = "Veli";

            Person person3 = customer;   // person; Customer ın da emploee nin de adresini tutabiliyor
            customer.FirstName = "Ahmet";

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCartNumber);

            //Customer customer1 = emploee;---------atayamıyoruz. Sebebi;Custoer bir person dır.Yani müşteri bir kişidir. Miras aldığımız sınıfa, mirası aldığımız kişiyi(class'ı) atayabiliriz  


            PersonManager personManager = new PersonManager();
            personManager.Add(customer); //Hepsini gönderebiliyoruz.Ben yazılımda aynı kodu farklı nesneler için kullanmama olanağı sağlıyor
        }
       
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class:Person(Temel sınıf demek).Person a customer i atayabildim, sebebi; Customer bir Person dur.Miras aldığımız sınıfa, mirası alan kişiyi(classı) atayabiliriz.Buna BASE CLASS DENİR 
    class Customer : Person //Person a Customer i atıyoruz.------Base class a onu inherit eden sınıfların referanslarını(adreslerini) atayabiliriz
    {
        public string CreditCartNumber { get; set; }
    }

    class Emploee : Person
    {
        public int EmploeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)//Biz buraya, sadece customer desek customer olarak çalışırız. Sadece Emploee desek, emploee olarak çalışırız.Person customer ve emploee nin base i
        {
            Console.WriteLine(person.LastName);
        }
    }
}
