using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U3_constructor_y_destructor
{
    class MyObject
    {
        private int id;
        public string Name { get; private set; }

        public MyObject(int _id, string _name)
        {
            id = _id;
            Name = _name;
            Console.WriteLine($"Constructor of Object called for {Name}");
        }

        ~MyObject()
        {
            Console.WriteLine($"Destructor of Object called for {Name}");
        }
    }

    class Container
    {
        private MyObject obj;

        public Container(int id, string name)
        {
            obj = new MyObject(id, name);
            Console.WriteLine($"Constructor of Container called for {obj.Name}");
        }

        ~Container()
        {
            Console.WriteLine($"Destructor of Container called for {obj.Name}");
        }

    }
}
