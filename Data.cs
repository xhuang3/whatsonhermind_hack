using System;
using System.Collections.Generic;
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
}
