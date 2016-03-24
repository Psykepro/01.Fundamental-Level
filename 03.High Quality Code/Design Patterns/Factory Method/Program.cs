using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Example
    {
        static void Main()
        {
            // constructors call Factory Method
            File[] Files = new File[2];
            Files[0] = new Furniture();
            Files[1] = new Crokery();
            foreach (File File in Files)
            {
                Console.WriteLine("\n" + File.GetType().Name + "--");
                foreach (Items Items in File.Itemss)
                {
                    Console.WriteLine(" " + Items.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }
    // The 'Product' abstract class
    abstract class Items
    { }
    // ConcreteProduct classes
    class SofasetItems : Items
    { }
    class PlatesItems : Items
    { }
    class BedItems : Items
    { }
    class GlassesItems : Items
    { }
    class TeasetItems : Items
    { }
    class BowlsItems : Items
    { }
    class DiningItems : Items
    { }
    abstract class File
    {
        private List<Items> _Itemss = new List<Items>();
        // Constructor calls abstract Factory method
        public File()
        {
            this.CreateItemss();
        }
        public List<Items> Itemss
        {
            get { return _Itemss; }
        }
        // Factory Method
        public abstract void CreateItemss();
    }
    class Furniture : File
    {
        // Factory Method implementation
        public override void CreateItemss()
        {
            Itemss.Add(new SofasetItems());
            Itemss.Add(new BedItems());
            Itemss.Add(new DiningItems());
        }
    }
    class Crokery : File
    {
        public override void CreateItemss()
        {
            Itemss.Add(new PlatesItems());
            Itemss.Add(new GlassesItems());
            Itemss.Add(new TeasetItems());
            Itemss.Add(new BowlsItems());
        }
    }
}
