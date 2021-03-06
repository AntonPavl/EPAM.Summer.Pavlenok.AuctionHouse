﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class DalLot : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int? RedemptionCost { get; set; }
        public bool IsBuyed { get; set; }
        public int OwnerId { get; set; }
        public int GamerId { get; set; }

    }
}
