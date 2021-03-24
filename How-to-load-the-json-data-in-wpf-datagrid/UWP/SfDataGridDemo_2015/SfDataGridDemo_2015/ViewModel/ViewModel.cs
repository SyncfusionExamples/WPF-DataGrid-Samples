using Newtonsoft.Json;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        string json = null;

        public ObservableCollection<DynamicModel> DynamicCollection { get; set; }
        public List<Dictionary<string, object>> DynamicJsonCollection { get; set; }

        public ViewModel()
        {
            string fileName = "ms-appx:///Assets/JsonData.json";          
            json = ReadJsonFile(fileName);

            DynamicJsonCollection = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(json);
            DynamicCollection = PopulateData();
        }


        public string ReadJsonFile(string fileName)
        {
            string jsonText = null;
            try
            {
                
                Uri appUri = new Uri(fileName);
                StorageFile file = StorageFile.GetFileFromApplicationUriAsync(appUri).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                jsonText = FileIO.ReadTextAsync(file).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                
            }
            catch (Exception exp)
            {
            }
            return jsonText;
        }
        private ObservableCollection<DynamicModel> PopulateData()
        {
            var data = new ObservableCollection<DynamicModel>();
            foreach (var item in DynamicJsonCollection)
            {
                var obj = new DynamicModel() { Values = item };
                data.Add(obj);
            }
            return data;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }


    public class QueryableViewExt : GridQueryableCollectionViewWrapper
    {
        public QueryableViewExt(IEnumerable source, SfDataGrid grid) : base(source, grid)
        {

        }

        public override Expression<Func<string, object, object>> GetExpressionFunc(string propertyName, DataOperation operation = DataOperation.Default, DataReflectionMode reflectionMode = DataReflectionMode.Default)
        {
            Expression<Func<string, object, object>> exp = base.GetExpressionFunc(propertyName, operation, reflectionMode);
            if (exp == null)
            {
                Func<string, object, object> func;
                func = (propertyname, record) =>
                {
                    var provider = this.GetPropertyAccessProvider();
                    return provider.GetValue(record, propertyName);
                };
                exp = (propertyname, record) => func(propertyName, record);
            }
            return exp;
        }
    }
}




