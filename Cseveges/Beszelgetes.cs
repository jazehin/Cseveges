namespace Cseveges
{
    internal class Beszelgetes
    {

        public DateTime KezdetDatumkent
        {
            get
            {
                int ev = int.Parse(Kezdet.Substring(0, 2));
                int ho = int.Parse(Kezdet.Substring(3, 2));
                int nap = int.Parse(Kezdet.Substring(6, 2));
                int ora = int.Parse(Kezdet.Substring(9, 2));
                int perc = int.Parse(Kezdet.Substring(12, 2));
                int masodperc = int.Parse(Kezdet.Substring(15, 2));
                return new(ev, ho, nap, ora, perc, masodperc);
            }
        }

        public DateTime VegDatumkent
        {
            get
            {
                int ev = int.Parse(Veg.Substring(0, 2));
                int ho = int.Parse(Veg.Substring(3, 2));
                int nap = int.Parse(Veg.Substring(6, 2));
                int ora = int.Parse(Veg.Substring(9, 2));
                int perc = int.Parse(Veg.Substring(12, 2));
                int masodperc = int.Parse(Veg.Substring(15, 2));
                return new(ev, ho, nap, ora, perc, masodperc);
            }
        }

        public TimeSpan Hossz
        {
            get
            {
                return VegDatumkent.Subtract(KezdetDatumkent);
            }
        }

        public string Kezdet { get; set; }
        public string Veg { get; set; }
        public string Kezdemenyezo { get; set; }
        public string Fogado { get; set; }

        public Beszelgetes(string[] tomb)
        {
            this.Kezdet = tomb[0];
            this.Veg = tomb[1];
            this.Kezdemenyezo = tomb[2];
            this.Fogado = tomb[3];
        }
    }
}
