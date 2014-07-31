using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    public class DataObject
    {
        public string DateString { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

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


        public void PopulateList(DateTime date)
        {
            _DataObjectList.Clear();

            DateTime aDate = new DateTime();
            DateTime pDate = new DateTime();
            if (DateTimeList.GetDateTimeList().Count > 2)
            {
                pDate = DateTimeList.GetDateTimeList()[DateTimeList.GetDateTimeList().Count - 1];
                aDate = pDate.AddDays(14);
                pDate = pDate.AddDays(DateTimeList.AvgDiff());
            }
            int angryI = -1;
            int pI = -1;

            for (int i = 0; i < 30; ++i)
            {
                DateTime tempDate = date.AddDays(i);
                if(CompareDateTime(tempDate, aDate))
                {
                    angryI = i;
                }
                if(CompareDateTime(tempDate, pDate))
                {
                    pI = i;
                }
                DataObject dataObject = new DataObject(tempDate, 1);
                _DataObjectList.Add(dataObject);
            }
            
            if (angryI < pI && angryI > 0)
            {
                for(int i = 0; i < 30; ++i)
                {
                    if (i < angryI) _DataObjectList[i].Data += i * 0.05;
                    else if (angryI <= i && i < pI) _DataObjectList[i].Data = 3 + i * 0.1;
                    else if (i >= pI && i < pI + 7) _DataObjectList[i].Data -= i * 0.01;
                    else _DataObjectList[i].Data = 1;
                }
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
