﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ERPNetCore.Helpers;

namespace ERPNetCore.Core.RepositoryPattern
{
    public interface IRepository<TEntity> where TEntity : class
    {
        OperationResult Add(TEntity entity);
        OperationResult AddRange(IEnumerable<TEntity> entities);

        //void Update(TEntity entity);

        OperationResult Remove(TEntity entity);
        OperationResult RemoveRange(IEnumerable<TEntity> entities);

        TEntity GetEntity(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

    }
}