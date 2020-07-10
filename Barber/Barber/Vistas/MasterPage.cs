using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Barber
{
    public class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PaginaPrueba))) //Lo que esta generando 
                                                                                              //tiene una navegación dentro
            {

            };
        }
    }
}
