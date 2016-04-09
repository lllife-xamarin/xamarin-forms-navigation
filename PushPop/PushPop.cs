using System;

using Xamarin.Forms;

namespace PushPop
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new NavigationPage(new PushPopPage ());
		}
	}
}