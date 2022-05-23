using System;

namespace PolTrain.Classes
{
    public class Stacja
    {

        protected string Nazwa { get; }
        protected DateTime CzasOdjazdu { get; }
        protected DateTime CzasPrzyjazdu { get; }
        protected int NumerStacji { get; }
        protected Trasa Trasa { get; }
        protected Polaczenie Polaczenie { get; }
        public Stacja(string _nazwa, DateTime _czasOdjazdu, DateTime _czasPrzyjazdu, int _numerStacji, Trasa _trasa, Polaczenie _polaczenie)
        {
            Nazwa = _nazwa;
            CzasOdjazdu = _czasOdjazdu;
            CzasPrzyjazdu = _czasPrzyjazdu;
            NumerStacji = _numerStacji;
            Trasa = _trasa;
            Polaczenie = _polaczenie;
        }

    }
}