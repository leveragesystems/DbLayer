using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace DbLayer.Repositories  {
  public class MongoRepository<T, U> : IRepository<T, U> where T : Entity<U> {

     public MongoCollection<T> Collection {
      get {
        var db = MongoDatabase.Create(this.ConnectionString);
        return db.GetCollection<T>(typeof(T).Name + "s");
      }
    }

    private IQueryable<T> Queryable {
      get {
        return this.Collection.FindAll().AsQueryable<T>();
      }
    }

    #region IRepository<T,U> Implementation

    public string ConnectionString { get; set; }

    public T Update<T>(string id, T entity) {
      throw new NotImplementedException();
    }

    public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate) {
      throw new NotImplementedException();
    }

    public IEnumerable<T> Get() {
      return this.Collection.FindAll();
    }

    public T Get(Guid id) {
      return this.Collection.Find(Query.EQ("_id", id)).First<T>();
    }

    public bool Delete<T>(T entity) {
      try {
        var id = (entity as Entity<Guid>).Id;
        this.Collection.Remove(Query.EQ("_id", id));
        return true;
      } catch {
        return false;
      }
    }
    public bool Create<T>(T entity) {
      try {
        this.Collection.Save<T>(entity);
        return true;
      } catch {
        return false;
      }
    }

    #endregion

    #region IQueryable<T> Implementation

    public IEnumerator<T> GetEnumerator() {
      return this.Queryable.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return this.Queryable.GetEnumerator();
    }

    public Type ElementType {
      get {
        return this.Queryable.ElementType;
      }
    }

    public Expression Expression {
      get {
        return this.Queryable.Expression;
      }
    }

    public IQueryProvider Provider {
      get {
        return this.Queryable.Provider;
      }
    }

    #endregion
 }
}