using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilota2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pilota> pilotak = new List<Pilota>();
             File.ReadAllLines("pilotak.csv").Skip(1);

            string[] sorok = File.ReadAllLines("pilotak.csv");
            foreach (var sor in sorok) {

              //  Console.WriteLine( sor);  
            }
           
            Console.WriteLine($"3.feladat: {sorok.Length-1}");
            Console.WriteLine($"3.feladat: {sorok.Count()-1}");
            Console.WriteLine($"4.feladat: {sorok.Last().Split(';')[0]}");
      

            string[] adatok = File.ReadAllLines("pilotak.csv");

            for (int i = 0; i < adatok.Length; i++)
            {
                string[] adatsorok = adatok[i].Split(';');
               //  Pilota tagok = new Pilota(adatsorok[0], Convert.ToDateTime(adatsorok[1]), adatsorok[2], adatsorok[3]);
                Pilota tagok = new Pilota(adatsorok[0], (adatsorok[1]), adatsorok[2], adatsorok[3]);
                pilotak.Add(tagok);
              
            }
            Console.WriteLine($"4.feladat: {pilotak[pilotak.Count - 1].Nev}");


            // 5. feladatban leválogatás és soronkénti tesztelés
            foreach(var pilota in pilotak) {
                if (pilota.SzulEv < 1901)
                {
                    Console.WriteLine($"5.feladat:\t{pilota.Nev} ({pilota.SzulEv}. {pilota.SzulHonap}. {pilota.SzulNap}.)");

                }
            }  

            
        }
    }
}
