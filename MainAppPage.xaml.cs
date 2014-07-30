using Microsoft.Phone.Controls;
using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    // TODO: We can move DataObject to another .cs file
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

    public partial class MainAppPage : PhoneApplicationPage
    {
        private ObservableCollection<DataObject> _dataList = new ObservableCollection<DataObject>();

        public ObservableCollection<DataObject> DataList { get { return _dataList; } }

        public MainAppPage()
        {
            InitializeComponent();
            DateListBox.ItemsSource = DateObjectList.GetDateList();
            
            this.DataContext = this;

            // Create a list of dataobejct for the next 30 days
            for (int i = 0; i < 30; ++i)
            {
                DateTime date = new DateTime();
                _dataList.Add(new DataObject(date.AddDays(i), 2 + 0.2 * i));
            }
        }

        private void DatePickerValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            DateTime date = (DateTime)e.NewDateTime;
            DateObjectList.GetDateList().AddDateObject(new DateObject(date));

            int avgDay = DateObjectList.AvgDiff();
            if(avgDay > 0){
                // TODO: Debug here!!!!
                DateBlock.Text = (DateObjectList.GetDateList()[DateObjectList.GetDateList().Count].Date.AddDays(avgDay)).ToString();
            }
            else
            {
                DateBlock.Text = "Not enough information!";
            }
            
        }
    }
}