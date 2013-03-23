using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  class RoleType {
    [Validate(RegexClass.Required, "Please provide an Id")]
    public int RoleTypeId { get; set; }
    public String Description { get; set; }
  }
}
