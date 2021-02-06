using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Bir krediye başvuru alacağız onun için class oluşturduk. 
    class BasvuruManager
    {   
        
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService )
        {
            
            //Başvuran bilgilerini değerlendirme
            //aşağıda başvuruyu kredi bağımsız hale getirdim.
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler )
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }

                
        }
    }
}
