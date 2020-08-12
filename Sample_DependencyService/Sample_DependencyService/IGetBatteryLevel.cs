using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_DependencyService
{
    //インターフェースの実態はネイティブプラットフォーム側で実装
    public interface IGetBatteryLevel
    {
        int BatteryLevel();
    }
}
