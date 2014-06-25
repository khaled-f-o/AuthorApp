using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using AuthorApp.Core.Utils;
using System.Windows.Input;

namespace AuthorApp.DesktopClient
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        private readonly WordFrequencyAnalyzer _wordFrequencyAnalyzer = new WordFrequencyAnalyzer();
        private ObservableCollection<WordFrequency> _analysisResults;
        private string _sentence;
        private AnalyzeSentenceCommand _analyzeSentenceCommand;

        public MainWindowViewModel()
        {
            InitializeCommands();
        }

        public string Sentence
        {
            get { return _sentence; }
            set
            {
                _sentence = value;
                OnPropertyChanged("Sentence");
            }
        }

        public ObservableCollection<WordFrequency> AnalysisResults
        {
            get { return _analysisResults; }
            set
            {
                _analysisResults = value;
                OnPropertyChanged("AnalysisResults");
            }
        }

        public AnalyzeSentenceCommand AnalyzeSentenceCommand
        {
            get { return _analyzeSentenceCommand; }
            set
            {
                _analyzeSentenceCommand = value;
                OnPropertyChanged("AnalyzeSentenceCommand");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void InitializeCommands()
        {
            AnalyzeSentenceCommand = new AnalyzeSentenceCommand(AnalyzeSentence);
        }

        private void AnalyzeSentence()
        {
            AnalysisResults = new ObservableCollection<WordFrequency>(_wordFrequencyAnalyzer.GetWordFrequencies(Sentence));
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
