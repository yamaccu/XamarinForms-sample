# sample-XamarinForms

XamarinFormsを理解するためのサンプルです。（自分用）

# Sample_DependencyService

androidのバッテリー残量を表示するアプリ。 DependencyServiceの使い方。 
  
### 画面表示  
&emsp;&emsp;共通部でView/ViewModelを作成

### バッテリー残量取得
1. 共通部にインターフェース（バッテリー残量取得用）を作成
2. Android部でインターフェースの実態を実装
3. DependencyServiceクラスとインターフェースを紐づけして、共通部からDependencyService.Get<>でインターフェースを実行、バッテリー残量を取得

# sample_PageTransition   

ページ遷移のサンプル。NavigationPageの使い方。
   
### MainPage登録

&emsp;app.csで   
```
   MainPage = new NavigationPage(new MainPage());
```

### Page遷移
```
        private async void NextPage(object sender, EventArgs e)
        {
            //Page2へ進む
            await Navigation.PushAsync(new Page2());
        }
```
```
        private async void PrevPage(object sender, EventArgs e)
        {
            //1つ戻る
            await Navigation.PopAsync();
        }
```
```
        private async void FirstPage(object sender, EventArgs e)
        {
            //最初のページに戻る
            await Navigation.PopToRootAsync();
        }
```


# Sample_PrismPage

PrismでPage遷移するサンプル。

### Page遷移  
```
//Page1へ
navigationService.NavigateAsync("Page1") 

//前に戻る
navigationService.GoBackAsync()

//最初に戻る
navigationService.GoBackToRootAsync()
```
### ReactiveProtertyでボタンに登録
```
public class MainPageViewModel : ViewModelBase, INotifyPropertyChanged, INavigationAware
{
    //Asyncはボタンの二度押し防止
    public AsyncReactiveCommand NextPageCommand { get; set; } = new AsyncReactiveCommand();

    public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        //ボタンを押したときの処理登録
        NextPageCommand.Subscribe(async _ => await navigationService.NavigateAsync("Page1"));
    }
}
```




### Page遷移時イベント  
&emsp;&emsp;PageのOpen時：OnNavigatedToイベント  
&emsp;&emsp;PageのClose時：OnNavigatedFromイベント

```
public class Page2ViewModel : BindableBase, INavigationAware
{

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }
}
```


