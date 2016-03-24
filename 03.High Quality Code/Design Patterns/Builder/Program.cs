using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Celebrities
{
    class Program
    {
        public static void Main()
        {
            BollywoodCelebrities Celebrities;
            Nominated Nominated = new Nominated();
            Celebrities = new KaterinaCelebrities();
            Nominated.Construct(Celebrities);
            Celebrities.Bollywood.Show();
            Celebrities = new ShahrukhCelebrities();
            Nominated.Construct(Celebrities);
            Celebrities.Bollywood.Show();
            Celebrities = new AshwaryaCelebrities();
            Nominated.Construct(Celebrities);
            Celebrities.Bollywood.Show();
            Console.ReadKey();
        }
    }
    class Nominated
    {
        public void Construct(BollywoodCelebrities bollywoodCelebrities)
        {
            bollywoodCelebrities.Height();
            bollywoodCelebrities.RecentMovie();
            bollywoodCelebrities.Awards();
        }
    }
    abstract class BollywoodCelebrities
    {
        protected Bollywood bollywood;
        public Bollywood Bollywood
        {
            get { return bollywood; }
        }
        public abstract void Height();
        public abstract void RecentMovie();
        public abstract void Awards();
    }
    class AshwaryaCelebrities : BollywoodCelebrities
    {
        public AshwaryaCelebrities()
        {
            bollywood = new Bollywood("Ashwarya");
        }
        public override void Height()
        {
            bollywood["Height"] = "5ft 8 inches ";
        }
        public override void RecentMovie()
        {
            bollywood["RecentMovie"] = "Guzarish";
        }
        public override void Awards()
        {
            bollywood["Awards"] = "3";
        }
    }
    class ShahrukhCelebrities : BollywoodCelebrities
    {
        public ShahrukhCelebrities()
        {
            bollywood = new Bollywood("Shahrukh");
        }
        public override void Height()
        {
            bollywood["Height"] = "5ft 6inches";
        }
        public override void RecentMovie()
        {
            bollywood["RecentMovie"] = "My Name is Khan";
        }
        public override void Awards()
        {
            bollywood["Awards"] = "4";
        }
    }
    class KaterinaCelebrities : BollywoodCelebrities
    {
        public KaterinaCelebrities()
        {
            bollywood = new Bollywood("Katerina");
        }
        public override void Height()
        {
            bollywood["Height"] = "6ft";
        }
        public override void RecentMovie()
        {
            bollywood["RecentMovie"] = "Tees Maar Khan";
        }
        public override void Awards()
        {
            bollywood["Awards"] = "1";
        }
    }
    class Bollywood
    {
        private string _BollywoodCel;
        private Dictionary<string, string> _parts =
        new Dictionary<string, string>();
        public Bollywood(string BollywoodCel)
        {
            this._BollywoodCel = BollywoodCel;
        }
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(" Bollywood Celebrity: {0}", _BollywoodCel);
            Console.WriteLine(" Height : {0}", _parts["Height"]);
            Console.WriteLine(" RecentMovie : {0}", _parts["RecentMovie"]);
            Console.WriteLine(" **Awards**: {0}", _parts["Awards"]);
        }
    }
}
