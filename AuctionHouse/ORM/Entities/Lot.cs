using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entities
{
    public class Lot
    {
        public Lot()
        {
            Tags = new List<Tag>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int? RedemptionCost { get; set; }
        public bool IsBuyed { get; set; }
        public virtual User Owner { get; set; }
        public virtual User Gamer { get; set; }
        public virtual List<Tag> Tags { get; set; }

    }
}
