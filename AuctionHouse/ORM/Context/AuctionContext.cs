using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ORM.Entities;

namespace ORM.Context
{
    public class AuctionContext : DbContext
    {
        public AuctionContext() : base("AuctionData")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
           // Database.SetInitializer<AuctionContext>(new Initializer());
        }
        public virtual DbSet<Lot> Lots { get; set; }
        public virtual DbSet<User> Users { get; set; }
            
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }

        public virtual DbSet<Tag> Tags { get; set; }
    }
}
