public class Klient {

	protected string Nazwa { get; }
	protected string Email { get; }
	protected string Haslo;
	protected int NumerKlienta { get; }
	protected string Imie { get; }
	protected string Nazwisko { get; }
	protected string? TypUlgi { get; }

	Klient(string _nazwa, string _email, string _haslo, int _numerKlienta, string _imie, string _nazwisko, string? _typUlgi=null){
		Nazwa=_nazwa;
		Email=_email;
		Haslo=_haslo;
		NumerKlienta=_numerKlienta;
		Imie=_imie;
		Nazwisko=_nazwisko;
		TypUlgi=_typUlgi;

	}
	public void SprawdzPromocje() {
		// TODO - implement Klient.SprawdzPromocje
		throw new NotImplementedException();
	}

	public bool WystawOpinie() {
		// TODO - implement Klient.WystawOpinie
		throw new NotImplementedException();
	}

}