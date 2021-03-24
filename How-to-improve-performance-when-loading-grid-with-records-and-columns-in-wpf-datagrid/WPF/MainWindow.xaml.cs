#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.IO;
using Syncfusion.Windows.Shared;
using System.Diagnostics;
using System.Threading;
using Syncfusion.UI.Xaml.Grid;

namespace SfDataGridDemo_sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 250; i++)
            {
                grid.Columns.Add(new GridTextColumn() { MappingName = "column1", HeaderText = "Column1 -" + i });
                grid.Columns.Add(new GridTextColumn() { MappingName = "column2", HeaderText = "Column2 -" + i });
                grid.Columns.Add(new GridTextColumn() { MappingName = "column3", HeaderText = "Column3 -" + i });
                grid.Columns.Add(new GridTextColumn() { MappingName = "column4", HeaderText = "Column4 -" + i });
                grid.Columns.Add(new GridTextColumn() { MappingName = "column5", HeaderText = "Column5 -" + i });
            }
        }
    }
}
