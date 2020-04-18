using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccessLayer.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll();
        T GetOne();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}