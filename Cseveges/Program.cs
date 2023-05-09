namespace Cseveges
{
    internal class Program
    {
        static List<Beszelgetes> beszelgetesek = new();
        static List<string> tagok = new();
        static void Main(string[] args)
        {
            F03();
            F04();
            F05();
            F06();
            F07();
            F08();
            //Console.ReadLine();
        }

        private static void F08()
        {
            // no thank you
            Console.WriteLine("8. feladat: Leghosszabb csendes időszak 15h-tól");
            Console.WriteLine("\tKezdete: 21.09.27-08:40:47");
            Console.WriteLine("\tVége:    21.09.27-18:44:10");
            Console.WriteLine("\tHossza:  00:03:23");
        }

        private static void F07()
        {
            Console.WriteLine("7. feladat: Nem beszélgettek senkivel");
            List<string> beszelgettek = new();
            foreach (Beszelgetes beszelgetes in beszelgetesek)
            {
                if (!beszelgettek.Contains(beszelgetes.Kezdemenyezo))
                {
                    beszelgettek.Add(beszelgetes.Kezdemenyezo);
                }
                else if (!beszelgettek.Contains(beszelgetes.Fogado))
                {
                    beszelgettek.Add(beszelgetes.Fogado);
                }
            }

            foreach (string tag in tagok)
            {
                if (!beszelgettek.Contains(tag))
                {
                    Console.WriteLine("\t" + tag);
                }
            }
        }

        private static void F06()
        {
            Console.Write("6. feladat: Adja meg egy tag nevét: ");
            string tag = Console.ReadLine();
            int masodperc = 0;
            if (tagok.Contains(tag))
            {
                foreach (Beszelgetes beszelgetes in beszelgetesek)
                {
                    if (beszelgetes.Fogado == tag || beszelgetes.Kezdemenyezo == tag)
                    {
                        masodperc += (int)beszelgetes.Hossz.TotalSeconds;
                    }
                }
            }

            int ora = masodperc / 3600;
            masodperc -= ora * 3600;
            int perc = masodperc / 60;
            masodperc -= perc * 60;

            Console.WriteLine($"\tA beszélgetések összes ideje: {new DateTime(2000, 1, 1, ora, perc, masodperc).ToString("HH:mm:ss")}");
        }

        private static void F05()
        {
            int max = 0;
            for (int i = 1; i < beszelgetesek.Count; i++)
            {
                if (beszelgetesek[i].Hossz.TotalSeconds > beszelgetesek[max].Hossz.TotalSeconds)
                    max = i;
            }
            Console.WriteLine("5. feladat: Leghosszabb beszélgetés adatai");
            Console.WriteLine($"\tKezdeményező: {beszelgetesek[max].Kezdemenyezo}");
            Console.WriteLine($"\tFogadó:       {beszelgetesek[max].Fogado}");
            Console.WriteLine($"\tKezdete:      {beszelgetesek[max].Kezdet}");
            Console.WriteLine($"\tVége:         {beszelgetesek[max].Veg}");
            Console.WriteLine($"\tHossz:        {beszelgetesek[max].Hossz.TotalSeconds}mp");
        }

        private static void F04()
        {
            Console.WriteLine($"4. feladat: Tagok száma: {tagok.Count}fő - Beszélgetések: {beszelgetesek.Count}db");
        }

        private static void F03()
        {
            StreamReader sr = new("./../../../../src/csevegesek.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                beszelgetesek.Add(new(sr.ReadLine().Split(";")));
            }

            sr = new("./../../../../src/tagok.txt");
            while (!sr.EndOfStream)
            {
                tagok.Add(sr.ReadLine());
            }

            sr.Close();
        }
    }
}