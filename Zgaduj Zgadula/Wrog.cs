using System;
using System.Collections.Generic;
using System.Text;

namespace Zgaduj_Zgadula
{
    public class Wrok : Postać
    {
        

        public Wrok(string imię, int poziom,
                    int aktualnaLiczbaPunktówŻycia, int maksymalnaLiczbaPunktówŻycia, int zadawaneObrażenia)
            : base(imię, poziom, aktualnaLiczbaPunktówŻycia, maksymalnaLiczbaPunktówŻycia, zadawaneObrażenia)
        {
            
           
        }

        public Action<int> atak;

        public virtual void OtrzymajObrażenia(int obrażenia, int at)
        {
            obrażenia = Math.Max(0, obrażenia);
            AktualnaLiczbaPunktówŻycia = Math.Max(0, AktualnaLiczbaPunktówŻycia - obrażenia);
        }

        public void Atak()
        {
            
            atak?.Invoke(ZadawaneObrażenia);
        }

       
    }
}
