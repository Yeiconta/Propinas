using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Propinas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnCalcular.Clicked += BtnCalcular_Clicked;
		}

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            double total = double.Parse(entTotal.Text);
            double propina = double.Parse(entPropina.Text);
            double numpersonas = double.Parse(entNumPer.Text);
            double resPropina = (total * propina) / 100;
            double resTotal = total + resPropina;
            double resProPer = resPropina / numpersonas;
            double resTotPer = resTotal / numpersonas;

            txtPropina.Detail = resPropina.ToString("C");
            txtTotal.Detail = resTotal.ToString("C");
            txtPropinaPer.Detail = resProPer.ToString("C");
            txtTotalPer.Detail = resTotPer.ToString("C");

            
        }
    }
}
