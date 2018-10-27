
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TodoAppContext : DbContext, ITodoAppContext
    {
        public TodoAppContext(DbContextOptions options) : base(options)
        {

        }
        public TodoAppContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=405-Prof;Database=ToDoApp;Trusted_Connection=True;");
            }
        }

        public DbSet<TodoItem> Items { get; set; }
    }
}
