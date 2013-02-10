using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Resource {
    public string Name { get; set; }

    public string Value { get; set; }
    public List<Validation> Validations { get; set; }
  }
}
