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
            Title = "Main Page";

            NavigateToCommand = new DelegateCommand<string>(async (viewName) => await OnNavigateToCommand(viewName));
        }

        public DelegateCommand<string> NavigateToCommand { get; private set; }

        private async Task OnNavigateToCommand(string viewName)
        {
            await NavigationService.NavigateAsync(viewName);
        }
    }
}
