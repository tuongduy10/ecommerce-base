﻿using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ECommerce.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> Query(Expression<Func<T, bool>> expression = null);
        // Single obj
        Task<T> FindAsyncWhere(Expression<Func<T, bool>> expression);
        Task<T> FindLastAsyncWhere(Expression<Func<T, bool>> expression);
        // List
        Task<IEnumerable<T>> ToListAsync();
        Task<IEnumerable<T>> ToListAsyncWhere(Expression<Func<T, bool>> expression);
        // Add
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        // Update
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        // Remove
        Task RemoveAsyncWhere(Expression<Func<T, bool>> expression);
        Task RemoveRangeAsyncWhere(Expression<Func<T, bool>> expression);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        // Save changes
        Task SaveChangesAsync();
    }
}
