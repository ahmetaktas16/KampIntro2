using System;

namespace OOP3
{
    class Program
    {
        public static object List { }

        static void Main(string[] args)

        {
          //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); şeklinde de imzalar atılabilir.
          //Interfaceler de o interface'i implemente eden class' ın referans değerini tutabilir. 
          //Aşağıdaki kodlama şubedeki çalışanın ekranı olsun. Burada 3 tane kredi var. Aşağıdaki 3 kod ekrandaki açılır kutu.   

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            //Şimdi başvuru yapıyorum.

            BasvuruManager basvuruManager = new BasvuruManager();
            //başvuru yap konut kredisine göre ve database'e logla.
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

            List <IKrediManager> krediler 

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }

    internal class FileLoggerService : ILoggerService
    {
    }
}
