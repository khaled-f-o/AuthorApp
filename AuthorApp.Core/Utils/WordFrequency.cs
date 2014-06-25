using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthorApp.Core.Utils
{
    public class WordFrequency
    {
        public WordFrequency(string word, int frequency)
        {
            Word = word;
            Frequency = frequency;
        }

        public string Word { get; set; }
        public int Frequency { get; set; }
    }
}
