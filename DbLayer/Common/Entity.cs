using DbLayer.Models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

public abstract class Entity<U> {
  [Validate(RegexClass.Required, "Please provide the Id")]
  public U Id { get; set; }
}