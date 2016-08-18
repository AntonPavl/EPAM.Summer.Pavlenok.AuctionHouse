using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Entities
{
    public class Tag
    {
        public Tag()
        {
            Lots = new List<Lot>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Lot> Lots { get; set; }    
    }
}
