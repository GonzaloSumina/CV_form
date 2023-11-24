
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CV_form
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CV : ContentPage
    {
        private UserData persona;
        public CV(UserData persona)
        { 
            this.persona = persona;
            InitializeComponent();
            LlenarDatos();
        }

        private void LlenarDatos()
        {
            if (persona != null)
            {
                rsnombre.Text = persona.Nombre;
                rsapellido.Text = persona.Apellido;
                rscorreo.Text = persona.Correo;
                rstelefono.Text = persona.Telefono;
                rsocupacion.Text = persona.Ocupacion;
            }
        }
        private void volver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}