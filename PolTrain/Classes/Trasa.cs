using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Trasa
    {

        public Stacja StacjaPocz { get; }
        public Stacja StacjaKon { get; }
        public float Dlugosc { get; }
        public int IloscKupionychBiletow { get; }
        public int NumerTrasy { get; }
        public List<Stacja> Stacje { get; set; }

        public Pociag Pociag { get; protected set; }


        public Trasa(Stacja _stacjaPocz, Stacja _stacjaKon, float _dlugosc, int _iloscKupionychBiletow, int _numerTrasy)
        {
            StacjaPocz = _stacjaPocz;
            StacjaKon = _stacjaPocz;
            Dlugosc = _dlugosc;
            IloscKupionychBiletow = _iloscKupionychBiletow;
            NumerTrasy = _numerTrasy;
        }

        public void PorownajTrasy()
        {
            // TODO - implement Trasa.PorownajTrasy
            throw new NotImplementedException();
        }

        public bool WyszukajPrzejazd()
        {
            // TODO - implement Trasa.WyszukajPrzejazd
            throw new NotImplementedException();
        }

        public void GenerujRaport()
        {
            // TODO - implement Trasa.GenerujRaport
            throw new NotImplementedException();
        }


    }
}