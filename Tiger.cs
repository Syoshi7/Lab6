using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Tiger: IMeowkee
    {
        private readonly string Name;

        public Tiger(string name)
        {
            Name = name;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}: pррмяу?");
        }
    }
}
