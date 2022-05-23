using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Wagon
    {

        protected int Klasa { get; }
        protected int IloscMiejsc { get; }
        protected int WolneMiejsca { get; set; }
        protected int ZajeteMiejsca { get; }
        protected string TypWagonu { get; }
        protected int NumerWagonu { get; }
        

        //TRUE- udalo sie zajac miejce FALSE- nie udalo sie zajac miejsca
        public bool ZajmijMiejsce(Miejsce zajmowaneMiejsce)
        {
            if (WolneMiejsca > 0 & zajmowaneMiejsce.Zajete == false)
            {
                zajmowaneMiejsce.Zajete = true;
                WolneMiejsca -= 1;
                return true;
            }
            return false;
        }

        //TRUE- udalo sie zwolnic miejce, FALSE- nie udalo sie zwolnic miejsca
        public bool ZwolnijMiejsce(Miejsce zwalnianeMiejsce)
        {
            if(ZajeteMiejsca>0 & zwalnianeMiejsce.Zajete == true)
            {
                zwalnianeMiejsce.Zajete = false;
                WolneMiejsca += 1;
                return true;
            }
            return false;

        }

        public Wagon(int _klasa, int _iloscMiejsc, int _wolneMiejsce, int _zajeteMiejsca, string _typWagonu, int _numerWagonu)
        {
            Klasa = _klasa;
            IloscMiejsc = _iloscMiejsc;
            WolneMiejsca = _wolneMiejsce;
            ZajeteMiejsca = _zajeteMiejsca;
            TypWagonu = _typWagonu;
            NumerWagonu = _numerWagonu;
        }

    }
}