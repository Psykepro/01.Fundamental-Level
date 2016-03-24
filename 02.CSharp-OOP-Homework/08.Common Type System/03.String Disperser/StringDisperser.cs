using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Disperser
{
    class StringDisperser:ICloneable,IComparable<StringDisperser>,IEnumerable
    {
        public StringDisperser(params string[] strings)
        {
            this.Strings=new List<string>(strings);
        }

        public List<string> Strings { get; set; }

        public override bool Equals(object obj)
        {
            StringDisperser other=obj as StringDisperser;
            if (other == null)
            {
                return false;
            }
            if (this.Strings.Count.CompareTo(other.Strings.Count) != 0)
            {
                return false;
            }
            bool isEqual = true;
            for (int i = 0; i < this.Strings.Count; i++)
            {
                if (this.Strings[i].CompareTo(other.Strings[i]) != 0)
                {
                    isEqual=false;
                    break;
                }
            }
            return isEqual;
        }

        public override int GetHashCode()
        {
            var hashCode = this.Strings.GetHashCode();
            foreach (var str in this.Strings)
            {
                hashCode ^= str.GetHashCode();
            }
            return hashCode;
        }

        public IEnumerator GetEnumerator()
        {
            string allStrings = this.ToString();
            for (int i = 0; i < allStrings.Length; i++)
            {
                yield return allStrings[i];
            }
        }

        public int CompareTo(StringDisperser other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Second object is null.");
            }
            return (string.Compare(this.ToString(), other.ToString(), StringComparison.InvariantCulture));
        }

        public object Clone()
        {
            return new StringDisperser(this.Strings.ToArray());
        }

        public static bool operator ==(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return stringDisperser1.Equals(stringDisperser2);
        }

        public static bool operator !=(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return !stringDisperser1.Equals(stringDisperser2);
        }

        public override string ToString()
        {
            return string.Join("", this.Strings);
        }
    }
}
