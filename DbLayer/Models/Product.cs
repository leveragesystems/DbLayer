using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  class Product {
    [Validate(RegexClass.Required, "Please provide an Id")]
    public int ProductId { get; set; }
    public string Name { get; set; }
  }
}
