using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class Person : Entity<int> {
    public string FirstName { get; set; }

    public int Age { get; set; }
  }
}

