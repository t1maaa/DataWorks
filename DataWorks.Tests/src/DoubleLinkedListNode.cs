namespace DataWorks.Tests
{
    public class DoubleLinkedListNode<T> : IDoubleLinkedListNode<T>
    {
        public T Value { get; set; }
        public IDoubleLinkedListNode<T> Next { get; set; }
        public IDoubleLinkedListNode<T> Prev { get; set; }
    }
}