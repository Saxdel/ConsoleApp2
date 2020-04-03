using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    public class Fisier : IStocareDate
    {
        public Fisier()
        {

        }

        Farmacie IStocareDate.Cautare(string nume, List<Farmacie> lst)
        {
            foreach (var item in lst)
            {
                if (nume == item.MedNume)
                    return item;
            }
            return null;
        }

        Farmacie IStocareDate.CautareID(int id, List<Farmacie> lst)
        {
            foreach (var item in lst)
            {
                if (id == item.MedID)
                    return item;
            }
            return null;
        }

        public void CitireFisier(string numefis, List<Farmacie> lst)
        {
            using (StreamReader sr = new StreamReader(numefis))
            {
                while(!sr.EndOfStream)
                {
                    lst.Add(new Farmacie(sr.ReadLine()));
                }
            }
           
        }

        public void Editare(int id, Farmacie f, List<Farmacie> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (id == lst[i].MedID)
                    lst[i] = f;
            }
           

        }

        public void ScrieFisier(string numefis, List<Farmacie> lst)
        {
            using (StreamWriter sw = new StreamWriter(numefis))
            {
                foreach (var item in lst)
                {
                    sw.Write(item.ToString());
                }
               
            }
        }

        
    }
}
