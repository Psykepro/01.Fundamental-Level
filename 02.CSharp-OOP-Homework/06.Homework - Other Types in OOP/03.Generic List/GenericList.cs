using System;
using System.Linq;



namespace GenericList
{
    [VersionAttribute(1,0)]
    internal class GenericList<T> where T : IComparable
    {
        

        private const int DefaulthCapacity = 16;
        private T[] elements;
        private int currentIndex;

        public GenericList(int capacity = DefaulthCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        public void Add(T element)
        {

            if (this.currentIndex == this.elements.Length)
            {
                Resize();
            }
            this.elements[currentIndex] = element;
            this.currentIndex++;
        }

        //Accessing by index
        public T this[int index]
        {

            get
            {
                if (index > currentIndex || index < 0)
                    throw new ArgumentOutOfRangeException("index", "There is no such element!");
                return this.elements[index];
            }
        }

        public void Remove(int index)
        {
            if (index > this.currentIndex)
            {
                throw new InvalidOperationException("The index must be smaller than the lenght!");
            }
            this.elements[index] = default(T);
            this.currentIndex--;
            ResizeAfterRemove(index);
        }

        public void Insert(int index, T newElement)
        {
            if (index >= this.currentIndex)
                throw new ArgumentOutOfRangeException("index", "The index is bigger than the array length!");

            T oldElement = this.elements[index];
            this.elements[index] = newElement;
            for (int i = index + 1; i <= this.currentIndex; i++)
            {
                T temp = elements[i];
                this.elements[i] = oldElement;
                oldElement = temp;
            }
            this.Add(oldElement);
        }

        public void Clear()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                this.elements[i] = default(T);
            }
            this.currentIndex = 0;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
                
            }
            return false;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i <= this.currentIndex; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (max.CompareTo(this.elements[i]) == -1)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

        public int Count()
        {
            return this.currentIndex + 1;
        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (min.CompareTo(this.elements[i]) == 1)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        //Resizing the array after removing element at the given index                        
        private void ResizeAfterRemove(int index)
        {
            for (int i = index; i < this.elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[currentIndex] = default(T);
        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length*2];
            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

        public override string ToString()
        {
            if (this.currentIndex==0)
            {
                string empty="empty";
                return empty;
            }
            return string.Join(", ", this.elements.Take(this.currentIndex));
        }
        public void PrintVersion()
        {
            Type type = typeof (GenericList<T>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (var attribute in allAttributes)
            {
                if (attribute is VersionAttribute)
                {
                    VersionAttribute temp= attribute as VersionAttribute;
                    Console.WriteLine("Generic List Ver : {0}.{1}",temp.Major,temp.Minor);
                }
            }
        }
    }
}                                                        
                                                         
                                                         
                                                         
                                                         
                                                         
                                                         
                                                         
                                                         