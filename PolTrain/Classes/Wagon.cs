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
        


        public bool ZajmijMiejsce(Miejsce zajmowaneMiejsce)
        {
            if (WolneMiejsca > 0 & zajmowaneMiejsce.Zajete == false)
            {
                zajmowaneMiejsce.Zajete = true;
                WolneMiejsca -= 1;
            }
            // TODO - implement Wagon.zajmijMiejsce
            throw new NotImplementedException();
        }

        public bool ZwolnijMiejsce()
        {
            // TODO - implement Wagon.zwolnijMiejsce
            throw new NotImplementedException();
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