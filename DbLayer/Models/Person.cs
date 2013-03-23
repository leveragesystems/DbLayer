using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Person : Entity<int> {
    [Validate(RegexClass.Required, "Please provide an Id")]
    public int PersonId { get; set; }
    [Validate(RegexClass.Required, "Please Provide a title")]
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; }
    [Validate(RegexClass.Email, "Please specify a valid email")]
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public Party party { get; set; }

  }
}

