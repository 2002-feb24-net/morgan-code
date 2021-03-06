﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // behaves like a list<T> but keep itself sorted

    // you declare a class' type parameter with <(name)> right after the class name
    // after the "where" come type constraints
    // e.g. class, struct, any specific type
    class SortedSequence<T> : IEnumerable<T> where T : class, new()
    {
        List<T> _list = new List<T>();

        // let's say this class always starts out with one element in it which will be what you get from calling the default ctor on T
        public SortedSequence()
        {
            Add(new T());
        }

        public void Add(T item)
        {
            _list.Add(item);
            _list.Sort();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        // implement indexer operator []
        public T this[int i] { 
            get => _list[i];
            set => _list[i] = value; 
        }
    }
}
