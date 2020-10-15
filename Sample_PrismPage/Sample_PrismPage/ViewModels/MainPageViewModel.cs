using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using Reactive.Bindings;


namespace Sample_PrismPage.ViewModels
{
    public class MainPageViewModel : ViewModelBase, INotifyPropertyChanged, INavigationAware
    {
        //Asyncはボタンの二度押し防止
        public AsyncReactiveCommand NextPageCommand { get; set; } = new AsyncReactiveCommand();

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Main Page";

            //ボタンを押したときの処理登録
            NextPageCommand.Subscribe(async _ => await navigationService.NavigateAsync("Page1"));
        }
    }
}
