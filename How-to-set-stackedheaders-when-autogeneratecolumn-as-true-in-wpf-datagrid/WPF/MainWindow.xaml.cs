#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;
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

namespace GettingStarted
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sfgrid_AutoGeneratingColumn(object sender, Syncfusion.UI.Xaml.Grid.AutoGeneratingColumnArgs e)
        {
            if (sfgrid.StackedHeaderRows.Count == 0)
            {
                var gridSHRow = new Syncfusion.UI.Xaml.Grid.StackedHeaderRow();
                gridSHRow.StackedColumns.Add(new Syncfusion.UI.Xaml.Grid.StackedColumn { ChildColumns = "OrderID,CustomerID", HeaderText = "ID" });
                gridSHRow.StackedColumns.Add(new Syncfusion.UI.Xaml.Grid.StackedColumn { ChildColumns = "ProductName,OrderDate,Quantity,UnitPrice", HeaderText = "Order Details" });
                gridSHRow.StackedColumns.Add(new Syncfusion.UI.Xaml.Grid.StackedColumn { ChildColumns = "DeliveryDelay,ShipAddress,ContactNumber", HeaderText = "Delivery Details" });
                sfgrid.StackedHeaderRows.Add(gridSHRow);
            }
        }  
    }
}
