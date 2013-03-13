using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MetroDemo2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            progress.IsActive = true;

            Task.Factory.StartNew(() =>
                {
                    var dataContext = new ShellViewModel();

                    for (var i = 0; i < 50; i++)
                    {
                        var model = new DataModel();
                        model.SetData(i);
                        dataContext.Data.Add(model);
                    }

                    Dispatcher.Invoke(() =>
                        {
                           
                            DataContext = dataContext;
                            progress.IsActive = false;
                        });

                });
        }
    }
}
