using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSort
{
    public class Duck : IComparable<Duck>
    {
        public string Name { get; }
        public int Weight { get; }
        public Duck(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public int CompareTo(Duck other)
        {
            if (Weight < other.Weight)
            {
                return -1;
            }

            return Weight == other.Weight ? 0 : 1;
        }

        public override string ToString() => $"{Name} weighs {Weight.ToString()}";

    }
}
