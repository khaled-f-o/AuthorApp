using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuthorApp.DesktopClient;

namespace AuthorApp.Tests.DesktopClient
{
    [TestClass]
    public class MainWindowViewModelTest
    {
        [TestMethod]
        public void Given_a_sentence_when_analyze_button_is_pressed_a_list_of_word_frequencies_will_be_displayed()
        {
            MainWindowViewModel viewModel = new MainWindowViewModel();
            viewModel.Sentence = "This is a statement, and so is this.";

            viewModel.AnalyzeSentenceCommand.Execute(null);

            var results = viewModel.AnalysisResults;

            Assert.AreEqual(6, results.Count());

            Assert.AreEqual("this", results[0].Word);
            Assert.AreEqual(2, results[0].Frequency);

            Assert.AreEqual("is", results[1].Word);
            Assert.AreEqual(2, results[1].Frequency);

            Assert.AreEqual("a", results[2].Word);
            Assert.AreEqual(1, results[2].Frequency);

            Assert.AreEqual("statement", results[3].Word);
            Assert.AreEqual(1, results[3].Frequency);

            Assert.AreEqual("and", results[4].Word);
            Assert.AreEqual(1, results[4].Frequency);

            Assert.AreEqual("so", results[5].Word);
            Assert.AreEqual(1, results[5].Frequency);            
        }
    }
}
