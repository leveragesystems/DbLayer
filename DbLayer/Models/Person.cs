using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Person : Entity<Guid> {
    public string FirstName { get; set; }

    public int Age { get; set; }
  }
}

