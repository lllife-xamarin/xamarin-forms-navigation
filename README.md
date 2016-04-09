### Xamarin.Forms navigation

#### Entry point

```csharp
public class App : Application
{
    public App ()
    {
        MainPage = new NavigationPage(new PushPopPage ());
    }
}
```

#### PushPopPage

```csharp
public class PushPopPage : ContentPage
{
    public PushPopPage ()
    {
        Content = new StackLayout {
            Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0),
            Children = {
                new Button() {
                    Text = "Push",
                    Command = new Command (() => Navigation.PushAsync (new PushPopPage ()))
                },
                new Button() {
                    Text = "Pop",
                    Command = new Command (() => Navigation.PopAsync ())
                },
                new Button() {
                    Text = "Push Model",
                    Command = new Command (() => Navigation.PushModalAsync (new ModalPage()))
                }
            }
        };
    }
}
```

![](screen/navigation.png)

#### Reference

- https://www.syntaxismyui.com/xamarin-forms-navigation-page
