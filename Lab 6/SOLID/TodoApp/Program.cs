using Entities;
using Services;
using System;

namespace TodoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            bool exit = false;
            while (!exit)
            {
                //Print Menu
                Console.WriteLine();
                Console.WriteLine("    ---MENU---");
                Console.WriteLine("    1. List my items");
                Console.WriteLine("    2. Add new item");
                Console.WriteLine("    3. Exit");
                Console.WriteLine();
                string option = Console.ReadLine();
                int parsedOption;
                //Validate the option: not empty, and a valid integer
                if (!string.IsNullOrEmpty(option) && int.TryParse(option, out parsedOption))
                {
                    var context = new TodoAppContext();
                    TodoItemsService service = new TodoItemsService(context);
                    switch (parsedOption)
                    {
                        case 1:
                            //Accesing the data

                            Console.WriteLine("   We have this items:");
                            var items = service.GetItems();
                            foreach (var item in items)
                            {
                                Console.WriteLine("    {Id:" + item.Id + ", Date:" + item.DateTime.ToShortTimeString() + ", Name:" + item.Name + "}");
                            }
                            break;
                        case 2:
                            Console.WriteLine("    Please provide a name for the item:");
                            string newItemName = Console.ReadLine();

                            service.Add(new TodoItem() { Name = newItemName });

                            Console.WriteLine("    Item added successfully!");
                            break;
                        case 3:
                            exit = true;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    exit = true;
                }


            }
        }
    }
}
