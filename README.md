# sample-XamarinForms

XamarinFormsを理解するためのサンプルです。（自分用）

## Sample-DependencyService

androidのバッテリー残量を表示するアプリ。 DependencyServiceの使い方。 
  
### 画面表示  
&emsp;&emsp;共通部でView/ViewModelを作成

### バッテリー残量取得
1. 共通部にインターフェース（バッテリー残量取得用）を作成
2. Android部でインターフェースの実態を実装
3. DependencyServiceクラスとインターフェースを紐づけして、共通部からDependencyService.Get<>でインターフェースを実行、バッテリー残量を取得



