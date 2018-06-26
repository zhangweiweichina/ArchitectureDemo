using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pls.Iterator.Implementation
{
    public class PsCollection: IEnumerable
    {
        public Node _first = null;

        public IEnumerator GetEnumerator()
        {
            return new PsEnumerator(this);
        }

        public void Add(object ob)
        {
            if (_first == null)
            {
                _first = new Node() { Value = ob };
            }
            else
            {
                Node last = _first;
                while (last.Next != null)
                    last = last.Next;
                last.Next = new Node() { Value = ob };
            }
        }
    }

    public class PsEnumerator : IEnumerator
    {
        private Node _current = null;
        private PsCollection _collection;
        public PsEnumerator(PsCollection collection)
        {
            _collection = collection;
        }

        public object Current
        {
            get
            {
                if (_current != null)
                    return _current.Value;
                else
                    return null;
            }
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = _collection._first;
                return true;
            }
            else if (_current.Next != null)
            {
                _current = _current.Next;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _current = null;
        }
    }

    public class Node
    {
        public Node Next { get; set; }
        public object Value { get; set; }
    }
}
