using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace MahApps.MetroUI.ListboxItemStylesBug
{
    /// <summary>
    /// Interaction logic for ErrorSample.xaml
    /// </summary>
    public partial class ErrorSample : MetroWindow
    {
        public ErrorSample()
        {
            InitializeComponent();
            DataContext = new ErrorSampleViewModel();
        }
    }
}
