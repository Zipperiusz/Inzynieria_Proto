public class Pociag {

	protected string Nazwa { get; }
	protected int IloscWagonow { get; }
	protected int NumerPociagu { get; }
	Pociag(string _nazwa, int _iloscWagonow, int _numerPociagu){
		Nazwa=_nazwa;
		IloscWagonow=_iloscWagonow;
		NumerPociagu=_numerPociagu;
	}
}