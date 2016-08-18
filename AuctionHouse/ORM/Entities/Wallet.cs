namespace ORM.Entities
{
    public class Wallet
    {
        public int Id { get; set; }
        public int Money { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}