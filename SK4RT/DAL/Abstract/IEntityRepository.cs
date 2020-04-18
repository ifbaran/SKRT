using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EFEntities.Abstract;

namespace DAL.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity , new()
    {
        List<T> DalGetAll();
        T DalGetOne();
        void DalAdd(T entity);
        void DalUpdate(T entity);
        void DalDelete(T entity);
    }
}