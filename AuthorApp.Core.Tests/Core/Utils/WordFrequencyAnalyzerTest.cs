using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuthorApp.Core.Utils;

namespace AuthorApp.Tests.Core.Utils
{
    [TestClass]
    public class WordFrequencyAnalyzerTest
    {
        [TestMethod]
        public void When_passing_complex_text_of_6_distinct_words_calling_GetWordFrequencies_returns_6_entries()
        {
            WordFrequencyAnalyzer analyzer = new WordFrequencyAnalyzer();
            var result = analyzer.GetWordFrequencies("There's no place like home. Home sweet like home").ToList();

            Assert.AreEqual(6, result.Count());

            Assert.AreEqual("there's", result[0].Word);
            Assert.AreEqual(1, result[0].Frequency);

            Assert.AreEqual("no", result[1].Word);
            Assert.AreEqual(1, result[1].Frequency);

            Assert.AreEqual("place", result[2].Word);
            Assert.AreEqual(1, result[2].Frequency);

            Assert.AreEqual("like", result[3].Word);
            Assert.AreEqual(2, result[3].Frequency);

            Assert.AreEqual("home", result[4].Word);
            Assert.AreEqual(3, result[4].Frequency);

            Assert.AreEqual("sweet", result[5].Word);
            Assert.AreEqual(1, result[5].Frequency);            
        }

        [TestMethod]
        public void When_passing_empty_text_calling_GetWordFrequencies_returns_0_entries()
        {
            WordFrequencyAnalyzer analyzer = new WordFrequencyAnalyzer();
            var result = analyzer.GetWordFrequencies(string.Empty);

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void When_passing_null_text_calling_GetWordFrequencies_returns_0_entries()
        {
            WordFrequencyAnalyzer analyzer = new WordFrequencyAnalyzer();
            var result = analyzer.GetWordFrequencies(null);

            Assert.AreEqual(0, result.Count());
        }

    }
}
