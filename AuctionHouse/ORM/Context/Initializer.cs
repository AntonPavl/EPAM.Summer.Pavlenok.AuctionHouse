using ORM.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Context
{
    public class Initializer : DropCreateDatabaseAlways<AuctionContext>
    {
        protected override void Seed(AuctionContext context)
        {
            IList<Lot> defaultStandards = new List<Lot>();

            defaultStandards.Add(new Lot() { Name = "1111", Cost = 1111 , RedemptionCost = 2222, IsBuyed = false});
            defaultStandards.Add(new Lot() { Name = "31111", Cost = 31111, RedemptionCost = 32222, IsBuyed = false });
            defaultStandards.Add(new Lot() { Name = "41111", Cost = 41111, RedemptionCost = 42222, IsBuyed = false });

            foreach (Lot std in defaultStandards) context.Lots.Add(std);

            base.Seed(context);
        }
    }

}
