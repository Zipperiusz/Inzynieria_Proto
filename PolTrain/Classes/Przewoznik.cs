using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Przewoznik
    {

        List<Pociag> Pociagi { get; }
        protected int NumerPrzewoznika { get; }
        protected string Nazwa { get; }

        public Przewoznik(List<Pociag> _pociagi, int _numerPrzewoznika, string _nazwa)
        {
            Pociagi = _pociagi;
            NumerPrzewoznika = _numerPrzewoznika;
            Nazwa = _nazwa;
        }

        public bool EdytujHarmonogram()
        {
            // TODO - implement Przwoznik.EdytujHarmonogram
            throw new NotImplementedException();
        }

        public bool EdytujTrasy()
        {
            // TODO - implement Przwoznik.EdytujTrasy
            throw new NotImplementedException();
        }

        public bool OpublikujPrzewoz()
        {
            // TODO - implement Przwoznik.OpublikujPrzewoz
            throw new NotImplementedException();
        }



    }
}