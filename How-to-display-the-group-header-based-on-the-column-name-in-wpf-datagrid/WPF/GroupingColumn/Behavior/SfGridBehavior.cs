using GroupingDemo.Helper;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;

namespace GroupingDemo
{
    public class SfGridBehavior : Behavior<SfDataGrid>
    {
        protected override void OnAttached()
        {
            //default CaptionSummaryCellRenderer is removed.            
            this.AssociatedObject.CellRenderers.Remove("CaptionSummary");

            //Customized CaptionSummaryCellRenderer is added.
            this.AssociatedObject.CellRenderers.Add("CaptionSummary", new CustomCaptionSummaryCellRenderer());
        }
    }
}
