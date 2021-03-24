using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    class ViewModel
    {
        public ObservableCollection<Model> studentDetails;

        public ViewModel()
        {
            var dictionary=new Dictionary<string,int>();
            dictionary.Add("Subject1", 85);
            dictionary.Add("Subject2", 96);
          

            var dict1 = new Dictionary<string, int>();
            dict1.Add("Subject1", 100);
            dict1.Add("Subject2", 70);
            studentDetails = new ObservableCollection<Model>();

            studentDetails.Add(new Model()
            {
            StudentID = 101,
            StudentName = "Joseph",
            Age = 25,
            Major = "Psychology",
            Marks=dictionary,
               
            });
            studentDetails.Add(new Model()
            {
                StudentID = 102,
                StudentName = "Martin",
                Age = 32,
                Major = "French",
                Marks = dict1,
               
            });
            studentDetails.Add(new Model()
            {
                StudentID = 103,
                StudentName = "Christina Berglund",
                Age = 45,
                Major = "Electornics",
                Marks=dictionary,               

            });
            studentDetails.Add(new Model()
            {
                StudentID = 104,
                StudentName = "Steve Markin",
                Age = 26,
                Major = "Journalism",
                Marks=dict1,

            });
            studentDetails.Add(new Model()
            {
                StudentID = 105,
                StudentName = "Maria Anders",
                Age = 29,
                Major = "Astronomy",
                Marks=dictionary,
               
            });
            studentDetails.Add(new Model()
            {
                StudentID = 106,
                StudentName = "Jacobs",
                Age = 38,
                Major = "Science",
                Marks=dict1,
            });
        }

        public ObservableCollection<Model> StudentDetails
        {
            get { return studentDetails; }
            set { value = studentDetails; }
        }
    }
}
