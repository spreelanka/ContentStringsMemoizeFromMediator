using System;
using Xamarin.Forms;

namespace ContentStringsMemoizeFromMediator
{
	public class App
	{
		public static Page GetMainPage ()
		{
			var one = DemoContentStrings.Loading.Text;
			var oneagain = DemoContentStrings.Loading.Text;
			var oneFromNested = DemoContentStrings.Loading.LoadingSubclass.Text2;
			var oneFromNestedAgain = DemoContentStrings.Loading.LoadingSubclass.Text2;
			DemoContentStrings.Locale = LocaleTypes.Two;

			var two = DemoContentStrings.Loading.Text;
			var twoagain = DemoContentStrings.Loading.Text;
			var twoFromNested = DemoContentStrings.Loading.LoadingSubclass.Text2;
			var twoFromNestedAgain = DemoContentStrings.Loading.LoadingSubclass.Text2;


			return new ContentPage { 
				Content = new Label {
					Text = "Hello, Forms!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},

			};
		}
	}
}

