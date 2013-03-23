using System;

namespace DbLayer.Models {
  public class Customer : Entity<int> {
    
    // Why this Id and not use the Entity<int> Id?
    [Validate(RegexClass.Required, "Please provide an Id")]
    public int CustomersId { get; set; }

    public RoleType roleType;
    public Party party;

  }
}
