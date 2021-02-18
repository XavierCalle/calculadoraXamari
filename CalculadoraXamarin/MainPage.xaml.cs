using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void clearButton(object sender, EventArgs e)
        {
            result.Text = "";
            number1.Text = "";
            number2.Text = "";
        }
        private void sumaButton(object sender, EventArgs e)
        {
            var num1 = float.Parse(number1.Text);
            var num2 = float.Parse(number2.Text);
            var total = num1 + num2;
            result.Text = total.ToString();
        }

        private void restaButton(object sender, EventArgs e)
        {
            var num1 = float.Parse(number1.Text);
            var num2 = float.Parse(number2.Text);
            var total = num1 - num2;
            result.Text = total.ToString();
        }

        private void multiplicacionButton(object sender, EventArgs e)
        {
            var num1 = float.Parse(number1.Text);
            var num2 = float.Parse(number2.Text);
            var total = num1 * num2;
            result.Text = total.ToString();
        }

        private void divisionButton(object sender, EventArgs e)
        {
            var num1 = float.Parse(number1.Text);
            var num2 = float.Parse(number2.Text);
            var total = Math.Round(num1/num2, 2);
            result.Text = total.ToString();
        }


        private void potenciaButton(object sender, EventArgs e)
        {
            var num1 = float.Parse(number1.Text);
            var num2 = float.Parse(number2.Text);
            var total = Math.Pow(num1, num2);
            result.Text = total.ToString();
        }

        private void raizButton(object sender, EventArgs e)
        {
            var num1 = float.Parse(number1.Text);
            var num2 = float.Parse(number2.Text);
            var total = Math.Round(Math.Pow(num1, (1/num2)), 4);
            result.Text = total.ToString();
        }

    }
}
