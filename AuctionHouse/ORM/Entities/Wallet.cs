using System.ComponentModel.DataAnnotations;

namespace ORM.Entities
{
    public class Wallet
    {
        public int Id { get; set; }
        public int Money { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}