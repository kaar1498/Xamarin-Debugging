using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.FormsBook.Toolkit;

namespace Debugging
{
    public partial class commonError_1 : ContentPage
    {

        public ColorViewModel vm = new ColorViewModel();

        public commonError_1()
        {
            InitializeComponent();


            thePicker.ItemsSource = vm.Colors;

          

        }




        void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                //Creates a copy
                Point point1 = new Point(20, 30);
                Point point2 = point1; //the same as below??
                point2.X = Convert.ToInt32(thepoint.Text); //needs safe submit

                lblPoint1.Text = point1.X.ToString();
                lblPoint2.Text = point2.X.ToString();


                // Creates a pointer
                Pen pen1 = new Pen(vm.Colors[0]);
                Pen pen2 = pen1; //the same as before?
                pen2.Color = thePicker.SelectedItem.ToString();

                lblPen1.Text = pen1.Color.ToString();
                lblPen2.Text = pen2.Color.ToString();
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Something went wrong, try again", "OK");
            }
        }
    }

    public class Pen
    {
        public string Color;
        public Pen(string p_color) 
        {
            Color = p_color;
        }
    }

}
