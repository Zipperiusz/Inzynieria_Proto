using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Bilet
    {
        private Miejsce miejsce;
        private Wagon wagon;

        public float Cena { get; set; }
        public string TypUlgi { get; }
        public string Status { get; set; }
        public DateTime WaznyOd { get; set; }
        public float? ProcentUlgi { get; }
        public int NumerBiletu { get; }
        public string KodQR { get; }
        public List<Miejsce> Miejsca { get; set; }

        public Bilet(float _cena, string _status, DateTime _waznyOd, int _numerBiletu, List<Miejsce> _miejsca, float? _procentUlgi = null, string _kodQR = null, string _typUlgi = null)
        {
            Cena = _cena;
            TypUlgi = _typUlgi;
            Status = _status;
            WaznyOd = _waznyOd;
            ProcentUlgi = _procentUlgi;
            KodQR = _kodQR;
            Miejsca = _miejsca;
        }

        public Bilet() {
            Miejsca = new List<Miejsce>();
        }
        // True udalo sie kupic , False - nie udalo sie kupic
        public bool KupBilet(Miejsce _miejsce, Wagon wagon, float _cena, float? _ProcentUlgi=null)
        {
            if (wagon.ZajmijMiejsce(_miejsce))
            {
                if(_ProcentUlgi != null)
                {
                    Cena = ((float)_cena * (1-(float)_ProcentUlgi));
                }
                else
                {
                    Cena = _cena;
                }
                
                Miejsca.Add(_miejsce);
                WaznyOd = DateTime.Now;
                Status = "zakupiony";
                return true;
            }

            return false;
        }

        

        // True udalo sie zwrocic bilet, False - nie udalo sie zwrocic biletu
        public bool ZwrocBilet(Miejsce _miejsce, Wagon wagon)
        {
            if (_miejsce.Zajete == true && wagon.ZwolnijMiejsce(_miejsce) )
            {
                Status = "zwrocony";
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
            foreach(var item in Miejsca)
            {
                Console.WriteLine($"Miejsce numer: {item.NumerMiejsca}.");
            }
        }


       

    }
}