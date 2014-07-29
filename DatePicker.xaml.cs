using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WhatsOnHerMind
{
    public partial class DatePicker : PhoneApplicationPage
    {
        public DatePicker()
        {
            InitializeComponent();
           
        }

        private void DatePickerValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            DateTime date = (DateTime)e.NewDateTime;
            DateList.GetDateList().Add(date);
        }
    }
}