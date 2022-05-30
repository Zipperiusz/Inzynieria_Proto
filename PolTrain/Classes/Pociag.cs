using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Pociag
    {

        protected string Nazwa { get; }
        protected int IloscWagonow { get; }
        protected int NumerPociagu { get; }
        protected Przewoznik Przewoznik { get; }
        public List<Wagon> Wagony { get;  set; }

        public List<Trasa> Trasy { get; set; }
        public Pociag(string _nazwa, int _iloscWagonow, int _numerPociagu, List<Wagon> _wagony, List<Trasa> _trasy)
        {
            Nazwa = _nazwa;
            IloscWagonow = _iloscWagonow;
            NumerPociagu = _numerPociagu;
            Wagony= _wagony;
            Trasy = _trasy;
        }
    }
}