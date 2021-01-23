using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            basvuruManager.BasvuruYap(new EsnafKredisiManager()
                , new List<ILoggerService> {new SmsLoggerService(),new DatabaseLoggerService() });

           

            //interfaceleri birbirini alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız

            
            




        }
    }
}
