using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Polaczenie
    {

        protected Stacja StacjaPocz { get; }
        protected Stacja StacjaKon { get; }
        protected TimeSpan? CzasPrzejazdu { get; }
        protected float Dlugosc { get; }
        protected int NumerPolaczenia { get; }
        protected List<Stacja> Stacje { get; }

        public Polaczenie(Stacja _stacjaPocz, Stacja _stacjaKon, float _dlugosc, int _numerPolaczenia, TimeSpan? _czasPrzejazdu = null)
        {
            StacjaPocz = _stacjaPocz;
            StacjaKon = _stacjaKon;
            CzasPrzejazdu = _czasPrzejazdu;
            Dlugosc = _dlugosc;
            NumerPolaczenia = _numerPolaczenia;
        }

    }
}