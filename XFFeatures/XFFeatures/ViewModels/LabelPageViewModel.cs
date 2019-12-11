using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFFeatures.ViewModels
{
    public class LabelPageViewModel : ViewModelBase
    {
        public LabelPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private string _htmlValue;
        public string HtmlValue
        {
            get => _htmlValue;
            set => SetProperty(ref _htmlValue, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            HtmlValue = "<h1>Hello from Xamarin.Forms!</h1></br>This <i>Label</i>'s text is being displayed with <b>HTML</b>!";
        }
    }
}
