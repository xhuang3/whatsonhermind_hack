using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsOnHerMind
{
    public class DataObject
    {
        public string DateString { get; set; }
        public DateTime Date { get; set; }

        public double Data { get; set; }

        public DataObject(DateTime date, double data)
        {
            Date = date;
            Data = data;
            DateString = date.ToString(); //TODO: Better format
        }


    }

    public class DataObjectList : ObservableCollection<DataObject>
    {
        private static DataObjectList _DataObjectList;
        public static void PopulateListWithoutValue(DateTime date)
        {
            if (_DataObjectList == null)
            {
                _DataObjectList = new DataObjectList();
            }
            _DataObjectList.Clear();
            for (int i = 0; i < 30; ++i)
            {
                DataObject dataObject = new DataObject(date.AddDays(i), 0);
                _DataObjectList.Add(dataObject);
            }
        }

        public static DataObjectList GetDataObjectList()
        {
            if(_DataObjectList == null)
            {
                _DataObjectList = new DataObjectList();
            }
            return _DataObjectList;
        }
    }
}
