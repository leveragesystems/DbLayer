using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Customers {
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
