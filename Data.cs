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
            DateString = date.Year + "/" + date.Month + "/" + date.Day;
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
            if (_DataObjectList == null)
            {
                _DataObjectList = new DataObjectList();
            }
            _DataObjectList.Clear();
            DateTime angryDate = new DateTime();
            DateTime pDate = new DateTime();
            if (DateTimeList.GetDateTimeList().Count > 2)
            {
                pDate = DateTimeList.GetDateTimeList()[DateTimeList.GetDateTimeList().Count - 1];
                angryDate = pDate.AddDays(14);
                pDate = pDate.AddDays(DateTimeList.AvgDiff());
            }
            int angryI = 0;
            int pI = 0;
            for (int i = 0; i < 30; ++i)
            {
                DateTime tempDate = date.AddDays(i);
                DataObject dataObject = new DataObject(tempDate, 1);
                if(CompareDateTime(tempDate, angryDate))
                {
                    angryI = i;
                }
                if(CompareDateTime( tempDate, pDate))
                {
                    pI = i;
                }
                _DataObjectList.Add(dataObject);
            }

            int offset = 0;
            for(int i = angryI; i < pI; ++i)
            {
                _DataObjectList[i].Data = 3 + offset * 0.2;
                offset++;
            }
            offset = 0;
            for(int i = 0; i < 6; ++i)
            {
                _DataObjectList[pI + i].Data = 3 + (pI - angryI) * 0.2 - offset * 0.2;
                offset++;
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
