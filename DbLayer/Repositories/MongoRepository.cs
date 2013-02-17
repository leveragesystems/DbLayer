using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace DbLayer.Repositories {
  public sealed class MongoRepository<T, U> : IRepository<T, U> where T : Entity<U> {

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

    //protected T DataTable;

    //public MongoRepository(string connection) {

    //  if (string.IsNullOrWhiteSpace(connection)) {
    //    connection = "mongodb://localhost:27017";
    //  }
    //  var db = MongoDatabase.Create(connection);
    //  MongoCollection<T> collection = _database.GetCollection<T>(typeof(T).Name + "s");

    //}

    //public IEnumerable<T> GetAllContacts() {
    //  return _contacts.FindAll();
    //}

    //public Contact GetContact(string id) {
    //  IMongoQuery query = Query.EQ("_id", id);
    //  return _contacts.Find(query).FirstOrDefault();
    //}

    //public Contact AddContact(Contact item) {
    //  item.Id = ObjectId.GenerateNewId().ToString();
    //  item.LastModified = DateTime.UtcNow;
    //  _contacts.Insert(item);
    //  return item;
    //}

    //public bool RemoveContact(string id) {
    //  IMongoQuery query = Query.EQ("_id", id);
    //  SafeModeResult result = _contacts.Remove(query);
    //  return result.DocumentsAffected == 1;
    //}

    //public bool UpdateContact(string id, Contact item) {
    //  IMongoQuery query = Query.EQ("_id", id);
    //  item.LastModified = DateTime.UtcNow;
    //  IMongoUpdate update = Update
    //      .Set("Email", item.Email)
    //      .Set("LastModified", DateTime.UtcNow)
    //      .Set("Name", item.Name)
    //      .Set("Phone", item.Phone);
    //  SafeModeResult result = _contacts.Update(query, update);
    //  return result.UpdatedExisting;
    //} 

 
  }
}