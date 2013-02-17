using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DbLayer.Repositories {
  public interface IRepository<T,U> : IQueryable<T> where T:Entity<U> {
    bool Create<T>(T entity);
    bool Delete<T>(T entity);
    T Update<T>(string id, T entity);
    IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
    IEnumerable<T> Get();
    T Get(Guid id);
  }
}