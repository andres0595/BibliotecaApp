using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Web;

namespace BibliotecaApp.Droid.Services
{
    class WSLoginService
    {
        WSLogin.WebServicesAria wsd;
        public WSLoginService()
        {
            wsd = new WSLogin.WebServicesAria();            
        }

        public string Login(string x, string y)
        {
            string resultado = "";
            string reas = wsd.HelloWorld(x, y);
            return resultado;
        }
    }
}