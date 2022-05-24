using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Wagon
    {

        public int Klasa { get; }
        public int IloscMiejsc { get; }
        public int WolneMiejsca { get; protected set; }
        public int ZajeteMiejsca { get; }
        public string TypWagonu { get; }
        public int NumerWagonu { get; }
        protected Pociag Pociag { get; }
        public List<Miejsce> Miejsca { set; get; } 
        public Wagon(int _klasa, int _iloscMiejsc, int _wolneMiejsca, string _typWagonu, int _numerWagonu)
        {
            Klasa = _klasa;
            IloscMiejsc = _iloscMiejsc;
            WolneMiejsca = _wolneMiejsca;
            ZajeteMiejsca = _iloscMiejsc- _wolneMiejsca;
            TypWagonu = _typWagonu;
            NumerWagonu = _numerWagonu;
        }


        /// <summary>
        /// Zwraca <c>True</c> jeœli zajmowanie miejsca zakoñczy³o siê pomyœlnie.
        /// <c>False</c> w przypadku gdy nie uda³o siê zaj¹æ miejsca.
        /// </summary>
        public bool ZajmijMiejsce(Miejsce zajmowaneMiejsce)
        {
            if (WolneMiejsca > 0 & zajmowaneMiejsce.Zajete == false & Miejsca.Contains(zajmowaneMiejsce))
            {
                zajmowaneMiejsce.Zajete = true;
                WolneMiejsca -= 1;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Zwraca <c>True</c> jeœli zwalnianie miejsca zakoñczy³o siê pomyœlnie.
        /// <c>False</c> w przypadku gdy nie uda³o siê zwolniæ miejsca.
        /// </summary>
        public bool ZwolnijMiejsce(Miejsce zwalnianeMiejsce)
        {
            if(ZajeteMiejsca > 0 & zwalnianeMiejsce.Zajete == true & Miejsca.Contains(zwalnianeMiejsce))
            {
                zwalnianeMiejsce.Zajete = false;
                WolneMiejsca += 1;
                return true;
            }
            return false;

        }


    }
}