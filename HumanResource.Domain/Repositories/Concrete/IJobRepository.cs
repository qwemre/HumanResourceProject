﻿using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Repositories.Concrete
{
    public interface IJobRepository:IMainRepository<Job>
    {

        Task<ICollection<Job>> GetAll(int id);
    }
}
