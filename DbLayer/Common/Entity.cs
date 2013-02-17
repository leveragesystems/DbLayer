
using DbLayer.Models;
public abstract class Entity<U> {
	[Validate(RegexClass.Required, "Please provide the Id")]
  public U Id { get; set; }
}