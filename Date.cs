using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    public class DateTimeList : ObservableCollection<DateTime>
    {
        private static DateTimeList DateTimeListInstance;

        public static DateTimeList GetDateTimeList()
        {
            if (DateTimeListInstance == null)
            {
                DateTimeListInstance = new DateTimeList();
            }
            return DateTimeListInstance;
        }

        public void AddDateTime(DateTime datetime)
        {
            if (DateTimeListInstance == null || DateTimeListInstance.Count == 0)
            {
                DateTimeListInstance.Add(datetime);
            }
            else
            {
                int i = 0;
                while (datetime > DateTimeListInstance[i])
                {
                    i++;
                }
                DateTimeListInstance.Insert(i, datetime);
            }
        }

        public static int AvgDiff()
        {
            // TODO: Need to sort DateList
            if (DateTimeListInstance.Count < 2)
            {
                return -1;
            }
            int avg = -1;
            DateTime tempData = DateTimeListInstance[0];
            for (int i = 1; i < DateTimeListInstance.Count; ++i)
            {
                avg += DateTimeListInstance[i].DayOfYear - tempData.DayOfYear;
            }
            return avg / (DateTimeListInstance.Count - 1);
        }
    }
}
