using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Transakcja
    {

        protected float Koszt { get; }
        protected int NumerTransakcji { get; }
        protected DateTime DataZakupu { get; }
        protected string MetodaPlatnosci { get; }
        protected Klient Klient { get; }
        protected List<Bilet> Bilety { get; }

        public Transakcja(float _koszt, int _numerTransakcji, DateTime _dataZakupu, string _metodaPlatnosci)
        {
            Koszt = _koszt;
            NumerTransakcji = _numerTransakcji;
            DataZakupu = _dataZakupu;
            MetodaPlatnosci = _metodaPlatnosci;
        }
        

        public void ZapiszTranzakcje()
        {
            // TODO - implement Tranzakcja.ZapiszTranzakcje
            throw new NotImplementedException();
        }

        public void GenerujRaport()
        {
            // TODO - implement Tranzakcja.GenerujRaport
            throw new NotImplementedException();
        }

    }
}