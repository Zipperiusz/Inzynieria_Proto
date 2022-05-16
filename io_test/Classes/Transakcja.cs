public class Transakcja {

	protected float Koszt { get; }
	protected int NumerTransakcji { get; }
	protected DateTime DataZakupu { get; }
	protected string MetodaPlatnosci { get; }

	public bool WygenerujBilet() {
		// TODO - implement Tranzakcja.WygenerujBilet
		throw new NotImplementedException();
	}

	public void ZapiszTranzakcje() {
		// TODO - implement Tranzakcja.ZapiszTranzakcje
		throw new NotImplementedException();
	}

	public void GenerujRaport() {
		// TODO - implement Tranzakcja.GenerujRaport
		throw new NotImplementedException();
	}

}