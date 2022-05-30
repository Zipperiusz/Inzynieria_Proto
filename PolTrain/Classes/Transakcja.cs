using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Transakcja
    {

        public float Koszt { get; }
        public int NumerTransakcji { get; }
        public DateTime DataZakupu { get; protected set; }
        public string MetodaPlatnosci { get; protected set; }
        public Klient Klient { get; protected set; }
        public List<Bilet> Bilety { get; protected set; }

        public Transakcja(float _koszt, int _numerTransakcji, DateTime _dataZakupu, string _metodaPlatnosci, Klient _klient, List<Bilet> _bilety)
        {
            Koszt = _koszt;
            NumerTransakcji = _numerTransakcji;
            DataZakupu = _dataZakupu;
            MetodaPlatnosci = _metodaPlatnosci;
        }
        public Transakcja(Klient _klient, string _metodaPlatnosci)
        {
            Klient = _klient;
            MetodaPlatnosci = _metodaPlatnosci;
        }
        public bool WygenerujBilet(Miejsce _miejsce,Wagon _wagon,float _cena)
        {
            

            Bilet bilet = new Bilet();

            if(bilet.KupBilet(_miejsce, _wagon, _cena, Klient.ProcentUlgi))
            {
                DataZakupu = DateTime.Now;
                Bilety.Add(bilet);
                return true;
            }
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