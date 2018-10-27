using System;
using System.Collections.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using TodoApp;

namespace TodoAppTests
{
    [TestClass]
    public class TodoItemsTests
    {
        [TestMethod]
        public void ListItemsShouldNotThrow()
        {
            var itemsService = GetService("ListItemsShouldNotThrow");

            itemsService.GetItems();
        }

        [TestMethod]
        public void ListItemsShouldNotBeNullOrEmpty()
        {
            var itemsService = GetService("ListItemsShouldNotBeNullOrEmpty");

            var x = itemsService.GetItems();
            Assert.AreNotEqual(x.Count, 0);
        }

        [TestMethod]
        public void ItemsAddedShouldIncreaseSize()
        {
            var itemsService = GetService("ItemsAddedShouldIncreaseSize");

            var initialCount = itemsService.GetItems().Count;
            itemsService.Add(new Entities.TodoItem() { Name = "SomeName" });
            var finalCount = itemsService.GetItems().Count;
            Assert.AreEqual(initialCount + 1, finalCount);

        }

        private TodoItemsService GetService(string fakeDatabaseName)
        {

            var options = new DbContextOptionsBuilder<TodoAppContext>()
               .UseInMemoryDatabase(databaseName: fakeDatabaseName)
               .Options;
            //EF Core uses a simplier approach to an in-memmory database
            var context = new TodoAppContext(options);
            TodoItemsService itemsService = new TodoItemsService(context);

            return itemsService;
        }


    }
}
