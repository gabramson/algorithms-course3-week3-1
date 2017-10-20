using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanLib
{
    public class Encoder
    {
        private SortedList<int, MinMax> frequencies = new SortedList<int, MinMax>();

        public int MinWordLength
        {
            get
            {
                return frequencies.Values[0].Min;
            }
        }

        public int MaxWordLength
        {
            get
            {
                return frequencies.Values[0].Max;
            }
        }

        public void AddSymbol(int weight)
        {
            frequencies.Add(weight, new MinMax { Min = 0, Max = 0 });
        }

        public void Encode() { 
            while (frequencies.Count > 1)
            {
                int newFrequency = frequencies.Keys[0] + frequencies.Keys[1];
                int newMin = Min(frequencies.Values[0].Min, frequencies.Values[1].Min) + 1;
                int newMax = Max(frequencies.Values[0].Max, frequencies.Values[1].Max) + 1;
                frequencies.RemoveAt(0);
                frequencies.RemoveAt(0);
                frequencies.Add(newFrequency, new MinMax { Min = newMin, Max = newMax });
            }
        }

        private int Max(int first, int second)
        {
            return (first > second) ? first : second;
        }

        private int Min(int first, int second)
        {
            return (first < second) ? first : second;
        }

        private struct MinMax
        {
            public int Min { get; set; } 
            public int Max { get; set; } 
        }
    }
}