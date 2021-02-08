using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int Data { get; private set; }
        public Node Pointer { get; private set; }

        public Node(int data)
        {
            Data = data;
        }

        public void AddItem(Node pointer)
        {
            Pointer = pointer;
        }

        public void RemoveNext()
        {
            try
            {
                Pointer = Pointer.Pointer;
            }
            catch
            {
                //No items in list
            }
        }

        public void PrintList()
        {
            if (Data != int.MinValue)
            {
                Console.Write(Data + "    ");
                Pointer.PrintList();
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
