using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Howdrunkareyou
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double promille)
        {
            InitializeComponent();
            ResultLabel.Text = Math.Round(promille, 2).ToString() + "‰ int your blood";
            if (promille < 0.2)
            {
                DesidionLabel.Text = "You can drive :)";
                DesidionLabel.TextColor = Color.SpringGreen;
            }
            else
            {
                DesidionLabel.Text = "You can't drive ;--;";
                DesidionLabel.TextColor = Color.DarkRed;
            }
        }

    }
}
