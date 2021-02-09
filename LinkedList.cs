using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private Node Head;
        private Node Null;

        public LinkedList(int firstItem)
        {
            Head = new Node(firstItem);
            Null = new Node(int.MinValue);
            Head.AddItem(Null);
        }

        public void AddItem(int nextValue)
        {
            Node newNode = new Node(nextValue);
            Node previousNode = Head;

            if (previousNode.Data != int.MinValue)
            {
                if (previousNode.Data < newNode.Data)
                {
                    while (newNode.Data > previousNode.Pointer.Data && previousNode.Pointer.Data != int.MinValue)
                    {
                        previousNode = previousNode.Pointer;
                    }

                    newNode.AddItem(previousNode.Pointer);
                    previousNode.AddItem(newNode);
                }
                else
                {
                    newNode.AddItem(Head);
                    Head = newNode;
                }
            }
            else
            {
                newNode.AddItem(Null);
                Head = newNode;
            }
        }

        public void DeleteItem(int dataToDelete)
        {
            Node temp = Head;

            if (temp.Data == dataToDelete)
            {
                if (Head.Pointer.Data == int.MinValue)
                {
                    Node newHead = new Node(int.MinValue);
                    newHead.AddItem(Null);
                    Head = newHead;
                }
                else
                {
                    Head = Head.Pointer;
                }
            }
            else
            {
                while (temp.Pointer.Data != dataToDelete && temp.Pointer.Data != int.MinValue)
                {
                    temp = temp.Pointer;
                }

                if (temp.Pointer.Data == dataToDelete)
                {
                    temp.RemoveNext();
                }
            }
        }

        public void PrintList()
        {
            Head.PrintList();
        }

        public bool IsEmpty()
        {
            bool output = false;

            if(Head.Data == int.MinValue)
            {
                output = true;
            }

            return output;
        }
    }
}
