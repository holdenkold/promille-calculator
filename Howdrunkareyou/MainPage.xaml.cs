using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Howdrunkareyou
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        int beerCount = 0;
        int wineCount = 0;
        int shotsCount = 0;
        public MainPage(bool gender, int weight, double time)
        {
            InitializeComponent();

            beerEntry.Text = beerCount.ToString();
            beerEntry.TextChanged += BeerEntry_TextChanged;
            void BeerEntry_TextChanged(object sender, TextChangedEventArgs e)
            {
                beerCount = Convert.ToInt32(e.NewTextValue);
            }
            beerButton.Clicked += (sender, args) =>
            {
                beerCount++;
                beerEntry.Text = beerCount.ToString();
            };

            wineEntry.Text = wineCount.ToString();
            wineEntry.TextChanged += WineEntry_TextChanged;
            void WineEntry_TextChanged(object sender, TextChangedEventArgs e)
            {
                wineCount = Convert.ToInt32(e.NewTextValue);
            }
            wineButton.Clicked += (sender, args) =>
            {
                wineCount++;
                wineEntry.Text = wineCount.ToString();
            };


            shotsEntry.Text = shotsCount.ToString();
            shotsEntry.TextChanged += ShotsEntry_TextChanged;
            void ShotsEntry_TextChanged(object sender, TextChangedEventArgs e)
            {
                shotsCount = Convert.ToInt32(e.NewTextValue);
            }
            liqeuerButton.Clicked += (sender, args) =>
            {
                shotsCount++;
                shotsEntry.Text = shotsCount.ToString();
            };



            CalculateButton.Clicked += async (sender, args) =>
            {
                double gr = 0.05 * 500 * beerCount + 0.13 * 125 * wineCount + 0.4 * 25 * shotsCount;
                double promille = PromilleCalculate(gr, weight, gender, time);
                await Navigation.PushModalAsync(new ResultPage(promille));
            };

        }
        public double PromilleCalculate(double gr, int kilos, bool gender, double time)
        {
            double A = gr;
            double r = 0;
            if (gender)
                r = 0.55;
            else
                r = 0.66;

            return Math.Max(0, A / (kilos * r) - 0.13 * time);
        }
    }
}
