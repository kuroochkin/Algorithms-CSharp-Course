using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStruct_Lib.Tests
{
    [TestFixture]
    public class SinglyLinkedListTests
    {
        private SinglyLinkedList<int> _list;

        [SetUp]
        public void Init()
        {
            _list = new SinglyLinkedList<int>();
        }

        [Test]
        public void CreateEmptyList_CorrectState()
        {
            Assert.IsTrue(_list.IsEmpty);
            Assert.IsNull(_list.Head);
            Assert.IsNull(_list.Tail);
        }

        [Test]
        public void AddFirst_and_AddLast_OneItem_CorrectState()
        {
            _list.AddFirst(1);

            CheckStateWithSingleNode(_list);

            _list.RemoveFirst();

            _list.AddLast(1);

            CheckStateWithSingleNode(_list);
        }

        [Test]
        public void AddRemoveToGetToStateWithSingleNode_CorrectState()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);
            _list.RemoveFirst();

            CheckStateWithSingleNode(_list);

            _list.AddFirst(2);
            _list.RemoveLast();

            CheckStateWithSingleNode(_list);
        }

        [Test]
        public void RemoveFirst_EmptyList_Throws()
        {
            Assert.Throws<InvalidOperationException>(() => _list.RemoveLast());
        }

        private void CheckStateWithSingleNode(SinglyLinkedList<int> list)
        {
            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.IsEmpty);
            Assert.AreSame(list.Head, list.Tail);
        }
    }
}
