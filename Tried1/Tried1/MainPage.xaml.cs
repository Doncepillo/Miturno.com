using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tried1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaTurnos());

        }
        private void ListaTurnos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaTurnos());

        }
        private void MiCuenta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MiCuenta());

        }
        private void MiPerfil(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MiPerfil());

        }
        private void MiRendimiento(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MiRendimiento());

        }
        private void MisNotificaciones(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MisNotificaciones());

        }
        private void MisTurnos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MisTurnos());

        }
    }

}
