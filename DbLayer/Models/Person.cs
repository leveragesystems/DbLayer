using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Person : Entity<Guid> {
    [Validate(RegexClass.Required, "Please provide an Id")]
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public Party party { get; set; }

  }
}

