using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XFFeatures.ViewModels
{
    public class RefreshViewPageViewModel : ViewModelBase
    {
        private readonly IPageDialogService _pageDialogService;
        public RefreshViewPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            Title = "Refresh View";
            _pageDialogService = pageDialogService;
            RefreshCommand = new DelegateCommand(async () => await OnRefresh());
        }

        private bool _isRefresh;
        public bool IsRefresh
        {
            get => _isRefresh;
            set => SetProperty(ref _isRefresh, value);
        }

        public DelegateCommand RefreshCommand { get; private set; }

       
        private async Task OnRefresh()
        {
            await _pageDialogService.DisplayAlertAsync("Action triggered", "Refresh", "Ok");

            IsRefresh = false;
        }
    }
}
