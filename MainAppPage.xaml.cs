using Microsoft.Phone.Controls;
using Microsoft.Phone.Scheduler;
using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    public partial class MainAppPage : PhoneApplicationPage
    {
        public ObservableCollection<DataObject> DataList { get; set; }

        public MainAppPage()
        {
            InitializeComponent();
            DateListBox.ItemsSource = DateTimeList.GetDateTimeList();
            
            this.DataContext = this;
            DataList = DataObjectList.GetDataObjectList();
        }

        private void DatePickerValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            DateTime date = (DateTime)e.NewDateTime;
            DateTimeList.GetDateTimeList().AddDateTime(date);

            int avgDay = DateTimeList.AvgDiff();
            if(DateTimeList.GetDateTimeList().Count > 2){
                // TODO: Debug here!!!!
               DateBlock.Text = (DateTimeList.GetDateTimeList()[DateTimeList.GetDateTimeList().Count - 1].AddDays(avgDay)).ToString();
               DataObjectList.GetDataObjectList().PopulateList(DateTime.Now);
            }
            else
            {
                DateBlock.Text = "Not enough information!";
            }
            
        }

        private void RefreshButtonPressed(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainAppPage.xaml?Refresh=true", UriKind.Relative));
        }

        private void AddReminderButtonPressed(object sender, System.Windows.RoutedEventArgs e)
        {
            var reminder = new Reminder("my reminder")
            {
                Title = "my title",
                Content = "my content",
                BeginTime = DateTime.Now.AddMinutes(1),
                ExpirationTime = DateTime.Now.AddHours(1),
                RecurrenceType = RecurrenceInterval.None,
                NavigationUri = null
            };

            ScheduledActionService.Add(reminder);
        }
    }
}