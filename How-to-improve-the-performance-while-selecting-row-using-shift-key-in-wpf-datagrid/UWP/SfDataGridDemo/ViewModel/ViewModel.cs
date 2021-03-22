#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel: INotifyPropertyChanged
    {
        Stopwatch stopWatch;
        TimeSpan timeSpan;
        public ViewModel()
        {
            var repository = new EmployeeInfoRepository();
            viewSource = new GridVirtualizingCollectionView(repository.GetEmployeesDetails(100000));
        }

        private VirtualizingCollectionView viewSource;

        public VirtualizingCollectionView ViewSource
        {
            get { return viewSource; }
            set { viewSource = value; }
        }
        private string totalTimeElapsed = "Total Time Elapsed : ";

        public string TotalTimeElapsed
        {
            get
            {
                return totalTimeElapsed;
            }
            set
            {
                totalTimeElapsed = value;
                this.RaisePropertyChanged("TotalTimeElapsed");
            }
        }
        private BaseCommand _SelectAllButton;

        public BaseCommand SelectAllButton
        {
            get
            {
                if (_SelectAllButton == null)
                    _SelectAllButton = new BaseCommand(OnSelectAllButtonClickMethod);

                return _SelectAllButton;
            }
        }

        void OnSelectAllButtonClickMethod(object parameter)
        {
            var dataGrid = parameter as SfDataGrid;
            stopWatch = new Stopwatch();
            stopWatch.Start();
            dataGrid.SelectRows(dataGrid.GetFirstDataRowIndex(), dataGrid.GetLastDataRowIndex());
            stopWatch.Stop();
            timeSpan = stopWatch.Elapsed;
            TotalTimeElapsed = "Total Time Elapsed : " + timeSpan.Hours.ToString() + ":" + timeSpan.Minutes.ToString() + ":" + timeSpan.Seconds.ToString() + ":" + timeSpan.Milliseconds.ToString();

        }

        private BaseCommand _RemoveSelectAllButton;

        public BaseCommand RemoveSelectAllButton
        {
            get
            {
                if (_RemoveSelectAllButton == null)
                    _RemoveSelectAllButton = new BaseCommand(OnRemoveSelectAllButtonClickMethod);

                return _RemoveSelectAllButton;
            }
        }
        void OnRemoveSelectAllButtonClickMethod(object parameter)
        {
            var dataGrid = parameter as SfDataGrid;
            stopWatch = new Stopwatch();
            stopWatch.Start();
            dataGrid.SelectionController.ClearSelections(false);
            stopWatch.Stop();
            timeSpan = stopWatch.Elapsed;
            TotalTimeElapsed = "Total Time Elapsed : " + timeSpan.Hours.ToString() + ":" + timeSpan.Minutes.ToString() + ":" + timeSpan.Seconds.ToString() + ":" + timeSpan.Milliseconds.ToString();

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
