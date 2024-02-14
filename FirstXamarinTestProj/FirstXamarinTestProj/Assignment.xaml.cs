using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstXamarinTestProj
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Assignment : ContentPage
	{
		public Assignment ()
		{
			InitializeComponent ();
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			string firstName = fName.Text;
			string lastName = lName.Text;
			string comments = Pcomments.Text;
			DisplayAlert("Alert", $"{firstName} {lastName}\n{comments}", "OK");

		}
		private void Button_Clicked_2(object sender, EventArgs e)
		{
			fName.Text = "";
			lName.Text = "";
			Pcomments.Text = "";

		}


	}
}