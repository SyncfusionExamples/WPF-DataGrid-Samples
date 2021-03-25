using SfDataGridDemo;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Syncfusion.UI.Xaml.Reports;
using System.Reflection;
using Windows.UI.Core;
using System.Collections;
using Syncfusion.EJ;
using System.Windows;
using Syncfusion.EJ.ReportViewer;
using Syncfusion.Reports;
using Syncfusion.UI.Xaml.Reports;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();          
        }
        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            object[] grids = { grid1, grid2,DataContext };

            this.Frame.Navigate(typeof(BlankPage1), grids);
        }        
    }
}

