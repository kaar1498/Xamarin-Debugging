using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Debugging
{
    public partial class CalculateAge : ContentPage
    {
        public CalculateAge()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                int ageEntered = Convert.ToInt32(entAge.Text);
                int ageerror = ageEntered / 0;
                if (ageEntered < 13)
                    DisplayAlert("child", "You are just a child", "OK");
                else
                    if (ageEntered >= 13 && ageEntered < 20)
                    DisplayAlert("Teenager", "You are just a Teen", "OK");
                else
                        if (ageEntered >= 20)
                    DisplayAlert("child", "You are adult. wohoo", "OK");
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Something was wrong with your age, try again", "OK");
            }

        }

        void Handle_Clicked_Error(object sender, System.EventArgs e)
        {
                int ageEntered = Convert.ToInt32(entAge.Text);
                int ageerror = ageEntered / 0; //You can't divide by zero, but it'll allow you to write the code to do so, funny that.
                if (ageEntered < 13)
                    DisplayAlert("child", "You are just a child", "OK");
                else
                    if (ageEntered >= 13 && ageEntered < 20)
                    DisplayAlert("Teenager", "You are just a Teen", "OK");
                else
                        if (ageEntered >= 20)
                    DisplayAlert("child", "You are adult. wohoo", "OK");

        }
    }
}
