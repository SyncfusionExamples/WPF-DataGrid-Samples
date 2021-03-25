using System;
using System.Collections;
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
using Syncfusion.UI.Xaml.Grid;
namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.sfGrid.CurrentCellValidating += sfGrid_CurrentCellValidating;
        }

       void sfGrid_CurrentCellValidating(object sender, Syncfusion.UI.Xaml.Grid.CurrentCellValidatingEventArgs args)
       {
           bool isAddNewRow = sfGrid.IsAddNewIndex(sfGrid.SelectionController.CurrentCellManager.CurrentRowColumnIndex.RowIndex);

           if (!isAddNewRow)
               return;

           if (args.Column.MappingName == "Name")
           {
               var text = args.NewValue.ToString();

               var datacontext = (this.DataContext as UserInfoViewModel).UserDetails;

               var listOfNames = datacontext.Where(e => e.Name.Equals(text)).ToList();

               if (listOfNames.Count > 0)
               {
                   args.ErrorMessage = "Entered Name is  already existing";
                   args.IsValid = false;
               }
           }
       }
    }
}
