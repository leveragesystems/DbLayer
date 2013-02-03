using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {

  public class ToDoList {

    //["hidden"]
    public int ToDoListId { get; set; }

    //["Require"]
    public string Title { get; set; }

    public DateTime DueDate { get; set; }

    public bool Completed { get; set; }
  }
}
