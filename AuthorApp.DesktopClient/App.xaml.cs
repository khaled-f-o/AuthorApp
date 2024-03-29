﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace AuthorApp.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();

            MainWindow mainWindow = new MainWindow(mainWindowViewModel);
            mainWindow.Show();
        }
    }
}
