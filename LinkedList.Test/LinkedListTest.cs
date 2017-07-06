using Sample.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace LinkedList.Test
{
    [TestClass]
    public class LinkedListTest
    {
        #region ADDFIRST
        [TestMethod]
        public void AddFirst_Test()
        {
            LinkedList<int> linkList = new LinkedList<int>();
            linkList.AddFirst(10);
            Assert.AreEqual(10, linkList.Head.Value);
        }
        [TestMethod]
        public void AddFirst_AddingNodeToExistingNode()
        {
            LinkedList<int> linkList = new LinkedList<int>();

            //Two nodes added
            linkList.Head = new Node<int>() { Value = 10 };
            linkList.Head.Next = new Node<int> { Value = 20 };

            linkList.AddFirst(5);
            Assert.AreEqual(5, linkList.Head.Value);
        }
        #endregion

        #region AddBeforeNode
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddBeforeNode_BlankList()
        {
            LinkedList<int> linkList = new LinkedList<int>();

            //Two nodes added
            linkList.AddBeforeNode(10, 5);

        }

        [TestMethod]
        public void AddBeforeNode_OnlyHeadNodeList()
        {
            LinkedList<int> linkList = new LinkedList<int>();

            //Two nodes added
            linkList.Head = new Node<int>() { Value = 10 };

            linkList.AddBeforeNode(10, 5);
            Assert.AreEqual(5, linkList.Head.Value);
        }

        [TestMethod]
        public void AddBeforeNode_FullList()
        {
            LinkedList<int> linkList = new LinkedList<int>();

            //Two nodes added
            linkList.Head = new Node<int>() { Value = 10 };
            linkList.Head.Next = new Node<int> { Value = 20 };
            linkList.Head.Next.Next = new Node<int> { Value = 30 };
            linkList.AddBeforeNode(20, 15);
            Assert.AreEqual(15, linkList.Head.Next.Value);
        }

        [TestMethod]
        public void AddBeforeNode_Tail()
        {
            LinkedList<int> linkList = new LinkedList<int>();

            //Two nodes added
            linkList.Head = new Node<int>() { Value = 10 };
            linkList.Head.Next = new Node<int> { Value = 20 };
            linkList.Head.Next.Next = new Node<int> { Value = 30 };
            linkList.AddBeforeNode(30, 15);
            Assert.AreEqual(15, linkList.Head.Next.Next.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddBeforeNode_NodeDoesNotExits()
        {
            LinkedList<int> linkList = new LinkedList<int>();

            //Two nodes added
            linkList.Head = new Node<int>() { Value = 10 };
            linkList.Head.Next = new Node<int> { Value = 20 };
            linkList.Head.Next.Next = new Node<int> { Value = 30 };
            linkList.AddBeforeNode(50, 15);

        }
        #endregion

    }
    
}
