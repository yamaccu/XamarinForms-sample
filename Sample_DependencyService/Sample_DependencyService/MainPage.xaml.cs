using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample_DependencyService
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //ViewModelをインスタンス化
        ViewModel vm = new ViewModel();

        public MainPage()
        {
            InitializeComponent();
            //バインディングコンテキストにViewModelを登録
            BindingContext = vm;
        }
    }
}
