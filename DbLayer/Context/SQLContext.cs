using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLayer.Models;

namespace DbLayer.Context {
  public class SQLContext : DbContext {
    public SQLContext()
      : base("Name=DefaultConnection")
{
}
    public DbSet<ToDoList> ToDoLists { get; set; }
    public DbSet<Customers> Customers { get; set; }

    public DbSet<Person> People { get; set; }
  }
}