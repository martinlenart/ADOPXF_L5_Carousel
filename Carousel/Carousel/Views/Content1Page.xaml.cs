using Xamarin.Forms;

namespace Carousel.Views
{
	public partial class Content1Page : ContentPage
	{
		public Content1Page ()
		{
			InitializeComponent ();
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			Title = this.Title;
		}
	}
}

