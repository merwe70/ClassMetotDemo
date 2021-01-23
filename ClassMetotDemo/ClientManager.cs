using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClientManager
    {
        public void Add(Client client)
        {
            Console.WriteLine(client.Id+ "Eklendi");
        }

        public void Clear(Client client)
        {
            Console.WriteLine(client.Id+"Silindi");
        }

        public void Update(Client client)
        {
            Console.WriteLine(client.Id+"Güncellendi");
        }

    }
}
