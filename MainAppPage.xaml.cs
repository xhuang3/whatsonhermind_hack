using Microsoft.Phone.Controls;
using System;
using System.Collections.ObjectModel;

namespace WhatsOnHerMind
{
    public partial class MainAppPage : PhoneApplicationPage
    {
        private ObservableCollection<DataObject> _dataList = new ObservableCollection<DataObject>();

        public ObservableCollection<DataObject> DataList { get; set; }

        public MainAppPage()
        {
            InitializeComponent();
            DateListBox.ItemsSource = DateTimeList.GetDateTimeList();
            
            this.DataContext = this;
            DataObjectList.PopulateListWithoutValue(new DateTime());
            DataList = DataObjectList.GetDataObjectList();

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