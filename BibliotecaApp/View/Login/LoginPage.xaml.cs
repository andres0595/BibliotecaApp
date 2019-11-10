using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaApp.View.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            //BtnIngresar.Clicked += BtnIngresar_Clicked;
        }
        private void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcontrasena.Text))
            {

            }

        }

    }
}