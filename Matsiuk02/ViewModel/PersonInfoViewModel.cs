using Matsiuk02.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Matsiuk02.ViewModel
{
    class PersonInfoViewModel : INotifyPropertyChanged
    {
        private readonly Person _person;

        public string Name => $"Your first name:\n{_person.Name}";
        public string Surname => $"Your last name:\n{_person.Surname}";
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
