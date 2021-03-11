using System.Text;

namespace DataWorks.Tests
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        public IDoubleLinkedListNode<T> First { get; set; }
        public IDoubleLinkedListNode<T> Last { get; set; }

        public DoubleLinkedList()
        {
            First = null;
            Last = null;
        }
        public void Reverse()
        {
            if(First is null || Last is null) return;
            if(First == Last) return;
            
            var current = First;
            IDoubleLinkedListNode<T> next;
            do
            {
                next = current.Next;
                current.Next = current.Prev;
                current.Prev = next;
                
                if(!(next is null))
                    current = next;
            } while (next != null);

            Last = First;
            First = current;
        }

        public void AddFirst(T value)
        {
            var tmp = new DoubleLinkedListNode<T>
            {
                Next = null,
                Prev = null,
                Value = value
            };
            if (First is null && Last is null)
            {
                First = tmp;
                Last = tmp;
            }
            else
            {
                tmp.Next = First;
                First.Prev = tmp;
                First = tmp;
            }
        }

        public void AddLast(T value)
        {
            var tmp = new DoubleLinkedListNode<T>
            {
                Next = null,
                Prev = null,
                Value = value
            };
            if (First is null && Last is null)
            {
                First = tmp;
                Last = tmp;
            }
            else
            {
                Last.Next = tmp;
                tmp.Prev = Last;
                Last = tmp;
            }
        }

        public override string ToString()
        {
            if (First is null || Last is null) return "";
            var current = First;
            var sb = new StringBuilder();
            
            do
            {
                sb.Append($"{current.Value}, ");
                current = current.Next;
            } while (current != null);

            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}