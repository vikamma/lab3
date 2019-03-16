using System;
using System.Windows;
using Matsiuk02.Models;
using Matsiuk02.ViewModel;

namespace Matsiuk02.Views
{
    /// <summary>
    /// Interaction logic for PersonInfoView.xaml
    /// </summary>
    public partial class PersonInfoView : Window
    {
        public PersonInfoView (Person person) 
        {
            InitializeComponent();
            DataContext = new PersonInfoViewModel(person);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
    }
}
