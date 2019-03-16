using Matsiuk02.Models;
using Matsiuk02.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Matsiuk02.Views;
using Matsiuk02.Exeptions;
using System.Threading;

namespace Matsiuk02.ViewModel
{

    class PersonRegisterViewModel : INotifyPropertyChanged
    {
        private readonly Action _signInSuccessAction;
        private readonly Window _parentWindow;

        private string _name;
        private string _surname;
        private string _email;
        private DateTime _date = DateTime.Today;
        private RelayCommand _proceedCommand;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

     
        public string BirthDateText { get; set; }

        public RelayCommand ReceedCommand
        {
            get
            {
                return _proceedCommand ?? (_proceedCommand = new RelayCommand(Proceed,
                           o => !string.IsNullOrWhiteSpace(_name) &&
                                !string.IsNullOrWhiteSpace(_surname) &&
                                !string.IsNullOrWhiteSpace(_email) &&
                                !string.IsNullOrWhiteSpace(BirthDateText)
                       ));
            }
        }

        
        internal PersonRegisterViewModel(Window parentWindow)
        {
            _parentWindow =  parentWindow; 
        }
        private bool IsDateValid(DateTime date)
        {
            return date < DateTime.Today && date.Year > 1920;
        }

        private async void Proceed(object o)
        {
            await Task.Run((() =>
            {
                MessageBox.Show("Loading");
                Thread.Sleep(2000);
                MessageBox.Show("Finished");
            }));

         _signInSuccessAction.Invoke();
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



