using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

using Prism.Navigation;
using System.ComponentModel;
using Reactive.Bindings;

namespace Sample_PrismPage.ViewModels
{
    public class Page2ViewModel : BindableBase, INotifyPropertyChanged, INavigationAware
    {
        public AsyncReactiveCommand PrevPageCommand { get; set; } = new AsyncReactiveCommand();

        public AsyncReactiveCommand FirstPageCommand { get; set; } = new AsyncReactiveCommand();

        public Page2ViewModel(INavigationService navigationService)
        {
            PrevPageCommand.Subscribe(async _ => await navigationService.GoBackAsync());
            FirstPageCommand.Subscribe(async _ => await navigationService.GoBackToRootAsync());
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

    }
}
