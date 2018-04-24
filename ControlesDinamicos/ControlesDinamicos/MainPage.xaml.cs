using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlesDinamicos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			
		}
        public void Button1_Clicket(object sender, EventArgs e)
        {
            panel.Children.Add(new Button()
            {
                Text = $"Button{panel.Children.Count + 1}"

            });
            

           
        } 
	}
}
