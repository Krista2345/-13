using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace МатулевскаяПР13
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        int count = 1;
        public MainPage()
        {
            InitializeComponent();
            var forgetPassword_tab = new TapGestureRecognizer();
            forgetPassword_tab.Tapped += (s, e) =>
                {
                label1.Text = "Число: " + Convert.ToString(Math.Pow(2, count));

            };
            label1.GestureRecognizers.Add(forgetPassword_tab);
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            label2.TextColor = Color.Black;
            if (Int32.Parse(keyboard.Text) > 0)
            {
                long factorial = 1;
                int n = Int32.Parse(keyboard.Text);
                for (int i = 1; i<= n; i++)
                {
                    factorial *= i;
                }
                label2.Text = factorial.ToString();
            }
            else if (Int32.Parse(keyboard.Text) == 0)
            {
                label2.Text = Convert.ToString(1);
            }
            else
            {
                label2.Text = "Невозможно вычислить факториал для отрицательных чисел";
                label2.TextColor = Color.Red;
            }
        }
    }
}
