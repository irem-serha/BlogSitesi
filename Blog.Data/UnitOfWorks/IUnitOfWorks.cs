﻿using Blog.Core.Entities;
using Blog.DataAccessLayer.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.UnitOfWorks
{
    public interface IUnitOfWorks : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IEntityBase,new();
        Task<int> SaveAsync();
        int Save();
    }
}
