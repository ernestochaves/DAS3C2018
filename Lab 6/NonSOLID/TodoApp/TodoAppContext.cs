
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    public class TodoAppContext : DbContext
    {
        public TodoAppContext(DbContextOptions options) : base(options)
        {
        }
        public TodoAppContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoApp;Trusted_Connection=True;");
        }

        public DbSet<TodoItem> Items { get; set; }
    }
}
