using System.Collections.Generic;

namespace ORM.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual List<Role> Roles { get; set; }
        public int? WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
        public int? BasketId { get; set; }
        public virtual Basket Basket { get; set; }
    }
}