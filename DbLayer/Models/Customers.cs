using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Customers {
    [Require(true)]
    public int CustomersId { get; set; }

    [Require(true)]
    public string Title { get; set; }

    public DateTime Created { get; set; }

    public string Name { get; set; }
  }
}
