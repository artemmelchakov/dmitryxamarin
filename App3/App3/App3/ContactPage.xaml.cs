using App3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void SaveContact(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            if (!String.IsNullOrEmpty(contact.NameDevice))
            {
                App.Database.SaveItem(contact);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteContact(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            App.Database.DeleteItem(contact.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}