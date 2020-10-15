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
    public class Page1ViewModel : BindableBase, INotifyPropertyChanged, INavigationAware
    {
        public AsyncReactiveCommand NextPageCommand { get; set; } = new AsyncReactiveCommand();

        public Page1ViewModel(INavigationService navigationService)
        {
            //ボタンを押したときの処理登録
            NextPageCommand.Subscribe(async _ => await navigationService.NavigateAsync("Page2"));
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

    }
}
