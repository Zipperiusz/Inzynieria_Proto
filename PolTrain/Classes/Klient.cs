using System;
using System.Collections.Generic;

namespace PolTrain.Classes
{
    public class Klient
    {

        public string Nazwa { get; }
        public string Email { get; }
        public string Haslo;
        public int NumerKlienta { get; }
        public string Imie { get; }
        public string Nazwisko { get; }
        public string TypUlgi { get; }
        public float? ProcentUlgi { get; }

        protected List<Transakcja> Transakcje { get; }
        public Klient(string _nazwa, string _email, string _haslo, int _numerKlienta, string _imie, string _nazwisko, float? _procentUlgi=null, string _typUlgi = null)
        {
            Nazwa = _nazwa;
            Email = _email;
            Haslo = _haslo;
            NumerKlienta = _numerKlienta;
            Imie = _imie;
            Nazwisko = _nazwisko;
            TypUlgi = _typUlgi;

        }
        public void SprawdzPromocje()
        {
            // TODO - implement Klient.SprawdzPromocje
            throw new NotImplementedException();
        }

        public bool WystawOpinie()
        {
            // TODO - implement Klient.WystawOpinie
            throw new NotImplementedException();
        }

    }
}