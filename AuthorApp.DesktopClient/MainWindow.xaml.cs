using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuthorApp.DesktopClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel _mainWindowViewModel;

        //Can Construction injection
        //Or change to Property and use property injection
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            _mainWindowViewModel = mainWindowViewModel;
            DataContext = _mainWindowViewModel;
        }
    }
}
