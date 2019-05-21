using System;
using System.Collections.Generic;
using static System.Console;

using Xamarin.Forms;

namespace Howdrunkareyou
{
    public partial class StartPage : ContentPage
    {
        public StartPage(bool gender, int weight)
        {
            InitializeComponent();
            var now = DateTime.Now;

            ContinueButton.Clicked += async (sender, args) =>
                {
                    var StartTime = new DateTime(timePicker.Time.Ticks);
                    Console.WriteLine(StartTime);
                    Console.WriteLine("Calculated time");
                    double time = (now.Hour + now.Minute / 60) - (StartTime.Hour + StartTime.Minute / 60);
                    Console.WriteLine(time);
                    await Navigation.PushModalAsync(new MainPage(gender, weight, time));
                };
        }
    }
}
