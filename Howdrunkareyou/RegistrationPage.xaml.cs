using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Howdrunkareyou
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();

            ContinueButton.Clicked += async (sender, args) =>
            {
                int weight;
                if (EntryControl.Text == "")
                {
                    if (switchControl.IsToggled)
                        weight = 65;
                    else
                        weight = 73;

                    await Navigation.PushModalAsync(new StartPage(switchControl.IsToggled, weight));
                }
                else
                    await Navigation.PushModalAsync(new StartPage(switchControl.IsToggled, Convert.ToInt32(EntryControl.Text)));
            };

        }
    }
}
