using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Debugging
{
    public partial class Mod : ContentPage
    {
        public Mod()
        {
            InitializeComponent();

        }

        void HandleNumber(object sender, System.EventArgs e)
        {
            int CurrentNumber = Convert.ToInt32(entNumber.Text);
            ModNumber(CurrentNumber);


        }

        void ModNumber(int Number)
        {
            try
            {
                int Result;
                if (Number % 5 == 1)
                    throw new UnauthorizedAccessException();
                else
                    Result = Number;
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Something went wrong, try again", "OK");
            }
        }


        void runArray(object sender, System.EventArgs e)
        {
            List<int> numberArray = new List<int>();
            numberArray.Add(1);
            numberArray.Add(2);
            numberArray.Add(3);
            numberArray.Add(4);
            numberArray.Add(5);
            numberArray.Add(6);
            numberArray.Add(7);
            numberArray.Add(8);
            numberArray.Add(21);
            numberArray.Add(23);

            foreach(int number in numberArray)
            {
                ModNumber(number); //what number(s) are failing?
            }


        }
    }
}
