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
                //User user = new User()
                //{
                //    Email = "asdasd",
                //    Password = "asdasd",
                //    Profile = new Profile()
                //    {
                //        FirstName = "Name",
                //        LastName = "Name2",
                //        Age = 100
                //    },
                //    Basket = new Basket()
                //    {
                //        Name = "asdasdBasket",
                //    },
                //    Wallet = new Wallet()
                //    {
                //        Money = 10000
                //    }
                //};
                //db.Roles.Add(new Role() { Name = "Admin" });
                //db.SaveChanges();
                //user.Roles.Add(db.Roles.FirstOrDefault(x=>x.Name=="Admin"));
                //Lot lot = new Lot()
                //{
                //    Cost = 1000,
                //    RedemptionCost = 10000,
                //    Name = "Lot1",
                //    Gamer = user,
                //    Owner = user,
                //    IsBuyed = false
                //};
                //lot.Tags.Add(new Tag() {
                //    Name = "Tag1"
                //});
                //db.Lots.Add(lot);
                foreach (var item in db.Users)
                {
                    if (item.Id == 2)
                    {
                        Console.WriteLine(item.Profile);
                    }         
               }
                db.SaveChanges();
                Console.WriteLine("Finished");
            }
        }
    }
}
