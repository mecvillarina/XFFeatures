using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFFeatures.ViewModels
{
    public class RefreshViewPageViewModel : ViewModelBase
    {
        public RefreshViewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
