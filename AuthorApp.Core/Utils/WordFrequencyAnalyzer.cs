using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AuthorApp.Core.Utils
{
    public class WordFrequencyAnalyzer
    {
        public IEnumerable<WordFrequency> GetWordFrequencies(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new List<WordFrequency>();

            //Regex taken from the internet
            return Regex.Matches(text, "'?([a-zA-Z'-]+)'?", RegexOptions.IgnoreCase).
                Cast<Match>().
                Select(match => match.Value.ToLower()).
                GroupBy(w => w).
                Select(grp => new WordFrequency(grp.Key, grp.Count()));
        }
    }
}
