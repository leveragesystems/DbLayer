using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Resource {
    public string Property { get; set; }

    public string Type { get; set; }
    public List<Validation> Validations { get; set; }
  }
}
