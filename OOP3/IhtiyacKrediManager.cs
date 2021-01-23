using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("ihtiyac kredisi ");
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyac kredisi hesaplandı");
        }
    }
}
