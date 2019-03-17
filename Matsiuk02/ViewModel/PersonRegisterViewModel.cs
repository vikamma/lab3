using Matsiuk02.Models;
using Matsiuk02.Tool;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using Matsiuk02.Views;
using Matsiuk02.Exeptions;

namespace Matsiuk02.ViewModel
{

    class PersonRegisterViewModel : INotifyPropertyChanged
    {

        private readonly Window _parentWindow;

        private string _name;
        private string _surname;
        private string _email;
        private DateTime _date = DateTime.Today;
        private RelayCommand _signInCommand;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }


    

        public RelayCommand Proceed
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand(RegisterImpl,
                           o => !string.IsNullOrWhiteSpace(_name) &&
                                !string.IsNullOrWhiteSpace(_surname)
                               &&
                                !string.IsNullOrWhiteSpace(_email) &&
                               !string.IsNullOrWhiteSpace(_date.ToString())
                              ));
                                
            }
        }

        private async void RegisterImpl(object o)
        {
            Person person = null;
            

            await Task.Run((() =>
            {
                try
                {
                    person = new Person(_name, _surname, _email, _date);
            }
                catch (PersonCreationException e)
            {
                MessageBox.Show(e.Message);
            }


        }));
            if (person == null)
                return;

            PersonInfoView personInfoView = new PersonInfoView(person);

            _parentWindow.Hide();
            personInfoView.Show();
        }

        internal PersonRegisterViewModel(Window parentWindow)
        {
            _parentWindow = parentWindow;
        }

        #region Implementation
        public event PropertyChangedEventHandler PropertyChanged;

       
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}



