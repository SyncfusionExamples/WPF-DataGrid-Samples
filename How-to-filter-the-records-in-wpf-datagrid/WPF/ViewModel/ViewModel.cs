using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;

namespace SearchPanel
{
    public class ViewModel
    {
        private DataTable dataTableCollection;

        public ViewModel()
        {
            //Gets the data for DataTable object.
            dataTableCollection = GetGridData();

            //Convert DataTable collection as Dyanamic collection.
            var dynamicCollection = new ObservableCollection<dynamic>();
            foreach (DataRow row in dataTableCollection.Rows)
            {
                dynamic dyn = new ExpandoObject();
                dynamicCollection.Add(dyn);
                foreach (DataColumn column in dataTableCollection.Columns)
                {
                    var dic = (IDictionary<string, object>)dyn;
                    dic[column.ColumnName] = row[column];
                }
            }

            DynamicOrders = dynamicCollection;
        }

        private ObservableCollection<dynamic> _dynamicOrders;

        /// <summary>
        /// Gets or sets the dynamic orders.
        /// </summary>
        /// <value>The dynamic orders.</value>
        public ObservableCollection<dynamic> DynamicOrders
        {
            get
            {
                return _dynamicOrders;
            }
            set
            {
                _dynamicOrders = value;
            }
        }

        public DataTable DataTableCollection
        {
            get { return dataTableCollection; }
            set { dataTableCollection = value; }
        }

        private DataTable GetGridData()
        {
            var myDataTable = new DataTable();

            // Add columns to DataTable.

            myDataTable.Columns.Add("EmployeeID", typeof(int));
            myDataTable.Columns.Add("EmployeeName", typeof(string));
            myDataTable.Columns.Add("EmployeeAge", typeof(ulong));
            myDataTable.Columns.Add("EmployeeDesignation", typeof(string));
            myDataTable.Columns.Add("CustomerID", typeof(string));
            myDataTable.Columns.Add("ShipCountry", typeof(string));

            // Add some rows to the DataTable.
            myDataTable.Rows.Add(1001, "Sean Jacobson", 21, "Junior Architect", "FRANS", "Argentina");
            myDataTable.Rows.Add(1002, "Phyllis Allen", 33, "Team Lead", "MEREP", "Austria");
            myDataTable.Rows.Add(1003, "Marvin Allen", 42, "Team Lead", "MEREP", "Denmark");
            myDataTable.Rows.Add(1004, "Michael Allen", 22, "Junior Architect", "SIMOB", "Canada");
            myDataTable.Rows.Add(1005, "Cecil Allison", 33, "Team Lead", "FOLIG", "Mexico");
            myDataTable.Rows.Add(1006, "Tom Johnston", 44, "Senior Architect", "BLONP", "USA");
            myDataTable.Rows.Add(1007, "Thomas Armstrong", 21, "Junior Architect", "WELLI", "UK");
            myDataTable.Rows.Add(1008, "John Arthur", 33, "Team Lead", "WELLI", "Ireland");
            myDataTable.Rows.Add(1009, "Chris Ashton", 42, "Junior Architect", "RISCU", "Denmark");
            myDataTable.Rows.Add(1010, "Teresa Atkinson", 22, "Junior Architect", "LINOD", "France");
            myDataTable.Rows.Add(1011, "John Ault", 33, "Sales Engineer", "FOLKO", "Argentina");
            myDataTable.Rows.Add(1012, "Robert Avalos", 44, "Team Lead", "PICCO", "Austria");
            myDataTable.Rows.Add(1013, "Cecil Allison", 21, "Junior Architect", "SIMOB", "Switzerland");
            myDataTable.Rows.Add(1014, "Stephen Ayers", 33, "Junior Architect", "MEREP", "Ireland");
            myDataTable.Rows.Add(1015, "Selena Alvarad", 42, "Team Lead", "BLONP", "Canada");
            myDataTable.Rows.Add(1016, "Phyllis Allen", 22, "Junior Architect", "LINOD", "Mexico");
            myDataTable.Rows.Add(1017, "Maxwell Amland", 33, "Senior Architect", "FOLIG", "Austria");
            myDataTable.Rows.Add(1018, "Gustavo Achong", 44, "Engineer", "FRANS", "USA");
            myDataTable.Rows.Add(1019, "Hannah Arakawa", 21, "Sales Engineer", "WELLI", "Denmark");
            myDataTable.Rows.Add(1020, "Stephen Ayers", 33, "Senior Architect", "SEVES", "Spain");
            myDataTable.Rows.Add(1021, "Mae Anderson", 42, "Engineer", "RISCU", "Switzerland");
            myDataTable.Rows.Add(1022, "ames Aguilar", 22, "Junior Architect", "SIMOB", "Argentina");
            myDataTable.Rows.Add(1023, "Sean Jacobson", 33, "Team Lead", "FURIB", "Canada");
            myDataTable.Rows.Add(1024, "Marvin Allen", 44, "Sales Engineer", "FOLKO", "France");
            myDataTable.Rows.Add(1025, "Michael Allen", 21, "Junior Architect", "PICCO", "Italy");
            myDataTable.Rows.Add(1026, "Frances Adams", 33, "Team Lead", "WARTH", "Germany");
            myDataTable.Rows.Add(1027, "Gustavo Achong", 42, "Engineer", "VAFFE", "Argentina");
            myDataTable.Rows.Add(1028, "Chris Ashton", 22, "Junior Architect", "FOLIG", "Denmark");
            myDataTable.Rows.Add(1029, "Robert Avalos", 33, "Senior Architect", "MEREP", "Canada");
            myDataTable.Rows.Add(1030, "John Arthur", 44, "Sales Engineer", "LINOD", "Austria");
            myDataTable.Rows.Add(1031, "Stephen Ayers", 21, "Junior Architect", "BLONP", "France");
            myDataTable.Rows.Add(1032, "Teresa Atkinson", 33, "Team Lead", "RISCU", "Argentina");
            myDataTable.Rows.Add(1033, "Thomas Armstrong", 42, "Senior Architect", "FURIB", "Ireland");
            myDataTable.Rows.Add(1034, "Kyley Arbelaez", 22, "Junior Architect", "PICCO", "Austria");
            myDataTable.Rows.Add(1035, "Maxwell Amland", 33, "Senior Architect", "FOLKO", "Denmark");
            myDataTable.Rows.Add(1036, "Frances Adams", 44, "Sales Engineer", "FRANS", "France");
            myDataTable.Rows.Add(1037, "Hannah Arakawa", 21, "Sales Engineer", "SIMOB", "Canada");
            myDataTable.Rows.Add(1038, "Kyley Arbelaez", 33, "Senior Architect", "FOLIG", "Italy");
            myDataTable.Rows.Add(1039, "Maxwell Amland", 42, "Engineer", "SEVES", "Mexico");
            myDataTable.Rows.Add(1040, "Stephen Ayers", 22, "Junior Architect", "LINOD", "Argentina");
            myDataTable.Rows.Add(1041, "John Ault", 33, "Team Lead", "WELLI", "France");
            myDataTable.Rows.Add(1042, "Teresa Atkinson", 44, "Senior Architect", "RISCU", "UK");
            myDataTable.Rows.Add(1043, "Michael Allen", 21, "Sales Engineer", "PICCO", "Austria");
            myDataTable.Rows.Add(1044, "Tom Johnston", 33, "Team Lead", "BLONP", "Canada");
            myDataTable.Rows.Add(1045, "John Arthur", 42, "Engineer", "FOLKO", "Denmark");
            myDataTable.Rows.Add(1046, "Chris Ashton", 22, "Sales Engineer", "SIMOB", "Argentina");
            myDataTable.Rows.Add(1047, "Phyllis Allen", 33, "Senior Architect", "FOLIG", "Germany");
            myDataTable.Rows.Add(1048, "Thomas Armstrong", 44, "Engineer", "FRANS", "Canada");
            myDataTable.Rows.Add(1049, "Cecil Allison", 33, "Senior Architect", "FOLKO", "France");
            myDataTable.Rows.Add(1050, "Sean Jacobson", 42, "Engineer", "MEREP", "Austria");
            return myDataTable;
        }
    }
}
