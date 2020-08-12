using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Reactive.Bindings;
using Xamarin.Forms;

namespace Sample_DependencyService
{
    public class ViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ReactiveProperty<string> Battery { get; set; } = new ReactiveProperty<string>("xxx %");

        public ReactiveCommand GetBatteryLevelCommand { get; set; } = new ReactiveCommand();

        public ViewModel()
        {
            GetBatteryLevelCommand.Subscribe(_ => GetBatteryLevel());
        }

        public void GetBatteryLevel()
        {
            //Get<>メソッドで、ネイティブプラットフォームで実装したインターフェースを起動
            IGetBatteryLevel GetBatteryLevel = DependencyService.Get<IGetBatteryLevel>();
            Battery.Value = Convert.ToString(GetBatteryLevel.BatteryLevel())+"%";
        }

    }
}
