using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using AppMapNavigationExample.Infrastructure;

namespace AppMapNavigationExample.ViewModels
{
    public class OtherPageViewModel : AppMapViewModelBase
    {


        public OtherPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
