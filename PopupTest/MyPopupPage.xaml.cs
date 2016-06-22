using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace PopupTest
{
	public partial class MyPopupPage : PopupPage
	{
		public MyPopupPage()
		{
			InitializeComponent();

			Animation = new UserAnimation ();
		}

		private void OnClose(object sender, EventArgs e)
		{
			PopupNavigation.PopAsync();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
		}

		protected override bool OnBackButtonPressed()
		{
			// Prevent hide popup
			//return base.OnBackButtonPressed();
			return true; 
		}
	}
}

