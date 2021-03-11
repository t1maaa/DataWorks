namespace DataWorks.Tests
{
    public interface IDoubleLinkedList<T>
    {
        IDoubleLinkedListNode<T> First { get; set; }
        IDoubleLinkedListNode<T> Last { get; set; }
        void Reverse();
        void AddFirst(T value);
        void AddLast(T value);
    }
}