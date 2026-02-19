using IconFont.Maui.MaterialDesignIcons.Sample.ViewModels;

namespace IconFont.Maui.MaterialDesignIcons.Sample;

public partial class SharpIconsPage : ContentPage
{
	public SharpIconsPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("MaterialDesignIconsSharp");
	}
}
