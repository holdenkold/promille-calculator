using System;

using Xamarin.Forms;

namespace Howdrunkareyou
{
    public class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

