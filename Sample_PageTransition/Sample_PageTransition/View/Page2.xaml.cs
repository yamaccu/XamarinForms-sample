using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample_PageTransition.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void PrevPage(object sender, EventArgs e)
        {
            //1ページ戻る
            await Navigation.PopAsync();
        }

        private async void FirstPage(object sender, EventArgs e)
        {
            //最初のページに戻る
            await Navigation.PopToRootAsync();
        }

    }
}