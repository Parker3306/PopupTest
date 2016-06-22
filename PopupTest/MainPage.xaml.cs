using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Rg.Plugins.Popup.Extensions;

namespace PopupTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnOpenPupup(object sender, EventArgs e)
		{
//			var page = new FirstPopupPage();
//			await Navigation.PushPopupAsync(page);
		}

		private async void OnUserAnimationPupup(object sender, EventArgs e)
		{
			var page = new UserAnimationPage();
			await Navigation.PushPopupAsync(page, true);
		}

		private async void OnOpenSystemOffsetPage(object sender, EventArgs e)
		{
//			var page = new SystemOffsetPage();
//			await Navigation.PushPopupAsync(page);
		}

		private async void OnOpenListViewPage(object sender, EventArgs e)
		{
//			var page = new ListViewPage();
//			await Navigation.PushPopupAsync(page);
		}
	}
}

