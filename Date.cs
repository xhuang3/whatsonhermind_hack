using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsOnHerMind
{
    public class DateList : List<DateTime>
    {
        private static DateList DateListInstance;
        public DateList()
        {
            this.Add(new DateTime());
        }

        public static DateList GetDateList()
        {
            if (DateListInstance == null)
            {
                DateListInstance = new DateList();
            }
            return DateListInstance;
        }
    }
}
