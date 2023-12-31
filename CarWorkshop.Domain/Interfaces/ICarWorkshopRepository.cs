﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Domain.Interfaces
{
    public interface ICarWorkshopRepository
    {
        Task CreateAsync(Domain.Entities.CarWorkshop carWorkshop);
        Task<Entities.CarWorkshop?> GetByNameAsync(string name);
    }
}
