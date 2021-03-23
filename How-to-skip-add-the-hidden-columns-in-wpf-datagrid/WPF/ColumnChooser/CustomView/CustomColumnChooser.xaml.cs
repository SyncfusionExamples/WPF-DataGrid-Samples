#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static ColumnChooserDemo.ViewModel;

namespace ColumnChooserDemo.CustomView
{
    /// <summary>
    /// Interaction logic for CustomColumnChooser.xaml
    /// </summary>
    public partial class CustomColumnChooser : ChromelessWindow
    {
        protected SfDataGrid DataGrid { get; set; }
        public CustomColumnChooser(CustomColumnChooserViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
       
    }
}
