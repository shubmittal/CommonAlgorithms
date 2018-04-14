using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public Node<T> current;

   

        public void push( T data)
        {
            Node<T> newnode = new Node<T>();
            newnode.data = data;
            newnode.next = null;
            if (head == null)
            {
                head = newnode;
            }
            else
            {
                current.next = newnode;
            }
            
            current = newnode;
        }

        public Node<T> pop()
        {
            if(head == current)
            {
                Console.WriteLine("Sorry!! Nothing to pop");
                return null;
            }
            Console.WriteLine($"Popping {current.data}");
            var temppointer = head;
            var prev = head;
             
            while(temppointer != current)
            {
                prev = temppointer;
                temppointer = temppointer.next;                
            }          

            prev.next = null;
            current = prev;

            return temppointer;

        }

        public void print()
        {
            if(head.next == null)
            {
                Console.WriteLine("Nothing to print");
                return;
            }
            var temp = head;

            while(temp != null)
            {
                Console.WriteLine($"{temp.data}");
                temp = temp.next;
            }
        }

        public bool removehead()
        {
            if (head == null)
            {
                throw new Exception("Linked list is null and head cannot be moved");
                            }
            if( head == current)
            {
                Console.WriteLine("Cannot proceed as head cannot be moved to any next element");
                return false;
            }
            head = head.next;
            return true;
        }
    }
       
}
