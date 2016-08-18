﻿using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Repository
{
    public interface ITagRepository : IRepository<DalTag>
    {
        DalTag GetTagByName(string name);
    }
}
