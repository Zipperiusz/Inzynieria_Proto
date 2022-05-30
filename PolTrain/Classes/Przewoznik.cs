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

        public bool EdytujHarmonogram(Pociag pociag, Trasa trasa, Stacja stacjaPocz, Stacja stacjaKon,
            DateTime czasPrzyjazdu, DateTime czasOdjazdu)
        {
            if(this.Pociagi.Contains(pociag) & pociag.Trasy.Contains(trasa) & trasa.StacjaKon == stacjaKon  & trasa.StacjaPocz == stacjaPocz)
            {
                stacjaPocz.CzasOdjazdu = czasOdjazdu;
                stacjaKon.CzasPrzyjazdu = czasPrzyjazdu;

                return true;
            }
            return false;

        }

        public bool EdytujTrasy(Pociag pociag, List<Trasa> Trasy)
        {
            if (this.Pociagi.Contains(pociag))
            {
                pociag.Trasy = Trasy;

                return true;
            }
            return false;
        }

        public bool OpublikujPrzewoz()
        {
            // TODO - implement Przwoznik.OpublikujPrzewoz
            throw new NotImplementedException();
        }



    }
}