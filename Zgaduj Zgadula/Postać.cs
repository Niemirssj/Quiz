using System;
using System.Collections.Generic;
using System.Text;

namespace Zgaduj_Zgadula
{

    public abstract class Postać
    {
        public string Imię { get; set; }
        public int Poziom { get; set; }
        
        public int AktualnaLiczbaPunktówŻycia { get; set; }
        public int MaksymalnaLiczbaPunktówŻycia { get; set; }
        public int ZadawaneObrażenia { get; set; }
       

        public Postać()
        {
            Imię = "Nieznany";
            Poziom = 1;
  
            AktualnaLiczbaPunktówŻycia = 3;
            MaksymalnaLiczbaPunktówŻycia = 3;
            ZadawaneObrażenia = 1;
            
        }

        public Postać(string imię, int poziom,
            int aktualnaLiczbaPunktówŻycia, int maksymalnaLiczbaPunktówŻycia, int zadawaneObrażenia)
        {
            Imię = imię;
            Poziom = poziom;
            
            AktualnaLiczbaPunktówŻycia = aktualnaLiczbaPunktówŻycia;
            MaksymalnaLiczbaPunktówŻycia = maksymalnaLiczbaPunktówŻycia;
            
        }

        public override string ToString()
        {
            return $"{Imię}, Poziom: {Poziom}, HP: {AktualnaLiczbaPunktówŻycia}/{MaksymalnaLiczbaPunktówŻycia}, ";
        }

        

        public virtual int ObrażeniaWRundzie
        {
            get
            {
                return ZadawaneObrażenia;
            }
        }

        public virtual void OtrzymajObrażenia(int obrażenia)
        {
            
            AktualnaLiczbaPunktówŻycia = Math.Max(0, AktualnaLiczbaPunktówŻycia - obrażenia);
        }

        public bool CzyNieŻyje
        {
            get
            {
                return AktualnaLiczbaPunktówŻycia == 0;
            }
        }

        
        

        
    }
}
