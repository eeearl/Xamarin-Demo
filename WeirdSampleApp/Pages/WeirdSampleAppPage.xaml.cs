using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace WeirdSampleApp
{
	public partial class WeirdSampleAppPage : ContentPage
	{
		public WeirdSampleAppPage()
		{
			InitializeComponent();

			GoLayoutPageButton.Clicked += OnLayoutPageButtonClicked;
			GoPassDataPageButton.Clicked += OnPassButtonClicked;
			GoDialogPageButton.Clicked += OnDialogButtonClicked;
		}


		async void OnListViewPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ListPage());
		}

		async void OnDialogButtonClicked(object sender, EventArgs e)
		{
			var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
			Debug.WriteLine("Answer: " + answer);
		}

		async void OnPassButtonClicked(object sender, EventArgs e)
		{
			var detailInfo = new DetailInfo
			{
				Name = "John",
				Age = 23
			};

			var passDataPage = new PassDataPage();
			passDataPage.BindingContext = detailInfo;

			await Navigation.PushAsync(passDataPage);
		}

		async void OnLayoutPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new LayoutPage());
		}
	}
}

