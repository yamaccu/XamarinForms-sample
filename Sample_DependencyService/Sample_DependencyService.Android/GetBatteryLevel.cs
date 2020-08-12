using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using Sample_DependencyService.Droid;

//プラットフォーム側の実装をDependencyServiceに登録
[assembly: Dependency(typeof(GetBatteryLevel))]

namespace Sample_DependencyService.Droid
{
    public class GetBatteryLevel : IGetBatteryLevel
    {
        public int BatteryLevel()
        {
            //バッテリーのブロードキャストインテントを受信する
            IntentFilter ifilter = new IntentFilter(Intent.ActionBatteryChanged);
            Intent batteryStatus = Android.App.Application.Context.RegisterReceiver(null, ifilter);

            //バッテリー残量をリターン
            return batteryStatus.GetIntExtra(BatteryManager.ExtraLevel, -1);
        }
    }
}