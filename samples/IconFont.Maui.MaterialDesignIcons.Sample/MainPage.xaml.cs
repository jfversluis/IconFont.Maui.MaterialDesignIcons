using IconFont.Maui.MaterialDesignIcons.Sample.ViewModels;

namespace IconFont.Maui.MaterialDesignIcons.Sample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new IconsViewModel("MaterialDesignIconsOutlined");
	}
}
