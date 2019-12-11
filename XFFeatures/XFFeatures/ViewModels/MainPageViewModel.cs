using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFFeatures.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Features";

            NavigateToCommand = new DelegateCommand<string>(async (viewName) => await OnNavigateToCommand(viewName));
        }

        public DelegateCommand<string> NavigateToCommand { get; private set; }

        private async Task OnNavigateToCommand(string viewName)
        {
            var result = await NavigationService.NavigateAsync(viewName);
        }
    }
}
