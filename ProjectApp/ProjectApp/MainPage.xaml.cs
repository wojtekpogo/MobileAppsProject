using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// implement timer V
using System.Timers;
using Xamarin.Forms;

namespace ProjectApp
{
    public partial class MainPage : ContentPage
    {
        //initialize timer
       Stopwatch stopwatch;

        //array of random words to display
        String[] randomWord = new String[] { "Randomize", "Celery", "SuperRandom", "CaseSeNSiTive","TryTo Type it Faster", "Xamarin"};

        public MainPage()
        {
            InitializeComponent();

            Stopwatch stopwatch = new Stopwatch();

            time.Text = "00:00:00:00000";

            //Initialize random function
            Random rnd = new Random();
            rnd.Next(5);

            // displays random words
            lbl.Text = randomWord[rnd.Next(5)];


         


            void entry_TextChanged(object sender, EventArgs e)
            {

                stopwatch.Start();
                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {

                    time.Text = stopwatch.Elapsed.ToString();


                    //?
                    return true;
                }
                );

      
                

            }

          



           

        }

      


        // new game button
        private void Btn_Clicked(object sender, EventArgs e)
        {

            /*
            //Initialize random function
            Random rnd = new Random();
            rnd.Next(5);

            // displays random words
            lbl.Text = randomWord[rnd.Next(5)];


    */
           stopwatch.Start();

            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {

                time.Text = stopwatch.Elapsed.ToString();


                //?
                return true;
            }
            );

        }
    }
}
