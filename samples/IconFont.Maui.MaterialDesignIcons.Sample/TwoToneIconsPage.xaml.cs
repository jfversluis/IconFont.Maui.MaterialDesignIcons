using IconFont.Maui.MaterialDesignIcons.Sample.ViewModels;

namespace IconFont.Maui.MaterialDesignIcons.Sample;

public partial class TwoToneIconsPage : ContentPage
{
	public TwoToneIconsPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("MaterialDesignIconsTwoTone");
	}
}
