using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JeniferPaulina_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaDos : ContentPage
    {
        string nombreusuario = "";
        double pagototal = 0;

        public VentanaDos(string usuario, string clave)
        {
            InitializeComponent();
            this.nombreusuario = usuario;
            lblNombreUser.Text = "usuario concetado: "+usuario;
        }

        

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double costoestablecio = 1800;
            double montoinicial = Double.Parse(txtpagoi.Text);

            double mensualidad = (costoestablecio * 0.05) + ((costoestablecio - montoinicial)/3);

            this.pagototal = mensualidad * 3;
            lblPagoMensual.Text = "Pagop Mensual: " + mensualidad.ToString();

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombreusuario = txtNombreUser.Text;

            await DisplayAlert("Alerta", "Elemento guardado con exito", "OK");
            await Navigation.PushAsync(new VentanaTres(nombreusuario, this.nombreusuario, this.pagototal));
        }
    }
}
