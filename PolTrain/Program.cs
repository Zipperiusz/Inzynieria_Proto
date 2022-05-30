using PolTrain.Classes;
using System;

namespace PolTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var pociag = Init.CreatePociag2();
           
            var klient =  Init.CreateKlient();
            var transakcja = new Transakcja(klient, "blik");
            var res =transakcja.WygenerujBilet(pociag.Wagony[0].Miejsca[0], pociag.Wagony[0], 1.5f);
            Console.WriteLine(res);
        }
    }
}
