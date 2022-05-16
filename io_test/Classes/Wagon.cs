public class Wagon {

	protected int Klasa { get; }
	protected int IloscMiejsc { get; }
	protected int WolneMiejsca { get; }
	protected int ZajeteMiejsca { get; }
	protected string TypWagonu { get; }
	protected int NumerWagonu { get; }

	public bool ZajmijMiejsce() {
		// TODO - implement Wagon.zajmijMiejsce
		throw new NotImplementedException();
	}

	public bool ZwolnijMiejsce() {
		// TODO - implement Wagon.zwolnijMiejsce
		throw new NotImplementedException();
	}

	Wagon(int _klasa, int _iloscMiejsc, int _wolneMiejsce, int _zajeteMiejsca, string _typWagonu, int _numerWagonu){
		Klasa = _klasa;
		IloscMiejsc = _iloscMiejsc;
		WolneMiejsca = _wolneMiejsce;
		ZajeteMiejsca = _zajeteMiejsca;
		TypWagonu = _typWagonu;
		NumerWagonu = _numerWagonu;
    }

}