using System;

namespace DbLayer.Models {

  public class ToDoList :Entity<Guid>{

    [Validate(RegexClass.Required, "Please Provide a Title")]
    public string Title { get; set; }
    
    public DateTime DueDate { get; set; }

    public bool Completed { get; set; }
  }
}
