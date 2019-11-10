using System;
using System.Collections.Generic;
using Xamarin.Forms;
using BibliotecaApp.Models;
using BibliotecaApp.View.Home;
using BibliotecaApp.View.ConsultarLibros;
using BibliotecaApp.View.Prestamos;
using BibliotecaApp.View.Moras;
using BibliotecaApp.View.Historial;

namespace BibliotecaApp
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();

            menuList = new List<MasterPageItem>();
            var page1 = new MasterPageItem() { id = 1, Title = "Consultar Libros", Icon = "Libros.png" };
            var page2 = new MasterPageItem() { id = 2, Title = "Prestamos", Icon = "Prestamos.png" };
            var page3 = new MasterPageItem() { id = 3, Title = "Moras", Icon = "Historial.png" };
            var page4 = new MasterPageItem() { id = 4, Title = "Historial", Icon = "Historial.png" };
            
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);            
            navigationDrawerList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        async private void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {


            var myselecteditem = e.Item as MasterPageItem;

            switch (myselecteditem.id)
            {

                case 1:
                    await Navigation.PushAsync(new HomePage());

                    break;
                case 2:
                    await Navigation.PushAsync(new ConsultarLibros());

                    break;
                case 3:
                    await Navigation.PushAsync(new Prestamos());

                    break;
                case 4:
                    await Navigation.PushAsync(new Moras());

                    break;
                case 5:
                    await Navigation.PushAsync(new Historial());
                    break;
            


            }
           ((ListView)sender).SelectedItem = null;
            IsPresented = false;


        }


    }
}
