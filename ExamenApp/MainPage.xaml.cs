using ExamenApp.Pages;

namespace ExamenApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        // Pestaña 1: Área del circulo
        Children.Add(new CirculoPage());

        // Pestaña 2: Área del rectángulo
        Children.Add(new RectanguloPage());
    }

    public object Children { get; }
}


