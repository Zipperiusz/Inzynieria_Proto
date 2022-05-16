public class Trasa {

	protected Stacja StacjaPocz { get; }
	protected Stacja StacjaKon { get; }
	protected float Dlugosc { get; }
	protected int IloscKupionychBiletow { get; }
	protected int NumerTrasy { get; }

	Trasa(Stacja _stacjaPocz, Stacja _stacjaKon, float _dlugosc, int _iloscKupionychBiletow, int _numerTrasy)
    {
		StacjaPocz = _stacjaPocz;
		StacjaKon = _stacjaPocz;
		Dlugosc = _dlugosc;
		IloscKupionychBiletow = _iloscKupionychBiletow;
		NumerTrasy = _numerTrasy;

	}

	public void PorownajTrasy() {
		// TODO - implement Trasa.PorownajTrasy
		throw new NotImplementedException();
	}

	public bool WyszukajPrzejazd() {
		// TODO - implement Trasa.WyszukajPrzejazd
		throw new NotImplementedException();
	}

	public void GenerujRaport() {
		// TODO - implement Trasa.GenerujRaport
		throw new NotImplementedException();
	}


}