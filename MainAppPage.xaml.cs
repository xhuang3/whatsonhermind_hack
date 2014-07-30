using Microsoft.Phone.Controls;
using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    public partial class MainAppPage : PhoneApplicationPage
    {
        private ObservableCollection<DataObject> _dataList = new ObservableCollection<DataObject>();

        public ObservableCollection<DataObject> DataList { get { return _dataList; } }

        public MainAppPage()
        {
            InitializeComponent();
            DateListBox.ItemsSource = DateTimeList.GetDateTimeList();
            
            this.DataContext = this;

            // Create a list of dataobejct for the next 30 days
            // TODO: should be in another place
            for (int i = 0; i < 30; ++i)
            {
                DateTime date = (new DateTime()).AddDays(i);
                DataObject dataobject;
                //_dataList.Add(new DataObject(date.AddDays(i), 1));
                DateTimeList datelist = DateTimeList.GetDateTimeList();
                //if(datelist.Contains(date)) dataobject = new DataObject(date, )
            }
        }

        private void DatePickerValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            DateTime date = (DateTime)e.NewDateTime;
            DateTimeList.GetDateTimeList().AddDateTime(date);

            int avgDay = DateTimeList.AvgDiff();
            if(avgDay > 0){
                // TODO: Debug here!!!!
               DateBlock.Text = (DateTimeList.GetDateTimeList()[DateTimeList.GetDateTimeList().Count - 1].AddDays(avgDay)).ToString();
            }
            else
            {
                DateBlock.Text = "Not enough information!";
            }
            
        }
    }
}