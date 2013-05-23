using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MahApps.MetroUI.ListboxItemStylesBug
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Money { get; set; }
    }

    public class ErrorSampleViewModel: INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        protected void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        private int windowID;
        public int WindowID
        {
            get { return windowID; }
            set { windowID = value; RaisePropertyChanged("WindowID"); }
        }

        private string windowTitle;
        public string WindowTitle
        {
            get { return windowTitle; }
            set { windowTitle = value; RaisePropertyChanged("WindowTitle"); }
        }

        private double windowRating;
        public double WindowRating
        {
            get { return windowRating; }
            set { windowRating = value; RaisePropertyChanged("WindowRating"); }
        }

        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; RaisePropertyChanged("Persons"); }
        }

        public ErrorSampleViewModel()
        {
            WindowID = 59909870;
            WindowTitle = "Just a Name for my window";
            WindowRating = 99.680;
            Persons = Helpers.GetData();
        }
        
    }
}
