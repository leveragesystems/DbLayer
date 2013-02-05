using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  [System.AttributeUsage(System.AttributeTargets.Property,
                       AllowMultiple = true)]  // multiuse attribute
  public class Require : Attribute {
    public bool Required { get; set; }

    public Require(bool require) {
      Required = require;
    }

  }
}
