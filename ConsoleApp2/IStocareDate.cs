using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IStocareDate
    {
        Farmacie Cautare(string nume, List<Farmacie> lst);
        void Editare(int id, Farmacie f, List<Farmacie> lst);
        Farmacie CautareID(int id, List<Farmacie> lst);
        void CitireFisier(string numefis, List<Farmacie> lst);
        void ScrieFisier(string numefis, List<Farmacie> lst);
    }
}
