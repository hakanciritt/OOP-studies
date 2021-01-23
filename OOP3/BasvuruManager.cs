using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager ,  List<ILoggerService> loggerService)
        {
            //başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManager )
        {
            foreach (var kredi in krediManager)
            {
                kredi.Hesapla();
            }
        }     
    }
}
