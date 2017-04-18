using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomCollection
{
    public class MyCollection<T> : IList<T> where T : struct
    {
		private T[] _elements;
        private int _counter;

		public MyCollection(int size)
		{
			_elements = new T[size];
		}

        /// <summary>
        /// Adds new element to the colection
        /// </summary>
        /// <param name="item">new element added to the collection</param>
        public void Add(T item)
        {
            if (_counter == _elements.Length)
            {
                Array.Resize(ref _elements, _elements.Length * 2);
            }
            _elements[_counter++] = item;
        }


        /// <summary>
        /// Removes an element from the collection
        /// </summary>
        /// <param name="item">element to remove from the collection</param>
        public void Remove(T item)
        {
            int index = Array.IndexOf(_elements, item);
            if (index != -1)
            {
                int size = _elements.Length;
                T[] newArray = new T[size - 1];
                for (int i = 0, j = 0; i < size; i++, j++)
                {
                    if (i == index)
                    {
                        i++;
                        _counter--;
                    }

                    newArray[j] = _elements[i];
                }
                _elements = newArray;
            }
        }

        /// <summary>
        /// Searchs for an element in the collection
        /// </summary>
        /// <param name="item">element to find</param>
        /// <returns>does the collection contain the element</returns>
        public bool Contains(T item)
        {
            //option 1
            return Array.Exists(_elements, element => element.Equals(item));

            //option 2
            //return Array.IndexOf(_elements, item) != -1;
        }

        /// <summary>
        /// Returns a size of the collection
        /// </summary>
        /// <returns>current size</returns>
        public int Count()
        {
            return _counter;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _counter; i++)
            {
                yield return _elements[i];
            }
        }

		public int IndexOf(T item)
		{
			throw new NotImplementedException();
		}

		public void Insert(int index, T item)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		public T this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			//throw new NotImplementedException();
		}

		int ICollection<T>.Count
		{
			get { return _counter; }
		}

		public bool IsReadOnly
		{
			get { throw new NotImplementedException(); }
		}

		bool ICollection<T>.Remove(T item)
		{
			throw new NotImplementedException();
		}
	}
}
