﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("konut kredisi manager ");
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi hesaplandı");
        }
    }
}
