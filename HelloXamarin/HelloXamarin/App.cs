using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class App : Application
    {
        public App()
        {
            Button btnXBox = new Button();
            btnXBox.Text = "XBox One Rules!";
            btnXBox.Clicked += (sender, args) =>
            {
                btnXBox.Text = "I heart XBox One!";
            };

            Button btnPS4 = new Button();
            btnPS4.Text = "PS4 Rules!";
            btnPS4.Clicked += (sender, args) =>
            {
                btnPS4.Text = "I heart Playstation 4!";
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        btnXBox,
                        btnPS4
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
