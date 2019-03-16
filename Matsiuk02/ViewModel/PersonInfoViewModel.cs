using Matsiuk02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matsiuk02.ViewModel
{
    class PersonInfoViewModel : INotifyPropertyChanged
    {
        private readonly Person _person;

        public string Name => $"Your name:\n{_person.Name}";
        public string Surname => $"Your surname:\n{_person.Surname}";
        public string Email => $"Your email:\n{_person.Email}";
        public string Date => $"Your birthday:\n{_person.Date.ToShortDateString()}";
        public string Zodiac1 => $"Your sun sign:\n{_person.Zodiac1}";
        public string Zodiac2 => $"Your chinese sign:\n{_person.Zodiac2}";
        public string IsBirthday => $"Today is {(_person.IsBirthday ? "" : "not ")}your birthday";
        public string IsAdult => $"You are {(_person.IsAdult ? "" : "not ")}adult";

        public PersonInfoViewModel(Person person)
        {
            _person = person;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        #region Implementation
      
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
