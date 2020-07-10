using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Barber
{
    public class Core
    {
        //public static int ScreenWidh { get; set; }
        //public static int Screenheigh { get; set; }

      

        public double CalculoAncho(double Ancho)
        {
            Ancho = ((Ancho * 100) / 375)/100;
        
            return Ancho;
        }

        public double CalculoAlto(double Alto)
        {

            Alto = ((Alto * 100) / 667)/100;

            return Alto;
        }
    }
}
