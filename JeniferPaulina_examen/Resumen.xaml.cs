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
    public partial class VentanaTres : ContentPage
    {
        public VentanaTres(string nombreusuario, string usuarioconectado, double pagofin)
        {
            InitializeComponent();
            txtnombreusuario.Text = "Nombre usuario: " + nombreusuario;
            txtusuarioconectado.Text = "Usuario conectado: " + usuarioconectado;
            txtPagofinal.Text = "Total a Pagar: " + pagofin.ToString();
        }

    }

}

