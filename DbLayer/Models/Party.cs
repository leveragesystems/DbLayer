using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Party : Entity<int> {
    [Validate(RegexClass.Required, "Please provide an Id")]
    public int PartyId { get; set; }
  }
}
