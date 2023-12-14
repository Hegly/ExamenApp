namespace ExamenApp.Pages;

public partial class CirculoPage : ContentPage
{
	public CirculoPage()
	{
		InitializeComponent();
        BindingContext = new CircleViewModel();
    }
}
