using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFFeatures.ViewModels
{
    public class NewFeaturesPageViewModel : ViewModelBase
    {
        public NewFeaturesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "New Features (4.4 Preview)";
        }
    }
}
