using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer.Models {

  public class ToDoList {

    [Validate(RegexClass.Required, "Please provide the Id")]
    public int ToDoListId { get; set; }

    [Validate(RegexClass.Required, "Please Provide a Title")]
    public string Title { get; set; }
    
    public DateTime DueDate { get; set; }

    public bool Completed { get; set; }
  }
}
