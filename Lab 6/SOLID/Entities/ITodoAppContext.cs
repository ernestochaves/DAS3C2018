using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface ITodoAppContext
    {
        DbSet<TodoItem> Items { get; set; }

        int SaveChanges();
    }
}
