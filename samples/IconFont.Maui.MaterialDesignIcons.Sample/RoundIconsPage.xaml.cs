using IconFont.Maui.MaterialDesignIcons.Sample.ViewModels;

namespace IconFont.Maui.MaterialDesignIcons.Sample;

public partial class RoundIconsPage : ContentPage
{
	public RoundIconsPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("MaterialDesignIconsRound");
	}
}
