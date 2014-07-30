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
            DateString = date.Year + "/" + date.Month + "/" + date.Day; //TODO: Better format
        }


    }

    public class DataObjectList : ObservableCollection<DataObject>
    {
        private static DataObjectList _DataObjectList;
        private static bool CompareDateTime(DateTime date1, DateTime date2)
        {
            if (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day) return true;
            return false;
        }
        public static void PopulateList(DateTime date)
        {
            DateTime angryDate = new DateTime();
            if(DateTimeList.GetDateTimeList().Count > 2) angryDate = DateTimeList.GetDateTimeList()[DateTimeList.GetDateTimeList().Count - 1].AddDays(14);
            if (_DataObjectList == null)
            {
                _DataObjectList = new DataObjectList();
            }
            _DataObjectList.Clear();
            for (int i = 0; i < 30; ++i)
            {
                DateTime tempDate = date.AddDays(i);
                DataObject dataObject;
                if(CompareDateTime(tempDate, angryDate))
                {
                    dataObject = new DataObject(tempDate, 5);
                }
                else
                {
                    dataObject = new DataObject(tempDate, 1);
                }
                
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
