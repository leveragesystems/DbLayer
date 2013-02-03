using System;
using DbLayer.Context;
using DbLayer.Models;
using System.Data.Entity;
using System.Linq;

class Program {
  static void Main(string[] args) {
    using (var db = new SQLContext()) {
      // Create and save a new Blog
      Console.Write("Enter a name for a new Blog: ");
      var name = Console.ReadLine();

      var toDoList = new ToDoList { Title = name };
      db.ToDoLists.Add(toDoList);
      db.SaveChanges();

      // Display all Blogs from the database
      var query = from b in db.ToDoLists
                  orderby b.Title
                  select b;

      Console.WriteLine("All blogs in the database:");
      foreach (var item in query) {
        Console.WriteLine(item.Title);
      }

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}