using System;

using Xamarin.Forms;

namespace PushPop
{
	public class ModalPage : ContentPage
	{
		public ModalPage ()
		{
			Content = new StackLayout {
				Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0),
				Children = {
					new Button() {
						Text = "Pop Model",
						Command = new Command(() => Navigation.PopModalAsync())
					},
					new Image {
						Aspect = Aspect.AspectFit,
						Source =  ImageSource.FromFile("jw.png")
					}
				}
			};
		}
	}
}