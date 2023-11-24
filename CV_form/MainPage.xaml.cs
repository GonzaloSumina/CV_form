using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CV_form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void enviar_FCV_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rptaname.Text) && !string.IsNullOrEmpty(rptasurname.Text) && !string.IsNullOrEmpty(rptagmail.Text) && !string.IsNullOrEmpty(rptaphone.Text) && !string.IsNullOrEmpty(rptaocupation.Text))
            {
                UserData persona = new UserData
                {
                    Nombre = rptaname.Text,
                    Apellido = rptasurname.Text,
                    Correo = rptagmail.Text,
                    Telefono = rptaphone.Text,
                    Ocupacion = rptaocupation.Text
                };
                Navigation.PushAsync(new CV(persona));
            }
            else
            {
                DisplayAlert("Error", "Debe completar todas las casillas", "OK");
            }
        }
    }
}
