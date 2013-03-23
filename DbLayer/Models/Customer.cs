using System;

namespace DbLayer.Models {
  public class Customer : Entity<int> {
    
    // Why this Id and not use the Entity<int> Id?
    [Validate(RegexClass.Required, "Please provide an Id")]
    public int CustomersId { get; set; }

    [Validate(RegexClass.Required, "Please Provide a title")]
    public string Title { get; set; }

    public DateTime Created { get; set; }

    public string Name { get; set; }

    [Validate(RegexClass.Email, "Please specify a valid email")]
    public string Email { get; set; }
  }
}
