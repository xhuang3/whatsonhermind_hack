using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    public class DateObject
    {
        // TODO: Do we need ID here?
        private static int _id = 0;
        public int Id { get { return ++_id; } }
        public DateTime Date { get; set; }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateObject(DateTime date)
        {
            this.Date = date;
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
        }
    }
    public class DateObjectList : ObservableCollection<DateObject>
    {
        private static DateObjectList DateListInstance;

        public static DateObjectList GetDateList()
        {
            if (DateListInstance == null)
            {
                DateListInstance = new DateObjectList();
            }
            return DateListInstance;
        }

        public void AddDateObject(DateObject dateObject)
        {
            //TODO: Sort DataObject by DateTime here!!!!
            if (DateListInstance == null || DateListInstance.Count == 0)
            {
                DateListInstance.Add(dateObject);
            }
            else
            {
                int temp = 0;
                while (dateObject.Date > DateListInstance[temp].Date)
                {
                    temp++;
                }
                DateListInstance.Insert(temp, dateObject);
            }
        }

        public static int AvgDiff()
        {
            // TODO: Need to sort DateList
            if (DateListInstance.Count < 2)
            {
                return -1;
            }
            int avg = -1;
            DateObject tempData = DateListInstance[0];
            for (int i = 1; i < DateListInstance.Count; ++i)
            {
                avg += DateListInstance[i].Date.DayOfYear - tempData.Date.DayOfYear;
            }
            return avg / (DateListInstance.Count - 1);
        }
    }
}
