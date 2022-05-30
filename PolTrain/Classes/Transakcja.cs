using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Transakcja
    {

        public float Koszt { get; }
        public int NumerTransakcji { get; }
        public DateTime DataZakupu { get; }
        public string MetodaPlatnosci { get; }
        public Klient Klient { get; }
        public List<Bilet> Bilety { get; }

        public Transakcja(float _koszt, int _numerTransakcji, DateTime _dataZakupu, string _metodaPlatnosci, Klient _klient, List<Bilet> _bilety)
        {
            Koszt = _koszt;
            NumerTransakcji = _numerTransakcji;
            DataZakupu = _dataZakupu;
            MetodaPlatnosci = _metodaPlatnosci;
            Klient = _klient;
            Bilety = _bilety;
        }

        public bool WygenerujBilet()
        {
            //Bilet bilet = new Bilet();
            return false;
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