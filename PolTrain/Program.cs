using PolTrain.Classes;
using System;

namespace PolTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INICJALIZACJA
            var pociag = Init.CreatePociag();

            var klient1 =  Init.CreateKlient();
            var klient2 = Init.CreateKlient();
            var klient3 = Init.CreateKlient();

            // KUPNO BILETÓW
            Transakcja transakcja1 = new Transakcja(klient1, "blik");
            var transakcja2 = new Transakcja(klient2, "blik");  
            var transakcja3 = new Transakcja(klient3, "karta"); 
            var transakcja4 = new Transakcja(klient3, "karta");
            var transakcja5 = new Transakcja(klient2, "blik");



            var res1 = transakcja1.WygenerujBilet(pociag.Wagony[0].Miejsca[0], pociag.Wagony[0], 15f);
            var res2 = transakcja2.WygenerujBilet(pociag.Wagony[0].Miejsca[1], pociag.Wagony[0], 20f); //ZAJETE MIEJSCE
            var res3 = transakcja3.WygenerujBilet(pociag.Wagony[0].Miejsca[2], pociag.Wagony[0], 15f); // ZAJETE MIEJSCE
            var res4 = transakcja4.WygenerujBilet(pociag.Wagony[0].Miejsca[4], pociag.Wagony[0], 30f);
            var res5 = transakcja5.WygenerujBilet(pociag.Wagony[0].Miejsca[5], pociag.Wagony[0], 20f);

            Console.WriteLine("Czy udało się zakupić bilet:");
            Console.WriteLine("Transakcja1:" + res1);
            Console.WriteLine("Transakcja2:" + res2); //ZAJETE MIEJSCE POWINNO ZWROCIC FALSE
            Console.WriteLine("Transakcja3:" + res3); //ZAJETE MIEJSCE POWINNO ZWROCIC FALSE
            Console.WriteLine("Transakcja4:" + res4);
            Console.WriteLine("Transakcja5:" + res5);

            // ZWRACANIE BILETU
            var zwrocBilet = transakcja5.Bilety[0].ZwrocBilet(pociag.Wagony[0].Miejsca[5], pociag.Wagony[0]);
            Console.WriteLine("Czy udało się zwrócić bilet:");
            Console.WriteLine(zwrocBilet);

            //PRÓBA ZWRÓCENIA TEGO SAMEGO BILETU 2 RAZ
            var zwrocBilet2Raz = transakcja5.Bilety[0].ZwrocBilet(pociag.Wagony[0].Miejsca[5], pociag.Wagony[0]);
            Console.WriteLine("Czy udało się zwrócić bilet 2 raz:");
            Console.WriteLine(zwrocBilet2Raz);


            //PRÓBA KUPIENIA, ZAKUPIONEGO WCZEŚNIEJ MIEJSCA.
            var transakcja6 = new Transakcja(klient1, "blik");
            var res6 = transakcja6.WygenerujBilet(pociag.Wagony[0].Miejsca[0], pociag.Wagony[0], 15f);
            Console.WriteLine("Czy udało się kupić, wcześniej zapukione miejsce");
            Console.WriteLine(res6);

            
            // WYŚWIETLENIE BILETÓW:
            Console.WriteLine("Wyświetlenie 1 biletu:\n");
            transakcja1.Bilety[0].ObejrzyjBilet();

            Console.WriteLine("\nWyświetlenie 2 biletu:\n");
            transakcja4.Bilety[0].ObejrzyjBilet();

            // BILET O STATUSIE ZWRÓCONY
            Console.WriteLine("\nWyświetlenie 3 biletu:\n");
            transakcja5.Bilety[0].ObejrzyjBilet();
        }
    }
}
