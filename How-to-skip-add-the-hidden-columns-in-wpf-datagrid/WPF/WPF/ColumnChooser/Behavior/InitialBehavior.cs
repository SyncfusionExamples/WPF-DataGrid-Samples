#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using ColumnChooserDemo.CustomView;

using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;
using static ColumnChooserDemo.ViewModel;

namespace ColumnChooserDemo
{
    public class InitialBehavior : Behavior<MainWindow>
    {
        CustomColumnChooser chooserWindow;

        #region Overrides

        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += OnAssociatedObjectLoaded;
            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= OnAssociatedObjectLoaded;
            base.OnDetaching();
        }

        #endregion

        ViewModel viewModel;

        void OnAssociatedObjectLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            viewModel = (this.AssociatedObject.DataContext) as ViewModel;
            viewModel.ColumnChooserCommand = new DelegateCommand<object>(ColumnChooserCommandHandler);
            InitializeColumnChooserPopup();
        }

        public void ColumnChooserCommandHandler(object param)
        {
            if (param == null)
                ShowColumnChooser();
            else if (param.ToString().Equals("ShowColumnChooser"))
            {
                if (viewModel.ShowColumnChooser)
                    ShowColumnChooser();
                else
                    chooserWindow.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        void ShowColumnChooser()
        {
            if (viewModel.ShowColumnChooser && viewModel.UseDefaultColumnChooser)
                chooserWindow.Visibility = System.Windows.Visibility.Visible;
        }

        void InitializeColumnChooserPopup()
        {
            chooserWindow = new CustomColumnChooser(this.AssociatedObject.dataGrid);
            this.AssociatedObject.dataGrid.GridColumnDragDropController = new GridColumnChooserController(this.AssociatedObject.dataGrid, chooserWindow);
            chooserWindow.Show();
            chooserWindow.Owner = this.AssociatedObject;
            chooserWindow.Closing += chooserWindow_Closing;
        }

        void chooserWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            chooserWindow.Visibility = System.Windows.Visibility.Collapsed;
            viewModel.ShowColumnChooser = false;
        }
    }
}
