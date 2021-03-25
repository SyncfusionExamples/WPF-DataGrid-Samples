using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfTestingSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.datagrid.MouseMove += datagrid_MouseMove;
            // datagrid.ToolTip = toolTip;            
                        
            //ToolTipService.SetShowDuration(datagrid, 7000);
            //ToolTipService.SetInitialShowDelay(datagrid, 20000000);
            //ToolTipService.SetPlacement(datagrid, System.Windows.Controls.Primitives.PlacementMode.Mouse);
        }

        int previourerecordindex = -1;
        int previouscolindex = -1;
        Point previouspoint;
        DispatcherTimer timer = new DispatcherTimer() { Interval = new TimeSpan(20000000) };
        DispatcherTimer closetimer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 3) };
        ToolTip toolTip = new ToolTip();       
        EventHandler handler;
        EventHandler closetimerhandler;

        void datagrid_MouseMove(object sender, MouseEventArgs e)
        {
            VisualContainer visualcontainer = (VisualContainer)datagrid.GetPropertyValue("VisualContainer");
            var point = e.GetPosition(visualcontainer);

            var rowcolumnindex = visualcontainer.PointToCellRowColumnIndex(point);
            var rowindex = rowcolumnindex.RowIndex;
            var columnindex = rowcolumnindex.ColumnIndex;
            // Get the resolved current record index
            int recordIndex = this.datagrid.ResolveToRecordIndex(rowindex);
            if (recordIndex < 0 || columnindex < 0)
            {
                timer.Stop();
                closetimer.Stop();
                toolTip.IsOpen = false;
                return;
            }

            if (recordIndex == previourerecordindex && columnindex == previouscolindex)
                return;

            timer.Stop();
            closetimer.Stop();
            toolTip.IsOpen = false;

            previourerecordindex = recordIndex;
            previouscolindex = columnindex;
            previouspoint = point;

            if (handler == null)
            {
                handler = (s, arg) =>
                {
                    timer.Stop();
                    // Get the current row record
                    var mappingName = this.datagrid.Columns[previouscolindex].MappingName;
                    var record1 = this.datagrid.View.Records.GetItemAt(previourerecordindex);
                    if (record1 != null)
                    {
                        var cellvalue = record1.GetType().GetProperty(mappingName).GetValue(record1).ToString();
                        toolTip.Content = cellvalue;
                        toolTip.IsOpen = true;
                    }
                    closetimer.Start();
                };
            }
            timer.Tick -= handler;
            timer.Tick += handler;

            if (closetimerhandler == null)
            {
                closetimerhandler = (s, arg) =>
                {
                    closetimer.Stop();
                    if (toolTip.IsOpen)
                        toolTip.IsOpen = false;
                };
            }

            closetimer.Tick -= closetimerhandler;
            closetimer.Tick += closetimerhandler;

            timer.Start();
        }
    }
}
