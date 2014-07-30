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

        public int AvgDiff()
        {
            foreach (DataObject data in DateListInstance)
            {

            }
            return 0;
        }
    }
}
