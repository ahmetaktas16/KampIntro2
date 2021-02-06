using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // :Musteri yazma olayımıza miras yani inheritance denir. Tüzel müşteri bir müşteridir demek bu. Bu Musteri de olan
    // özellikler TuzelMusteri de de var demektir. TuzelMusteri inherits (miras alır) müşteriden. 
    class TuzelMusteri:Musteri
    {
        
        public string VergiNo { get; set; }
    }
}
