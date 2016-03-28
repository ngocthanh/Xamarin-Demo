using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
			btn1.Clicked += OnButtonClicked;
		}

		void OnButtonClicked(object sender, EventArgs e)
		{
			
		}
	}
}

