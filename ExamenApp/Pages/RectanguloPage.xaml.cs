namespace ExamenApp.Pages;

public partial class RectanguloPage : ContentView
{
	public RectanguloPage()
	{
		InitializeComponent();
        BindingContext = new RectangleViewModel();
    }
}
