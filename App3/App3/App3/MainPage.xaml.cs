using App3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            contactsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Contact selectedContact = (Contact)e.SelectedItem;
            ContactPage contactPage = new ContactPage();
            contactPage.BindingContext = selectedContact;
            await Navigation.PushAsync(contactPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateContact(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            ContactPage contactPage = new ContactPage();
            contactPage.BindingContext = contact;
            await Navigation.PushAsync(new NavigationPage(contactPage));
        }
    }
}
