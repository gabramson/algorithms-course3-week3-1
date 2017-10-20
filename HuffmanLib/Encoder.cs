using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanLib
{
    public class Encoder
    {
        private SortedList<int, (int,int)> frequencies = new SortedList<int, (int,int)>();

        public int MinWordLength
        {
            get
            {
                return frequencies.Values[0].Item1;
            }
        }

        public int MaxWordLength
        {
            get
            {
                return frequencies.Values[0].Item2;
            }
        }


        public void AddSymbol(int weight)
        {
            frequencies.Add(weight, (0,0));
        }

        public void Encode() { 
            while (frequencies.Count > 1)
            {
                int newFrequency = frequencies.Keys[0] + frequencies.Keys[1];
                int newMin = Min(frequencies.Values[0].Item1, frequencies.Values[1].Item1) + 1;
                int newMax = Max(frequencies.Values[0].Item2, frequencies.Values[1].Item2) + 1;
                frequencies.RemoveAt(0);
                frequencies.RemoveAt(0);
                frequencies.Add(newFrequency, (newMin, newMax));
            }
        }

        private int Max(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        private int Min(int first, int second)
        {
            if (first < second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
