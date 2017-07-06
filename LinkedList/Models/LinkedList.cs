using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class LinkedList<T>
    {

        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;
            if (Head == null)
            {
                Head = Tail = newNode;
            }

            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

        }
        public void AddFirst(Node<T> newNode)
        {

            if (Head == null)
            {
                Head = Tail = newNode;
            }

            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

        }

        //public void AddBeforeNode( T existingNodevalue,T newNodeValue)
        //{
        //    if (Head == null)
        //    {
        //        throw new Exception("List is empty");
        //    }
        //    Node<T> currentNode = Head;
        //    Node<T> currentPrevNode = null;
        //    while (currentNode != node)
        //    {
        //        if (currentNode == Tail)
        //        {
        //            throw new Exception("node does not exists in the linked list");
        //        }
        //        currentPrevNode = currentNode;
        //        currentNode = currentNode.Next;
        //    }
        //    currentPrevNode.Next = newNode;
        //    newNode.Next = currentNode;

        //}
        public void AddAfterNode(T existingNodevalue, T newNodeValue)
        {
        }
        public void RemoveFirst(T existingNodevalue, T newNodeValue)
        {

        }


        public void RemoveAt(int n)
        {
            if (Head == null)
            {
                throw new NullReferenceException("List is blank");
            }

            Node<T> currentNode = Head;
            Node<T> previousCurrentNode = null;

            if (n == 1)
            {
                Head = Head.Next;
                return;
            }
            int i = 0;
            while (i < n - 1)
            {
                previousCurrentNode = currentNode;
                currentNode = currentNode.Next;
                i++;
            }
            if (currentNode.Next == null)
            {
                previousCurrentNode.Next = null;
            }
            else
            {
                previousCurrentNode.Next = currentNode.Next;
            }

        }
        public void RemoveLast(T existingNodevalue, T newNodeValue)
        {
        }
        public void RemoveNode(T value)
        {
        }
        public void AddBeforeNode(T existingNodeValue, T newNodeValue)
        {
            Node<T> newNode = new Node<T>() { Value = newNodeValue };

            Node<T> currentNode = Head;
            Node<T> previousNode = null;

            if (existingNodeValue.Equals(Head.Value))
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                while (!currentNode.Value.Equals(existingNodeValue))
                {
                    if (currentNode.Next == null)
                    {
                        throw new NullReferenceException("Node not found");
                    }
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
                previousNode.Next = newNode;
                newNode.Next = currentNode;

            }



        }


        public IEnumerable<T> GetNodes()
        {
            throw new NotImplementedException();
        }
    }
}
