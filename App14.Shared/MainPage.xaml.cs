using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App14
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public bool IsJavaScriptEnabled { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            // webView1.Settings.IsJavaScriptEnabled = true;
            Windows.UI.Xaml.Window.Current.CoreWindow.PointerCursor = null;
#if __ANDROID__
            webView1.Navigate(new Uri("file:///android_asset/sample.html"));
#else
            webView1.Navigate(new Uri("ms-appx-web:///Assets/sample.html"));
#endif
        }
        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            webView1.InvokeScriptAsync("eval", new string[] { "ClearAll()" });
            string json = "[{'X':0,'Y':1.52},{'X':1,'Y':1.56},{'X':2,'Y':1.42},{'X':3,'Y':1.85},{'X':4,'Y':1.62}]";
            webView1.InvokeScriptAsync("eval", new string[] { $"datapoint({json})" });
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            webView1.InvokeScriptAsync("eval", new string[] { "ClearAll()" });
            var point = GeneratePointSeries(6,10);
            string output = JsonConvert.SerializeObject(point);
            string data1 = output.Replace("\"", "'"); ;
             webView1.InvokeScriptAsync("eval", new string[] { $"show3Dchart(" + data1 + ")" });
        }
        private List<DataPoint[]> GeneratePointSeries(int seriesCount, int pointsPerSeries)
        { 
            Random r = new Random();
            List<DataPoint[]> pointSeries = new List<DataPoint[]>();

            for (int i = 0; i < seriesCount; i++)
            {
                DataPoint[] points = new DataPoint[pointsPerSeries];
                for (int j = 0; j < pointsPerSeries; j++)
                {
                    points[j] = new DataPoint(j, r.Next(0, 100), r.Next(0, 100));
                }
                pointSeries.Add(points);
            }
            return pointSeries;
        }
    }
}
