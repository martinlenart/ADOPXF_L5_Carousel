using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Carousel.Views
{
	public partial class MainPage : CarouselPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			this.Children.Add(new Content3Page());
		}
	}
}

