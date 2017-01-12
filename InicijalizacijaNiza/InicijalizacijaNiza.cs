using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    public class InicijalizacijaNiza
    {
        private static void IspisČlanova<T>(string naslov, IEnumerable<T> niz)
        {
            if (niz == null)
                return;

            Console.WriteLine(string.Format("{0} {1}", naslov, typeof(T)));

            foreach (T član in niz)
                Console.WriteLine(član);
        }

        private const int N = 4;

        public static void InicijalizacijaNizaVrijednosnogTipa()
        {
            int[] nizBrojeva = new int[N];  // deklaracija reference na niz
            int[] nizBrojeva2 = new int[] {1,2,3,10,1001} ;


            IspisČlanova("Niz neinicijaliziranih objekata tipa", nizBrojeva);

            nizBrojeva[0] = 12;
            nizBrojeva[3] = 21;
            nizBrojeva[2] = 121;
            nizBrojeva[1] = 212;

            IspisČlanova("Niz inicijaliziranih objekata tipa", nizBrojeva);
        }

        public static void InicijalizacijaNizaReferentnogTipa()
        {
            Control[] nizKontrola = new Control[N];  // deklaracija reference na niz 

            // nizKontrola inicijalizirati kao niz duljine N u kojem su članovi neinicijalizirani

            IspisČlanova("Niz neinicijaliziranih objekata tipa", nizKontrola);

            // Otkomentirati donje naredbe, pokrenuti program i provjeriti ispis.
            nizKontrola[0] = new Button();
            nizKontrola[1] = new Form();
            nizKontrola[2] = nizKontrola[0];
            nizKontrola[3] = new TextBox();

            IspisČlanova("Niz inicijaliziranih objekata tipa", nizKontrola);
        }

        static void Main(string[] args)
        {
            InicijalizacijaNizaVrijednosnogTipa();

            InicijalizacijaNizaReferentnogTipa();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
