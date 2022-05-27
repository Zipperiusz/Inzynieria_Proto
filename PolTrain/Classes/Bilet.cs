using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Bilet
    {

        protected float Cena { get; set; }
        protected string TypUlgi { get; }
        protected string Status { get; set; }
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


        // True udalo sie kupic , False - nie udalo sie kupic
        public bool KupBilet(Miejsce _miejsce, Wagon wagon, string _typUlgi, float? _ProcentUlgi, float _cena)
        {
            if (wagon.ZajmijMiejsce(_miejsce))
            {
                if(_ProcentUlgi != null)
                {
                    this.Cena = ((float)_cena * (1-(float)_ProcentUlgi));
                }
                else
                {
                    this.Cena = _cena;
                }
                this.Status = "zakupiony";
                return true;
            }

            return false;
        }

        public bool WygenerujBilet()
        {
            // TODO - implement Tranzakcja.WygenerujBilet
            throw new NotImplementedException();
        }

        // True udalo sie zwrocic bilet, False - nie udalo sie zwrocic biletu
        public bool ZwrocBilet(Miejsce _miejsce, Wagon wagon)
        {
            if (wagon.ZwolnijMiejsce(_miejsce))
            {
                this.Status = "zwrócony";
                return true;
            }
            return false;
        }

        public List<Bilet> WyszukajBilet()
        {
            // TODO - implement Bilet.WyszukajBilet
            throw new NotImplementedException();
        }

        public void ObejrzyjBilet(Bilet bilet)
        {
            Console.WriteLine("Cena: " + bilet.Cena);
            Console.WriteLine("Typ ulgi: " + bilet.TypUlgi);
            Console.WriteLine("Status: " + bilet.Status);
            Console.WriteLine("Wazny od: " + bilet.WaznyOd);
            Console.WriteLine("Procent ulgi: " + bilet.ProcentUlgi);
            Console.WriteLine("Numer biletu: " + bilet.NumerBiletu);
            Console.WriteLine("Kod QR: " + bilet.KodQR);
        }


       

    }
}