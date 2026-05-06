using IconFont.Maui.MaterialDesignWebIcons.Sample.ViewModels;

namespace IconFont.Maui.MaterialDesignWebIcons.Sample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("MaterialDesignWebIcons");
	}
}
