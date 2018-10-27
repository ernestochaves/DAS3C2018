using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class TodoItemsService
    {
        ITodoAppContext dbContext;

        public TodoItemsService(ITodoAppContext dbContext) {
            this.dbContext = dbContext;
        }

        public List<TodoItem> GetItems()
        {
            return dbContext.Items.ToList();
        }

        public TodoItem Add(TodoItem newItem)
        {
            newItem.DateTime = DateTime.UtcNow;

            //Adding the data
            dbContext.Items.Add(newItem);
            dbContext.SaveChanges();

            return newItem;
        }
    }
}
