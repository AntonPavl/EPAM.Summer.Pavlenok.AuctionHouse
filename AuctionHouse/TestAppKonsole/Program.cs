using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM.Context;
using ORM.Entities;
namespace TestAppKonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AuctionContext())
            {
                db.Lots.Add(new Lot() { Name = "Del1ete" });
                db.SaveChanges();
                foreach (var item in db.Lots)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
