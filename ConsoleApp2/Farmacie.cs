using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Farmacie
    {
        public enum Prescriptie
        {
            Cu,Fara


        }
        [Flags]
        public enum EfecteSecundare
        {
            Mancarimi=1,Varsaturi=2,Eruptii=4,Nimic=0
                


        }

        public const int LESS = -1;
        public const int MORE = 1;
        public const int EQUAL = 0;
        private int medID;
        private string medNume;
        private int medPret;
        private int medNr;
        private Prescriptie prescriptie;
        private EfecteSecundare efecteSecundare;
        private int x;


        public Farmacie()
        {
            MedID = 0;
            MedNume = null;
            MedPret = 0;
            MedNr = 0;
            prescriptie =Prescriptie.Fara;
            efecteSecundare = EfecteSecundare.Nimic;


        }
        public Farmacie(int id, string nume, int pret, int numar,Prescriptie pr,EfecteSecundare ef)
        {
            MedID = id;
            MedNume = nume;
            MedPret = pret;
            MedNr = numar;
            prescriptie = pr;
            efecteSecundare = ef;
        }
        public Farmacie(string linie)
        {
            string[] componente = linie.Split(',');
            medID = int.Parse(componente[0]);
            medNume =componente[1];
            medPret = int.Parse(componente[2]);
            medNr = int.Parse(componente[3]);
            prescriptie = (Prescriptie) int.Parse(componente[4]);
            efecteSecundare= (EfecteSecundare)int.Parse(componente[5]);

           


        }


        public int MedID { get => medID; set => medID = value; }
        public string MedNume { get => medNume; set => medNume = value; }
        public int MedPret { get => medPret; set => medPret = value; }
        public int MedNr { get => medNr; set => medNr = value; }
        public int X { get => x; set => x = value; }
        internal Prescriptie Prescriptie1 { get => prescriptie; set => prescriptie = value; }
        internal EfecteSecundare EfecteSecundare1 { get => efecteSecundare; set => efecteSecundare = value; }

        public override string ToString()
        {
           return string.Format("Medicament ID :{0}\n" +
                "Medicamentul :{1}\n" +
                "Pretul :{2}\n" +
                "Numarul :{3}\n " +
                "Prescriptie:{4}\n" +
                "Efecte secundare :{5}", MedID, MedNume,MedPret,MedNr,prescriptie,efecteSecundare);
        }
        public static int Compara(Farmacie f1,Farmacie f2)
        {
            return string.Compare(f1.medNume, f2.medNume);
        }

    }
}
