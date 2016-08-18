using System.Collections.Generic;

namespace ORM.Entities
{
    public class Basket
    {
        public Basket()
        {
            Lots = new List<Lot>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Lot> Lots { get; set; }
    }
}