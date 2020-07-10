using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Barber
{
    public class PaginaPrueba : ContentPage
    {
        Label Figma;
        RelativeLayout ContenedorPrincipal;

        public PaginaPrueba()
        {

            CrearVistas();
            AgregarVistas();
            AgregarEventos();
        }

        void CrearVistas()
        {
            Figma = new Label
            {
                Text = " Bienvenidos ",
                TextColor = Color.Black
            };

            ContenedorPrincipal = new RelativeLayout
            {

            };
        }
        void AgregarVistas()
        {
            Core Posiones = new Core();

            ContenedorPrincipal.Children.Add(Figma,
            Constraint.RelativeToParent((p) => { return p.Width * 52 ; }),  //X       (52*100)/375 = 13.866 /100 = 0.1386
            Constraint.RelativeToParent((p) => { return p.Height * 0.1679; })); //Y      (112*100)/375 = 16.791/100 = 0.1679
 
            Content = ContenedorPrincipal;
        }
        void AgregarEventos()
        {

        }
    }
}