using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {
  public class RegexClass {
    public const string Required = @"/^[\s\t\r\n]*\S+/ig";
    public const string Email = @"/^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
    public const string ValidNumber = @"[0-9]+$";
  }
}
