using DAL.Interface.DTO;
using ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class DalMapper
    {

        public static User ToOrmUser(this DalUser user)
        {
            return new User()
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
            };
        }

        public static DalUser ToDalUser(this User user)
        {
            return new DalUser()
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password
            };
        }

        public static Basket ToOrmBasket(this DalBasket basket)
        {
            return new Basket()
            {
                Id = basket.Id,
                Name = basket.Name
            };
        }

        public static DalBasket ToDalBasket(this Basket basket)
        {
            return new DalBasket()
            {
                Id = basket.Id,
                Name = basket.Name
            };
        }

        public static Lot ToOrmLot(this DalLot Lot)
        {
            return new Lot()
            {
                Id = Lot.Id,
                Name = Lot.Name,
                IsBuyed = Lot.IsBuyed,
                Cost = Lot.Cost,
                RedemptionCost = Lot.RedemptionCost
            };
        }

        public static DalLot ToDalLot(this Lot Lot)
        {
            return new DalLot()
            {
                Id = Lot.Id,
                Name = Lot.Name,
                Cost = Lot.Cost,
                RedemptionCost = Lot.RedemptionCost,
                IsBuyed = Lot.IsBuyed
            };
        }

        public static Profile ToOrmProfile(this DalProfile profile)
        {
            return new Profile()
            {
                Id = profile.Id,
                Age = profile.Age,
                FirstName = profile.FirstName,
                LastName = profile.LastName
            };
        }

        public static DalProfile ToDalProfile(this Profile profile)
        {
            return new DalProfile()
            {
                Id = profile.Id,
                Age = profile.Age,
                FirstName = profile.FirstName,
                LastName = profile.LastName
            };
        }

        public static Role ToOrmRole(this DalRole Role)
        {
            return new Role()
            {
                Id = Role.Id,
                Name = Role.Name
            };
        }

        public static DalRole ToDalRole(this Role Role)
        {
            return new DalRole()
            {
                Id = Role.Id,
                Name = Role.Name
            };
        }

        public static Tag ToOrmTag(this DalTag Tag)
        {
            return new Tag()
            {
                Id = Tag.Id,
                Name = Tag.Name
            };
        }

        public static DalTag ToDalTag(this Tag Tag)
        {
            return new DalTag()
            {
                Id = Tag.Id,
                Name = Tag.Name
            };
        }

        public static Wallet ToOrmWallet(this DalWallet Wallet)
        {
            return new Wallet()
            {
                Id = Wallet.Id,
                Money = Wallet.Money
            };
        }

        public static DalWallet ToDalWallet(this Wallet Wallet)
        {
            return new DalWallet()
            {
                Id = Wallet.Id,
                Money = Wallet.Money
            };
        }

    }
}
