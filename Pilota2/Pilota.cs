using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilota2
{
    internal class Pilota
    {
        string nev;
        //DateTime szuldatum;
        string szuldatum;
        string nemzetiseg;
        string rajtszam;

        public Pilota(string nev, string szuldatum, string nemzetiseg, string rajtszam = "")
        {
           //  throw new InvalidOperationException("Nem sikerült kinyerni az évszámot az szuldatum-ból.");

            this.nev = nev;
            this.szuldatum = szuldatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

       
        // Osztályokosítás:
        public string Nev { get => nev; set => nev = value; }
      
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public string Rajtszam { get => rajtszam; set => rajtszam = value; }

       // public int SzulEv { get => Convert.ToInt32(szuldatum.Substring(4)); }  // Substring ---> leválasztás, vagy kivágás.
       //                                                                     .. jelen esetben az első 4 karaktert választom le
                                                                         //   ...vagyis az évszámot, amit meg számmá alakítok.

        //1991.01.01
        public int SzulEv { get => int.Parse(szuldatum.Substring(0, 4)); }   // ... vagy így is át lehet alakítani számmá, mindkét eset jó.
                   
            
        public int SzulHonap { get => int.Parse(szuldatum.Substring(6, 2)); }  // Itt az 5. után lévők közül 2 karakter kell.
        public int SzulNap { get => int.Parse(szuldatum.Substring(9, 2)); }    // Itt a 8. uáni karaktertől számítva szintén 2 karakter kell.

                                                                             // Tehát azt írjuk elsőször, hogy melyik karakter utántól számolja,
                                                                             //...  utána pedig  azt, amennyire szükségünk van. 

       
    }
}
