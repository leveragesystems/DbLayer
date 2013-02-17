using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  [System.AttributeUsage(System.AttributeTargets.Property,
                       AllowMultiple = true)]  // multiuse attribute
  public class ValidateAttribute : Attribute {
    public string Regex { get; set; }
    public string Message { get; set; }

    public ValidateAttribute(string regex) {
      Regex = regex;
    }
    public ValidateAttribute(string regex, string message) {
      Regex = regex;
      Message = message;
    }

  }
}
