using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjeto;
using FinalProjeto.Core.Domain;
using FinalProjeto.Persistance;

namespace Peiramata
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

            var lista = db.Actors.GetAllFromOneCountry(Country.United_Kingdom);

            foreach (var item in lista)
            {
                Console.WriteLine("{0,-15}{1,-15}", item.LastName, item.Country);
            }


        }
    }
}
