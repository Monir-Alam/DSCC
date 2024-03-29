﻿using System.Linq.Expressions;

namespace InterDept.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T=> Category

        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(T entity);





    }
}
