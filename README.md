# sample-XamarinForms

XamarinFormsを理解するためのサンプルです。（自分用）

## Sample_DependencyService

androidのバッテリー残量を表示するアプリ。 DependencyServiceの使い方。 
  
### 画面表示  
&emsp;&emsp;共通部でView/ViewModelを作成

### バッテリー残量取得
1. 共通部にインターフェース（バッテリー残量取得用）を作成
2. Android部でインターフェースの実態を実装
3. DependencyServiceクラスとインターフェースを紐づけして、共通部からDependencyService.Get<>でインターフェースを実行、バッテリー残量を取得

## sample_PageTransition   

ページ遷移のサンプル。NavigationPageの使い方。
   
### MainPage登録

app.csで   
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


