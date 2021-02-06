using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //Okunurluğu arttırmak için Interfaceleri I harfi ile başlatırız.
        //Hesapla ve BiseyYap her banka kredisinde olması gereken metotlar.
        //Interfaceler birbirinin alternatifi olan ama kod içerikleri farklı olan operasyonları tutmak için kullanılır.
        //Alternatif sistemler için mesela sms olarak mail olarak yada dosya olarak veri tabanına aynı şeyleri yazmak. Loglama.
        void Hesapla();
        void BiseyYap();
       
    }
}
