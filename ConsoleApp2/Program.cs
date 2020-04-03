using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   


    class Program
    {
        static IStocareDate stocareDate = new Fisier();

       static List<Farmacie> medList = new List<Farmacie>();
        static Farmacie m = new Farmacie();


        static void Main(string[] args)
        {

            stocareDate.CitireFisier("date.txt", medList);

            bool close = true;
            while (close)
            {
                Console.WriteLine("\nMenu\n" +
                "1)Adauga medicament\n" +
                "2)Editare Medicament\n" +
                "3)Sterge medicament\n" +
                "4)Cauta medicament\n" +
                "5)Afisare medicamente\n" +
                "6)Exit\n\n");
                Console.Write("Alegeti optiunea:");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    AdaugareMed();
                }
                else if (option == 2)
                {
                    EditareMed();
                }
                else if (option == 3)
                {
                    StergereMed();
                }
                else if (option == 4)
                {
                    CautareMed();
                }
                else if (option == 5)
                {
                    AfisareMed();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Exit");
                    close = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Optiunea invalida!");
                }
            }

            stocareDate.ScrieFisier("output.txt", medList);
        }


        public static void AdaugareMed()
        {
            Farmacie m = new Farmacie();
            Console.WriteLine("Medicament Id:{0}", m.MedID = medList.Count + 1);
            Console.Write("Numele medicamentului:");
            m.MedNume = Console.ReadLine();
            Console.Write("Pretul:");
            m.MedPret = int.Parse(Console.ReadLine());
            Console.Write("Numarul:");
            
            m.X = m.MedNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Prescriptie(0-cu,1-fara):");
            m.Prescriptie1 =(Farmacie.Prescriptie) int.Parse(Console.ReadLine());
            Console.WriteLine("Efecte secundare:");
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("{0} - {1}",i,(Farmacie.EfecteSecundare)i);

            }
            m.EfecteSecundare1 = (Farmacie.EfecteSecundare)int.Parse(Console.ReadLine());

            for (int i = 0; i < medList.Count; i++)
            {
                if(Farmacie.Compara(m,medList[i])==Farmacie.LESS)
                {
                    medList.Insert(i, m);
                    return;
                }
            }
            medList.Add(m);
        }


        public static void StergereMed()
        {
            Farmacie m = new Farmacie();
            Console.Write("Introduceti ID-ul medicamentului ce doriti sa il stergeti: ");

            int Del = int.Parse(Console.ReadLine());

            if (medList.Exists(x => x.MedID == Del))
            {
                medList.RemoveAt(Del - 1);
                Console.WriteLine("Medicament ID - {0} a fost sters", Del);
            }
            else
            {
                Console.WriteLine("ID invalid");
            }

            medList.Add(m);
        }


        public static void CautareMed()
        {
            
            Console.Write("Cautati prin ID:");
            int find = int.Parse(Console.ReadLine());

            Farmacie m = stocareDate.CautareID(find,medList);
            Console.WriteLine(m.ToString());

        }
        public static void AfisareMed()
        {
            
            foreach (Farmacie searchId in medList)
            {

                Console.WriteLine(searchId.ToString());

            }
        }
        public static void CitireFisier()
        {
            stocareDate.CitireFisier("date.txt", medList);
        }
        public static void EditareMed()
        {
            Console.Write("Cautati prin ID:");
            int find = int.Parse(Console.ReadLine());
            Console.WriteLine(stocareDate.CautareID(find,medList));
            Farmacie m = new Farmacie();
            Console.Write("Numele medicamentului:");
            m.MedNume = Console.ReadLine();
            Console.Write("Pretul:");
            m.MedPret = int.Parse(Console.ReadLine());
            Console.Write("Numarul:");

            m.X = m.MedNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Prescriptie(0-cu,1-fara):");
            m.Prescriptie1 = (Farmacie.Prescriptie)int.Parse(Console.ReadLine());
            Console.WriteLine("Efecte secundare:");
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("{0} - {1}", i, (Farmacie.EfecteSecundare)i);

            }
            m.EfecteSecundare1 = (Farmacie.EfecteSecundare)int.Parse(Console.ReadLine());
            stocareDate.Editare(find, m, medList);

        }
    }
}