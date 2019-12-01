using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectApp
{
    public partial class MainPage : ContentPage
    {
        //array of random words to display
        String[] randomWord = new String[] { "Randomize", "Celery", "SuperRandom", "CaseSeNSiTive","TryTo Type it Faster", "Xamarin"};

        public MainPage()
        {
            InitializeComponent();

            //Initialize random function
            Random rnd = new Random();
            rnd.Next(5);

            // displays random words
            lbl.Text = randomWord[rnd.Next(5)];
        }
    }
}
