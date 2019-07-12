//-----------------------------------------------------------------------
// <copyright file="C:\Users\Joche\source\repos\AppMapNavigationExample\AppMapNavigationExample\AppMapNavigationExample\ViewModels\ListPageViewModel.cs" company="BitFwks">
//     Author:  
//     Copyright (c) BitFwks. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using AppMapNavigationExample.Infrastructure;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;

namespace AppMapNavigationExample.ViewModels
{
    public class ListPageViewModel : AppMapViewModelBase
    {
        Dictionary<string, object> Parameters = new Dictionary<string, object>();
        string title;

        public ListPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
        

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Title = $"List Page {parameters[nameof(Title)].ToString()}";
            Parameters.Add(nameof(Title), parameters[nameof(Title)]);
        }

        public string Title
        {
            get { return title; }
            set
            {
                if(title == value)
                {
                    return;
                }
                title = value;
                RaisePropertyChanged();
            }
        }
    }
}
