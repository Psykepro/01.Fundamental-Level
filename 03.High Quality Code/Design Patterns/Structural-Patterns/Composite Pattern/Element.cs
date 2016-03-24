namespace Composite.Element
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Element
    {
        private readonly IList<Element> children;

        public Element(string name, params Element[] children)
        {
            this.Name = name;
            this.children = new List<Element>(children);
        }

        public string Name { get; set; }

        public void Add(Element child)
        {
            if (child == null)
            {
                throw new ArgumentNullException();
            }

            this.children.Add(child);
        }

        public void Remove(Element child)
        {
            if (!this.children.Contains(child))
            {
                throw new InvalidOperationException();
            }

            this.children.Remove(child);
        }

        public string Display(int depth)
        {
            string inwardSpaces = new string(' ', depth);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{1}<{0}>", this.Name, inwardSpaces).AppendLine();
            
            if (this.children.Count > 0)
            {
                // Recursive Call of All Children
                foreach (var element in this.children)
                {
                    sb.Append(element.Display(depth + 2));
                }
            }

            sb.AppendFormat("{1}</{0}>", this.Name, inwardSpaces).AppendLine();
            return sb.ToString();
        }
    }
}