using System;
using System.IO;
using HuffmanLib;

namespace Huffman
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new Encoder();
            string line;
            var reader = new StreamReader("huffman.txt");
            while ((line=reader.ReadLine()) != null ){
                encoder.AddSymbol(int.Parse(line));
            }
            encoder.Encode();
            Console.WriteLine($"{encoder.MinWordLength}, {encoder.MaxWordLength}");
            Console.ReadKey();
        }
    }
}
