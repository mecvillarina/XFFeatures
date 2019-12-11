using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using XFFeatures.ItemModels;

namespace XFFeatures.ViewModels
{
    public class CollectionViewPageViewModel : ViewModelBase
    {
        public CollectionViewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Collection View";
        }

        private ObservableCollection<PersonItemModel> _users;
        public ObservableCollection<PersonItemModel> Users
        {
            get => _users;
            set => SetProperty(ref _users, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            Users = new ObservableCollection<PersonItemModel>();
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Red });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Blue });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Green });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Yellow });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Pink });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.AliceBlue });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Bisque });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Black });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Cyan });
            Users.Add(new PersonItemModel() { FirstName = "Juan", LastName = "Dela Cruz", PersonColor = Color.Crimson });
        }
    }
}
