namespace PolTrain.Classes
{
    public class Miejsce
    {

        public int NumerMiejsca { get; }
        public bool Specjalne { get; }
        public bool Zajete { get; set; }
        public Wagon Wagon { get; set; }    
        public Bilet Bilet { get; set; }
        public Miejsce(int _numerMiejsca, bool _specjalne, bool _zajete, Wagon _wagon)
        {
            NumerMiejsca = _numerMiejsca;
            Specjalne = _specjalne;
            Zajete = _zajete;
            Wagon = _wagon;
        }
        public Miejsce(int _numerMiejsca, bool _specjalne, bool _zajete)
        {
            NumerMiejsca = _numerMiejsca;
            Specjalne = _specjalne;
            Zajete = _zajete;
           
        }

    }
}