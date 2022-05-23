using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Bilet
    {

        protected float Cena { get; }
        protected string TypUlgi { get; }
        protected string Status { get; }
        protected DateTime WaznyOd { get; }
        protected float? ProcentUlgi { get; }
        protected int NumerBiletu { get; }
        protected string KodQR { get; }
        Transakcja Transakcja { get; }
        protected List<Miejsce> Miejsca { get; }

        public Bilet(float _cena, string _status, DateTime _waznyOd, int _numerBiletu, float? _procentUlgi = null, string _kodQR = null, string _typUlgi = null)
        {
            Cena = _cena;
            TypUlgi = _typUlgi;
            Status = _status;
            WaznyOd = _waznyOd;
            ProcentUlgi = _procentUlgi;
            NumerBiletu = _numerBiletu;
            KodQR = _kodQR;
        }



        public bool KupBilet(Miejsce _miejsce,string _typUlgi,float? _ProcentUlgi, float _cena)
        {
            

            return true;
        }

        public bool WygenerujBilet()
        {
            // TODO - implement Tranzakcja.WygenerujBilet
            throw new NotImplementedException();
        }

        public bool ZwrocBilet()
        {
            // TODO - implement Bilet.ZwrocBilet
            throw new NotImplementedException();
        }

        public List<Bilet> WyszukajBilet()
        {
            // TODO - implement Bilet.WyszukajBilet
            throw new NotImplementedException();
        }

        public Bilet ObejrzyjBilet()
        {
            // TODO - implement Bilet.ObejrzyjBilet
            throw new NotImplementedException();
        }


       

    }
}