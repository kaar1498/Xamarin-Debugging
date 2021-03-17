using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Debugging
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void NextPage(object sender, System.EventArgs e)
        {
            var vNextPage = new CalculateAge();
            await Navigation.PushAsync(vNextPage);

        }

        async void ModPage(object sender, System.EventArgs e)
        {
            var vNextPage = new Mod();
            await Navigation.PushAsync(vNextPage);
        }

        async void CommonError_1Page(object sender, System.EventArgs e)
        {
            var vNextPage = new commonError_1();
            await Navigation.PushAsync(vNextPage);
        }
    }
}
