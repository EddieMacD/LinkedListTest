using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(5);

            list.AddItem(3);
            list.AddItem(645);
            list.AddItem(335);

            list.PrintList();

            list.DeleteItem(3);
            list.DeleteItem(645);
            list.AddItem(123);
            list.AddItem(456);
            list.AddItem(789);

            list.PrintList();

            list.DeleteItem(789);
            list.DeleteItem(123);
            list.DeleteItem(456);
            list.DeleteItem(5);
            list.DeleteItem(335);

            list.PrintList();

            list.AddItem(4856);
            list.AddItem(5433);
            list.AddItem(7);

            list.PrintList();

            Console.ReadLine();
        }
    }
}
