using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using Xunit;

namespace DataWorks.Tests
{
    public class DoubleLinkedListTests
    {
        private DoubleLinkedList<int> list = new DoubleLinkedList<int>();

        [Fact]
        public void AddFirst()
        {
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            Assert.Equal("3, 2, 1", list.ToString());
        }

        [Fact]
        public void AddLast()
        {
            list.AddLast(0);
            list.AddLast(-1);
            list.AddLast(-2);
            Assert.Equal("0, -1, -2", list.ToString());
        }

        [Fact]
        public void Reverse()
        {
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddLast(0);
            list.AddLast(-1);
            list.AddLast(-2);
            
            list.Reverse();
            Assert.Equal("-2, -1, 0, 1, 2, 3", list.ToString());
            
            list.Reverse();
            Assert.Equal("3, 2, 1, 0, -1, -2", list.ToString());
        }
    }
}