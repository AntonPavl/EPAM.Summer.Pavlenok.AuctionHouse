namespace ORM.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}