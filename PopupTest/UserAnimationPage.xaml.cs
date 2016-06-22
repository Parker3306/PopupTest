using System;
using System.Collections.Generic;
//using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup.Pages;

namespace PopupTest
{
	public partial class UserAnimationPage : PopupPage
	{
		public UserAnimationPage()
		{
			InitializeComponent();
			Animation = new UserAnimation();
		}

		private void OnClose(object sender, EventArgs e)
		{
			PopupNavigation.PopAsync();
		}
	}
}

