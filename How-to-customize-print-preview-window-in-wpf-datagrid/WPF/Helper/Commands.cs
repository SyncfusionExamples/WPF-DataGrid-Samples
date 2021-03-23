#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Windows;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Windows.Input;
using Syncfusion.Windows.Shared;
using Microsoft.Win32;
using System.IO;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.XlsIO;
using SfDataGridDemo.View;


namespace SfDataGridDemo
{
    public static class Commands 
    {
        static Commands()
        {
            CommandManager.RegisterClassCommandBinding(typeof(SfDataGrid), new CommandBinding(PrintPreview, OnPrintGrid));
        }      

        public static RoutedCommand PrintPreview = new RoutedCommand("PrintPreview", typeof(SfDataGrid));

        //Customizing PrintPreview for Export to Excel.
        private static void OnPrintGrid(object sender, ExecutedRoutedEventArgs args)
        {
            var dataGrid = args.Source as SfDataGrid;
            if (dataGrid == null) return;
            try
            {
                var window = new Preview
                    {
                        WindowStartupLocation = WindowStartupLocation.CenterScreen,
                    };
                SkinStorage.SetEnableOptimization(window, false);
                SkinStorage.SetVisualStyle(window, "Metro");

                window.PrintPreviewArea.PrintManagerBase = new GridPrintManager(dataGrid);
                window.Grid = dataGrid;
                window.ShowDialog();
            }
            catch (Exception)
            {

            }
        }          
    }    
}
