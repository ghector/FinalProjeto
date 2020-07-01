using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjeto;
using FinalProjeto.Persistance;

namespace Peiramata
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

            foreach (var item in db.Actors.GetAll())
            {
                Console.WriteLine(item.LastName);
            }
            
        }
    }
}
