using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample_PageTransition
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPageをNavigationPageに設定
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
