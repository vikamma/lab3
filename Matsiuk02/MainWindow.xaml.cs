using Matsiuk02.ViewModel;
using System.Windows;

namespace Matsiuk02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PersonRegisterViewModel(this);
        }
    }
}
