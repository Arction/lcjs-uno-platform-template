using System;
using System.Windows;

namespace App14.WPF.Host
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

            // myBrowser.Source = V;
            myBrowser.Source = new System.Uri("D:\\LC-JS\\xamarine\\Uno Paltform\\App14\\App14.Skia.Wpf.Host\\Assets\\sample.html");
            string ggg = "'red'";
           // myBrowser.InvokeScript("gaga", ggg);
        }
    }
}
