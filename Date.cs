using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    public class DataObject
    {
        private static int _id = 0;
        public int Id { get { return _id++; } }
        public DateTime Date { get; set; }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DataObject(DateTime date)
        {
            this.Date = date;
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
        }

    }
    public class DateList : ObservableCollection<DataObject>
    {
        private static DateList DateListInstance;

        public static DateList GetDateList()
        {
            if (DateListInstance == null)
            {
                DateListInstance = new DateList();
            }
            return DateListInstance;
        }

        public static int AvgDiff()
        {
            // TODO: Need to sort DateList
            if (DateListInstance.Count < 2)
            {
                return -1;
            }
            int avg = -1;
            DataObject tempData = DateListInstance[0];
            for (int i = 1; i < DateListInstance.Count; ++i)
            {
                avg += DateListInstance[i].Date.DayOfYear - tempData.Date.DayOfYear;
            }
            return avg / (DateListInstance.Count - 1);
        }
    }
}
