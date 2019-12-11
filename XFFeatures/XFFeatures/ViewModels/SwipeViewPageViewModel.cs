using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFFeatures.ViewModels
{
    public class SwipeViewPageViewModel : ViewModelBase
    {
        public SwipeViewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Swipe View";
        }
    }
}
