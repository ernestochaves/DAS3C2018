using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GreetingsService : IGreetingsService
    {
        public string GetGreeting()
        {
            return "Hello";
        }
    }
}
