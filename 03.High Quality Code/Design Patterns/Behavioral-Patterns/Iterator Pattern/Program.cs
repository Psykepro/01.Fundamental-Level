namespace Iterator
{
    using System;
    using System.Collections;

    /// <summary>
    /// MainApp startup class for Real-World 
    /// Iterator Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            // Build a collection
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator
            Iterator iterator = new Iterator(collection);

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// A collection item
    /// </summary>
    internal class Item
    {
        // Constructor
        public Item(string name)
        {
            this.Name = name;
        }

        // Gets name
        public string Name { get; private set; }
    }

    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    internal interface IAbstractCollection
    {
        Iterator CreateIterator();
    }

    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    internal class Collection : IAbstractCollection
    {
        private readonly ArrayList _items = new ArrayList();

        // Gets item count
        public int Count
        {
            get
            {
                return this._items.Count;
            }
        }

        // Indexer
        public object this[int index]
        {
            get
            {
                return this._items[index];
            }

            set
            {
                this._items.Add(value);
            }
        }

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    internal interface IAbstractIterator
    {
        bool IsDone { get; }

        Item CurrentItem { get; }

        Item First();

        Item Next();
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    internal class Iterator : IAbstractIterator
    {
        private readonly Collection _collection;

        private int _current;

        private int _step = 1;

        // Constructor
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        // Gets or sets stepsize
        public int Step
        {
            get
            {
                return this._step;
            }

            set
            {
                this._step = value;
            }
        }

        // Gets first item
        public Item First()
        {
            this._current = 0;
            return this._collection[this._current] as Item;
        }

        // Gets next item
        public Item Next()
        {
            this._current += this._step;
            if (!this.IsDone)
            {
                return this._collection[this._current] as Item;
            }

            return null;
        }

        // Gets current iterator item
        public Item CurrentItem
        {
            get
            {
                return this._collection[this._current] as Item;
            }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get
            {
                return this._current >= this._collection.Count;
            }
        }
    }
}