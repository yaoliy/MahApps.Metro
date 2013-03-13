using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MetroDemo2.Annotations;

namespace MetroDemo2
{
    public class ShellViewModel : INotifyPropertyChanged
    {
        public ShellViewModel()
        {
            Data = new ObservableCollection<DataModel>();
        }

        private ObservableCollection<DataModel> _data;
        public ObservableCollection<DataModel> Data
        {
            get { return _data; }
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}