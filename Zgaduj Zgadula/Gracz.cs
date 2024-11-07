using System;
using System.Collections.Generic;
using System.Text;

namespace Zgaduj_Zgadula
{
    public class Gracz: Postać
    {



        public Gracz(string imię)
            : base(imię, 1, 3, 3, 1)
        {
            
        }

        public override int ObrażeniaWRundzie
        {
            get
            {
                return ZadawaneObrażenia;
            }
        }

       

        public override string ToString()
        {
            return base.ToString() ;
        }
    }
}
