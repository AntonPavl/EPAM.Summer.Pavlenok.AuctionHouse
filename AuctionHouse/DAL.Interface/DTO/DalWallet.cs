using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class DalWallet : IEntity
    {
        public int Id { get; set; }
        public int Money { get; set; }

        public int UserId { get; set; }
    }
}
