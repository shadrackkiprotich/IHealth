using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHealth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpButton(object sender, EventArgs e)
        {
            Data data = new Data();
            
            string name = Name.Text;
            string email = Email.Text;
            string password = Password.Text;
            string retypePassword = RetypePassword.Text;
            if (password != retypePassword)
            {
                DisplayAlert("Error passwords do not match", " Retype password", "Cancel");
            }
            data.Name = name;
            data.Email = email;
            data.Password = password;
           
            Navigation.PushAsync(new NavigationPage(new Home()));
        }

       /* private void FBButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MainPage()));
        }

        private void GoogleButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MainPage()));
        }*/
    }
}